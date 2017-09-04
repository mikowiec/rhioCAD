#region Usings

using System;
using System.Collections.Generic;
using System.Windows.Controls;

#endregion

namespace NaroSetup.Pages.Metrics
{
    public sealed class MetricsFactory
    {
        private static readonly MetricsFactory InternalInstance = new MetricsFactory();

        public readonly Dictionary<string, double> MetricQuotas = new Dictionary<string, double>();

        private MetricsFactory()
        {
            AddMetricQuota("Milimeters", 1.0);
            AddMetricQuota("Centimeters", 10.0);
            AddMetricQuota("Inches", 25.4);
        }

        public static MetricsFactory Instance
        {
            get { return InternalInstance; }
        }

        private void AddMetricQuota(string name, double quota)
        {
            MetricQuotas.Add(name, quota);
        }

        public void PopulateListBox(ListBox listBox)
        {
            listBox.BeginInit();
            listBox.Items.Clear();
            foreach (var item in MetricQuotas)
            {
                listBox.Items.Add(item.Key);
            }

            listBox.EndInit();
        }

        public int GetClosestRatio(double ratio)
        {
            var pos = 0;
            foreach (var item in MetricQuotas.Values)
            {
                if (Math.Abs(Math.Log10(ratio/item)) < 0.1)
                {
                    return pos;
                }
                pos ++;
            }
            return -1;
        }
    }
}