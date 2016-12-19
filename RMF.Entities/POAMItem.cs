using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMF.Entities
{
   public class POAMItem
    {
        public int id { get; set; }

       
        public int RMFSystemId { get; set; }

     
        public int ControlId { get; set; }

        public virtual RMFSystem RMFSystem { get; set; }
        public virtual Control Control { get; set; }

       public string WeaknessType { get; set; }
        public DateTime TargetDate { get; set; }
        Categorization? RiskLevel { get; set; }
        // public virtual ICollection<SystemControl> SystemControl { get; set; }
        //Foreign key
     
       
        public string Responsible { get; set; }
        public decimal FundingResource { get; set; }
        public DateTime SchedCompletionDate { get; set; }
        public string Milestone { get; set; }
        public string SourceOfWeakness { get; set; }
        ArtifactStatus? POAMStatus { get; set; }
        public string Comments { get; set; }

    }
}
