using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMF.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public string OrgName { get; set; }
        public string OrgSymbol { get; set; }

        // public virtual ICollection<Users> Users { get; set; }
        //Foreign key
       // [Key]
       // [ForeignKey("User")]
        //public int UserId { get; set; } 
        //public virtual User User { get; set; }
    }
}
