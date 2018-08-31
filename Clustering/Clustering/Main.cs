using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;

namespace Clustering
{
    public partial class Main : Form
    {
        // Note the filepaths to locate the training data set, and to store the trained model
        static readonly string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "iris.data");
        static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "IrisClusteringModel.zip");

        PredictionModel<IrisData, ClusterPrediction> Model;
        IrisData Input;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Input = new IrisData();
        }

        private static PredictionModel<IrisData, ClusterPrediction> Train()
        {
            // Pipelines are necessary to load the data and train the model against specific features
            LearningPipeline pipeLine = new LearningPipeline();
            pipeLine.Add(new TextLoader(_dataPath).CreateFrom<IrisData>(separator: ','));
            pipeLine.Add(new ColumnConcatenator("Features", "SepalLength", "SepalWidth", "PetalLength", "PetalWidth"));

            // Split the data into 3 clusters
            //https://docs.microsoft.com/en-us/dotnet/api/microsoft.ml.trainers.kmeansplusplusclusterer
            //https://en.wikipedia.org/wiki/K-means_clustering
            pipeLine.Add(new KMeansPlusPlusClusterer() { K = 3 });

            return pipeLine.Train<IrisData, ClusterPrediction>();
        }

        private void ValidateControls()
        {
            if (!string.IsNullOrWhiteSpace(txtPtlLgth.Text) && !string.IsNullOrWhiteSpace(txtPtlWdth.Text) && !string.IsNullOrWhiteSpace(txtSplLgth.Text) && !string.IsNullOrWhiteSpace(txtSplWdth.Text))
            {
                btnPredict.Enabled = true;
            }
        }


        #region Events

        private void btnTrainMdl_Click(object sender, EventArgs e)
        {
            Model = Train();
            if (Model != null)
            {
                // We can save the model to be imported and used later in more .NET apps
                Model.WriteAsync(_modelPath);
            }
            else
            {
                throw new NullReferenceException("The model failed to be trained");
            }

            txtSplLgth.Enabled = true;
            txtSplWdth.Enabled = true;
            txtPtlLgth.Enabled = true;
            txtPtlWdth.Enabled = true;
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

            ClusterPrediction prediction = Model.Predict(Input);


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
