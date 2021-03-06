﻿using ReportPluginFramework;

namespace Reports
{
    public class TimeSeriesPlot : TimeSeriesPlotNamespace.ReportPluginBase, IFileReport
    {
        public override void AddReportSpecificTables(System.Data.DataSet dataSet)
        {
            TimeSeriesPlotNamespace.ReportSpecificTableBuilder.AddReportSpecificTables(dataSet);
        }
    }
}
