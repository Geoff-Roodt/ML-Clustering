using Microsoft.ML.Runtime.Api;

namespace Clustering
{
    public class IrisData
    {
        [Column("0")]
        public float SepalLength { get; set; }

        [Column("1")]
        public float SepalWidth { get; set; }

        [Column("2")]
        public float PetalLength { get; set; }

        [Column("3")]
        public float PetalWidth { get; set; }

    }
}
