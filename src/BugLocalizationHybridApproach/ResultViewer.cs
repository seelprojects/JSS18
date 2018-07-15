using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using BugLocalizationHybridApproach.Properties;

namespace BugLocalizationHybridApproach
{
    public partial class ResultViewer : Form
    {
        public static readonly XmlSerializer ProcessorListResultSerializer = new XmlSerializer(typeof(ProcessorListResult));

        public ResultViewer()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {

            Execute();
        }

        private void Execute()
        {
            var projectNames = (from object selectedDataset in listBoxDataset.SelectedItems select selectedDataset.ToString()).ToList();
            var methodINames = (from object selectedMethodI in listBoxMethodI.SelectedItems select selectedMethodI.ToString()).ToList();
            var methodJNames = (from object selectedMethodJ in listBoxMethodJ.SelectedItems select selectedMethodJ.ToString()).ToList();
            var metricToUse = listBoxMetric.SelectedItem?.ToString();

            var warningMessages = new List<string>();
            if (projectNames.Count == 0)
            {
                warningMessages.Add("Please select at least one project.");
            }

            if (methodINames.Count == 0)
            {
                warningMessages.Add("Please select at least one method i.");
            }

            if (methodJNames.Count == 0)
            {
                warningMessages.Add("Please select at least one method j.");
            }

            if (string.IsNullOrWhiteSpace(metricToUse))
            {
                warningMessages.Add("Please select a metric to use.");
            }

            if (warningMessages.Count > 0)
            {
                ShowWarning(warningMessages);
                return;
            }

            var axisSetting = GetAxisSetting();

            var chartResults = new Dictionary<string, Dictionary<string, Chart>>();
            foreach (var projectName in projectNames)
            {
                chartResults.Add(projectName, new Dictionary<string, Chart>());
                foreach (var methodIName in methodINames)
                {
                    var result = GetResult(projectName, methodIName, methodJNames, metricToUse);
                    var chart = GetChart(result, projectName, methodIName, methodJNames, metricToUse, axisSetting);
                    chartResults[projectName].Add(methodIName, chart);
                }
            }

            const double startingX = 0;
            const double startingY = 0;

            SuspendLayout();
            panelGraphs.SuspendLayout();
            panelGraphs.Controls.Clear();

            int projectCounter = 0;
            foreach (var projectName in projectNames)
            {
                projectCounter++;
                var methodCounter = 0;
                foreach (var methodIName in methodINames)
                {
                    methodCounter++;
                    var chart = chartResults[projectName][methodIName];

                    int x = (int)(startingX + (methodCounter - 1) * (axisSetting.Width + 5));
                    int y = (int)(startingY + (projectCounter - 1) * (axisSetting.Height + 5));

                    chart.Location = new Point(x, y);
                    panelGraphs.Controls.Add(chart);
                }
            }

            panelGraphs.Invalidate();
            panelGraphs.ResumeLayout(false);
            panelGraphs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private AxisSetting GetAxisSetting()
        {
            var result = new AxisSetting
            {
                XMin = GetTextDouble(textBoxXMin.Text, 0),
                XInterval = GetTextDouble(textBoxXInterval.Text, 0.1),
                XMax = GetTextDouble(textBoxXMax.Text, 1),

                YMin = GetTextDouble(textBoxYMin.Text, 0),
                YInterval = GetTextDouble(textBoxYInterval.Text, 10),
                YMax = GetTextDouble(textBoxYMax.Text, 100),

                Width = (int)GetTextDouble(textBoxWidth.Text, 300),
                Height = (int)GetTextDouble(textBoxHeight.Text, 300),

                ShowLegend = false,
            };

            return result;
        }

        private static double GetTextDouble(string text, double defaultValue)
        {
            double temp;
            return double.TryParse(text, out temp) ? temp : defaultValue;
        }

        #region Data

        public Dictionary<string, Dictionary<double, double>> GetResult(string projectName, string methodIName, List<string> methodJNames, string metricToUse)
        {
            var result = methodJNames.ToDictionary(x => x, x => new Dictionary<double, double>());
            foreach (var methodJName in methodJNames)
            {
                var fileString = Resources.ResourceManager.GetString($"{ToLatex(projectName)}_{ToLatex(methodIName)}_{ToLatex(methodJName)}");
                using (var reader = new StringReader(fileString))
                {
                    var processorResult = (ProcessorListResult)ProcessorListResultSerializer.Deserialize(reader);
                    foreach (var resultKeyValue in processorResult.Results.OrderBy(x => x.Key))
                    {
                        result[methodJName].Add(resultKeyValue.Key, GetValue(resultKeyValue.Result, metricToUse));
                    }
                }
            }

            return result;
        }

        public static string ToLatex(string text)
        {
            switch (text)
            {
                case "Jsm":
                case "Vsm":
                case "Lsi":
                case "Pmi":
                    return text.ToUpperInvariant();

                case "Zxing":
                    return "ZXing";

                case "Swt":
                    return "SWT";

                default:
                    return text;
            }
        }

        private static double GetValue(DatasetMetricResult result, string metricToUse)
        {
            switch (metricToUse)
            {
                case "Top 01":
                case "TR1":
                    return result.Top01Percent;

                case "Top 05":
                case "TR5":
                    return result.Top05Percent;

                case "Top 10":
                case "TR10":
                    return result.Top10Percent;

                case "MRR":
                    return result.Mrr;

                case "MAP":
                    return result.Map;

                default:
                    return -10000;
            }
        }

        #endregion

        #region Graph

        private static Chart GetChart(IReadOnlyDictionary<string, Dictionary<double, double>> result, string projectName, string methodIName, IEnumerable<string> methodJNames, string metricToUse, AxisSetting axisSetting)
        {
            var namePrefix = projectName + methodIName + metricToUse;

            var chart = new Chart
            {
                Text = projectName,
                Name = namePrefix + "Chart",
                Width = axisSetting.Width,
                Height = axisSetting.Height,
            };

            var chartArea = new ChartArea
            {
                Name = namePrefix + "ChartArea",
            };
            chart.ChartAreas.Add(chartArea);

            var xAxis = new Axis(chartArea, AxisName.X)
            {
                Interval = axisSetting.XInterval,
                Minimum = axisSetting.XMin,
                Maximum = axisSetting.XMax
            };
            chartArea.AxisX = xAxis;

            var yAxis = new Axis(chartArea, AxisName.Y)
            {
                Interval = axisSetting.YInterval,
                Minimum = axisSetting.YMin,
                Maximum = axisSetting.YMax
            };
            chartArea.AxisY = yAxis;

            foreach (var methodJName in methodJNames)
            {
                var series = new Series()
                {
                    Name = namePrefix + methodJName + "Series",
                    Color = GetColor(methodJName),
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Line,
                };
                foreach (var key in result[methodJName].Keys)
                {
                    series.Points.AddXY(key, result[methodJName][key]);
                }

                if (axisSetting.ShowLegend)
                {
                    chart.Legends.Add(new Legend(methodJName));
                    chart.Legends[methodJName].Docking = Docking.Top;
                    chart.Legends[methodJName].Alignment = StringAlignment.Near;
                    chart.Legends[methodJName].LegendStyle = LegendStyle.Column;

                    series.Legend = methodJName;
                    series.LegendText = methodJName;
                }

                chart.Series.Add(series);
            }

            chart.Titles.Add($"{projectName} - {methodIName} - {metricToUse}");

            return chart;
        }

        private static Color GetColor(string method)
        {
            switch (method)
            {
                case "VSM":
                    return Color.Red;

                case "LSI":
                    return Color.Green;

                case "JSM":
                    return Color.Blue;

                default:
                    return Color.Black;
            }
        }

        #endregion


        public void ShowWarning(List<string> messages)
        {
            MessageBox.Show(this, messages.First(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void listBoxMetric_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxXMin.Text = "0";
            textBoxXInterval.Text = "0.1";
            textBoxXMax.Text = "1.0";

            var metricToUse = listBoxMetric.SelectedItem.ToString();
            if (!string.IsNullOrWhiteSpace(metricToUse))
            {
                if (metricToUse == "MAP" || metricToUse == "MRR")
                {
                    textBoxYMin.Text = "0";
                    textBoxYInterval.Text = "0.1";
                    textBoxYMax.Text = "1.0";
                }
                else
                {
                    textBoxYMin.Text = "0";
                    textBoxYInterval.Text = "10";
                    textBoxYMax.Text = "100.0";
                }
            }
        }

        private void listBoxMethodJ_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            int index = e.Index;
            if (index >= 0 && index < listBoxMethodJ.Items.Count)
            {
                string text = listBoxMethodJ.Items[index].ToString();
                Graphics g = e.Graphics;

                //background:
                ;
                if (selected)
                {
                    SolidBrush backgroundBrush = new SolidBrush(GetColor(ToLatex(text)));
                    g.FillRectangle(backgroundBrush, e.Bounds);
                }

                //text:
                SolidBrush foregroundBrush = new SolidBrush(selected ? Color.White : Color.Black);
                g.DrawString(text, e.Font, foregroundBrush, listBoxMethodJ.GetItemRectangle(index).Location);
            }

            e.DrawFocusRectangle();
        }
    }
}
