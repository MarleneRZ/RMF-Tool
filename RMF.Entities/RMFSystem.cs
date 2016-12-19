using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMF.Entities
{
   public class RMFSystem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string SystemName { get; set; }
        public Categorization? Confidentiality { get; set; }
        public Categorization? Integrity { get; set; }
        public Categorization? Availability { get; set; }
        public DateTime? AssessmentStartDate { get; set; }
        public DateTime? AssessmentEndDate { get; set; }
        public int AssessmentPriority { get; set; }
        //Foreign key
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int StateId { get; set; }
        public State? State { get; set; }

        public AssessmentStatus? AssessmentStatus { get; set; }

        public virtual ICollection<SystemControl> SystemControls { get; set; }
     }
}
