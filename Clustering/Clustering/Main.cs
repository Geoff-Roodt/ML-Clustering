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

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

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

        private void btnTrainMdl_Click(object sender, EventArgs e)
        {
            Model = Train();
            if (Model != null)
            {
                Model.WriteAsync(_modelPath);
            }
            else {
                throw new NullReferenceException("The model failed to be trained");
            }
        }
    }
}
