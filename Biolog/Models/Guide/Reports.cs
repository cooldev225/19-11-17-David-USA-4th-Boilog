using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biolog.Models.Guide
{
    public class Reports
    {
        public int Id { get; set; }
        public string ReportName { get; set; }
        public string FolderName { get; set; }
        public string Purpose { get; set; }
        public string Audience { get; set; }
        public string Frequency { get; set; }
        public string ScreenUrl { get; set; }
        public byte[] ScreenImg { get; set; }
        public string Etcx { get; set; }
        public int Sortx { get; set; }
        public int Kindx { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
