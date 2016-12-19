using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMF.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Boolean Contractor { get; set; }
        
        public UserRole? UserType { get; set; }

        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }

    }
}
