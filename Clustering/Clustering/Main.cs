using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using System.Collections.Generic;
using CsvHelper;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.ObjectModel;
using System.Linq;

namespace Clustering
{
    public partial class Main : Form
    {
        // Note the filepaths to locate the training data set, and to store the trained model
        static readonly string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "iris.data");
        static readonly string _dataFile = Path.Combine(Environment.CurrentDirectory, "Data", "iris.csv");
        static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "IrisClusteringModel.zip");

        PredictionModel<IrisData, ClusterPrediction> Model;
        IrisData Input;
        IEnumerable<IrisData> TrainedData;
        List<ClusterPrediction> ClusterPredictions;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Input = new IrisData();
            ClusterPredictions = new List<ClusterPrediction>();
            TrainedData = new List<IrisData>();
        }

        private async Task<PredictionModel<IrisData, ClusterPrediction>> Train()
        {
            // if our model has already been trained, return that
            if (File.Exists(_modelPath))
            {
                PredictionModel<IrisData, ClusterPrediction> trainedModel = await PredictionModel.ReadAsync<IrisData, ClusterPrediction>(_modelPath);
                if (trainedModel != null)
                {
                    Model = trainedModel;
                    return trainedModel;
                }
            }

            // Pipelines are necessary to load the data and train the model against specific features
            LearningPipeline pipeLine = new LearningPipeline();
            pipeLine.Add(new TextLoader(_dataPath).CreateFrom<IrisData>(separator: ','));
            pipeLine.Add(new ColumnConcatenator("Features", "SepalLength", "SepalWidth", "PetalLength", "PetalWidth"));

            // Split the data into 3 clusters
            //https://docs.microsoft.com/en-us/dotnet/api/microsoft.ml.trainers.kmeansplusplusclusterer
            //https://en.wikipedia.org/wiki/K-means_clustering
            pipeLine.Add(new KMeansPlusPlusClusterer() { K = 3 });

            Model = pipeLine.Train<IrisData, ClusterPrediction>();
            if (Model != null)
            {
                // We can save the model to be imported and used later in more .NET apps
                await Model.WriteAsync(_modelPath);
                return Model;
            }
            else
            {
                throw new NullReferenceException("The model failed to be trained");
            }

        }

        private void ValidateControls()
        {
            if (!string.IsNullOrWhiteSpace(txtPtlLgth.Text) && !string.IsNullOrWhiteSpace(txtPtlWdth.Text) && !string.IsNullOrWhiteSpace(txtSplLgth.Text) && !string.IsNullOrWhiteSpace(txtSplWdth.Text))
            {
                btnPredict.Enabled = true;
            }
        }

        private void GenerateClusters()
        {
            using (TextReader reader = File.OpenText(_dataFile))
            {
                CsvReader csv = new CsvReader(reader);
                TrainedData = new List<IrisData>(csv.GetRecords<IrisData>());                
            }

            foreach(IrisData iris in TrainedData)
            {
                ClusterPredictions.Add(PredictIris(iris));
            }

            PaintClusters();
        }

        private void PaintClusters()
        {
            try
            {
                ClusterPredictions.Sort((x, y) => x.PredictedClusterId.CompareTo(y.PredictedClusterId));
                
                ObservableCollection<MindFusion.Charting.Series> series = new ObservableCollection<MindFusion.Charting.Series>();
                series.Add( new IrisClusterSeries(ClusterPredictions));

                scatterChart1.Series = series;

                //foreach (ClusterPrediction prediction in ClusterPredictions)
                //{
                //    Series item = new Series
                //    {
                //        YValuesPerPoint = 3
                //    };
                //    item.Points.AddXY(prediction.PredictedClusterId, new[] { prediction.Distances[0], prediction.Distances[1], prediction.Distances[2] });
                    
                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private ClusterPrediction PredictIris(float SepalLength, float SepalWidth, float PetalLength, float PetalWidth)
        {
            IrisData iris = new IrisData
            {
                SepalLength = SepalLength,
                SepalWidth = SepalWidth,
                PetalLength = PetalLength,
                PetalWidth = PetalWidth
            };
            return PredictIris(iris);
        }

        private ClusterPrediction PredictIris(IrisData iris)
        {
            return Model.Predict(iris);
        }


        #region Events

        private void btnViewCluster_Click(object sender, EventArgs e)
        {
            GenerateClusters();
            scatterChart1.Visible = true;
        }

        private async void btnTrainMdl_ClickAsync(object sender, EventArgs e)
        {
            await Train();

            txtSplLgth.Enabled = true;
            txtSplWdth.Enabled = true;
            txtPtlLgth.Enabled = true;
            txtPtlWdth.Enabled = true;
            btnViewCluster.Enabled = true;
            btnTrainMdl.Enabled = false;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            if (Input == null)
            {
                Input = new IrisData();
            }

            Input.PetalLength = float.Parse(txtPtlLgth.Text);
            Input.PetalWidth = float.Parse(txtPtlWdth.Text);
            Input.SepalLength = float.Parse(txtSplLgth.Text);
            Input.SepalWidth = float.Parse(txtSplWdth.Text);

            ClusterPrediction prediction = PredictIris(Input);

            txtPredictions.Text += $"\r\n\r\nPetal Length: {txtPtlLgth.Text}cm";
            txtPredictions.Text += $"\r\nPetal Width: {txtPtlWdth.Text}cm";
            txtPredictions.Text += $"\r\nSepal Length: {txtSplLgth.Text}cm";
            txtPredictions.Text += $"\r\nSepal Width: {txtSplWdth.Text}cm";
            txtPredictions.Text += $"\r\n{new string('-', 30)}";
            txtPredictions.Text += $"\r\nCluster: {prediction.PredictedClusterId}";
            txtPredictions.Text += $"\r\nDistances: {string.Join(" ", prediction.Distances)}";
            txtPredictions.Text += $"\r\n{new string('*', 50)}";
        }

        private void txtPtlLgth_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtPtlWdth_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtSplLgth_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtSplWdth_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtSplWdth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void txtSplLgth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void txtPtlWdth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void txtPtlLgth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        #endregion

    }
}
