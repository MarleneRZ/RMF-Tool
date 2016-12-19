using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMF.Entities
{
    public class ControlItem
    {
        public int Id { get; set; }
        public string ControlItemCode { get; set; }
        public int ControlId { get; set; }
        public virtual Control Control { get; set; }

        public string Description { get; set; }
        public string AssessmentObjective { get; set; }
    }
}
