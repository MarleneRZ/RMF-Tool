using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMF.Entities
{
   public class Control
    {
        public int Id { get; set; }
        public string ControlCode { get; set; }
        public string ControlName { get; set; }
        public string ControlPriority { get; set; }

        public Boolean? ControlBaselineLow { get; set; }

        public Boolean? ControlBaselineModerate { get; set; }

        public Boolean? ControlBaselineHigh { get; set; }
        //Foreign key
        public int FamilyControlId { get; set; }

        public string ControlDescription { get; set; }
         public virtual FamilyControl FamilyControl { get; set; }
        public virtual ICollection<ControlItem> ControlItems { get; set; }
        public virtual ICollection<SystemControl> SystemControls { get; set; }

    }
}
