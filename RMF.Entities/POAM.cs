using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMF.Entities
{
    public class POAM
    {
        public int Id { get; set; }

        public DateTime LastUpdated { get; set; }
        public string AuthorizationStatus { get; set; } //ATO
                                                        // public virtual Systems System { get; set; }
                                                        //  public virtual ICollection <POAMItem>POAMItem { get; set; }
                                                        //Foreign key
        public int POAMItemId { get; set; }
        public virtual POAMItem POAMItem { get; set; }
      //  public int RMFSystemId { get; set; }

      //  public virtual RMFSystem RMFSystem { get; set; }

    }
}
