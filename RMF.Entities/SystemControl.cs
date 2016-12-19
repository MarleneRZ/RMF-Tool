using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMF.Entities
{
   public  class SystemControl
    {
        public int id { get; set; }

       public int RMFSystemId { get; set; }

        public int ControlId { get; set; }

        public string FindingResultDescription { get; set; }
        public string FindingRecommendation { get; set; }
        public ApprovalResult? FindingStatus { get; set; }

        public virtual RMFSystem RMFSystem { get; set; }
        public virtual Control Control { get; set; }
    }
}
