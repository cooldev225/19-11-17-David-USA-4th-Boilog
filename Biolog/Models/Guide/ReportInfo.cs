using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biolog.Models.Guide
{
    public class ReportInfo
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public string InfoName { get; set; }
        public string Description { get; set; }
        public string Uses { get; set; }
        public int InfoType { get; set; }
        public string Etcx { get; set; }
        public int Sortx { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
