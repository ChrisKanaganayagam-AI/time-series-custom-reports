﻿using ReportPluginFramework;

namespace Reports
{
    public class RainfallSummary : RainfallSummaryNamespace.ReportPluginBase, IFileReport
    {
        public override void AddReportSpecificTables(System.Data.DataSet dataSet)
        {
            RainfallSummaryNamespace.ReportSpecificTableBuilder.AddReportSpecificTables(dataSet);
        }
    }
}
