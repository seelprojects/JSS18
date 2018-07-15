﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BugLocalizationHybridApproach
{
    [Serializable]
    public class ProcessorListResult
    {
        public ProcessorListResult()
        {
            Results = new List<ProcessorResultKeyValue>();
        }

        [XmlArray]
        public List<ProcessorResultKeyValue> Results { get; set; }
    }

    public class ProcessorResultKeyValue
    {
        public double Key { get; set; }

        public DatasetMetricResult Result { get; set; }
    }

    public class DatasetMetricResult
    {
        public int Top01 { get; set; }

        public double Top01Percent { get; set; }

        public int Top05 { get; set; }

        public double Top05Percent { get; set; }

        public int Top10 { get; set; }

        public double Top10Percent { get; set; }

        public int RelevantTop10 { get; set; }

        public double SumRr { get; set; }

        public double Mrr { get; set; }

        public double SumAp { get; set; }

        public double Map { get; set; }

        public int Bugs { get; set; }

        public void AddMetricResult(MetricResult metricResult)
        {
            Bugs++;

            Top01 += metricResult.Top01;
            Top05 += metricResult.Top05;
            Top10 += metricResult.Top10;
            RelevantTop10 += metricResult.RelevantTop10;
            SumRr += metricResult.Rr;
            SumAp += metricResult.Ap;
        }

        public void GeneratePercents()
        {
            Top01Percent = Top01 * 100.0 / Bugs;
            Top05Percent = Top05 * 100.0 / Bugs;
            Top10Percent = Top10 * 100.0 / Bugs;
            Mrr = SumRr / Bugs;
            Map = SumAp / Bugs;
        }
    }

    public class MetricResult
    {
        public int Top01 { get; set; }

        public int Top05 { get; set; }

        public int Top10 { get; set; }

        public int RelevantTop10 { get; set; }

        public double Rr { get; set; }

        public double Ap { get; set; }
    }

    public class AxisSetting
    {
        public double XMin { get; set; }

        public double XInterval { get; set; }

        public double XMax { get; set; }

        public double YMin { get; set; }

        public double YInterval { get; set; }

        public double YMax { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public bool ShowLegend { get; set; }
    }
}
