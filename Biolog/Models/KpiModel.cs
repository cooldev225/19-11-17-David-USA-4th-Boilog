using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biolog.Models
{

    public class Dashboard
    {
        public int KpiCount { get; set; }
        public int PowerBiCount { get; set; }
        public int ReportCount { get; set; }
        public List<KpiModel> KpiModel { get; set; }
        public List<PowerBiModel> PowerBiModelList { get; set; }
        public List<ReportModel> ReportModelList { get; set; }
    }

    public class KpiModel
    {      
        public string Name { get; set; }
        public string Goal { get; set; }
        public string Percent { get; set; }
        public string Status { get; set; }
        public string Value { get; set; }
    }

    public class PowerBiModel
    {
        public string Name { get; set; }
    }
    public class ReportModel
    {
        public string Name { get; set; }
    }
}