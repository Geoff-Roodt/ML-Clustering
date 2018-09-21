using System;
using System.Collections.Generic;
using MindFusion.Charting;

namespace Clustering
{
    public class IrisClusterSeries : Series
    {
        IList<ClusterPrediction> values;
        public event EventHandler DataChanged;
        public LabelKinds SupportedLabels
        {
            get { return LabelKinds.InnerLabel | LabelKinds.ToolTip; }
        }
        public int Size
        {
            get { return values.Count; }
        }
        public int Dimensions
        {
            get { return 2; }
        }
        public string Title
        {
            get
            {
                return "Iris Clusters";
            }
        }

        public IrisClusterSeries(List<ClusterPrediction> irisData)
        {
            values = irisData;
        }

        public double GetValue(int index, int dimension)
        {
            return values[index].PredictedClusterId;
        }

        public string GetLabel(int index, LabelKinds kind)
        {
            if (kind == LabelKinds.InnerLabel) return values[index].PredictedClusterId.ToString();
            if (kind == LabelKinds.ToolTip) return $"{values[index].PredictedClusterId} ({string.Join(" ", values[index].Distances)}";
            return null;
        }

        public bool IsSorted(int dimension)
        {
            return false;
        }

        public bool IsEmphasized(int index)
        {
            return false;
        }
    }
}
