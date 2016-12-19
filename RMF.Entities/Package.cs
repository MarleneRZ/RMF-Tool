using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMF.Entities
{
  public  class Package
    {
        public int Id { get; set; }

        public int? ArtifactId { get; set; }
        public virtual Artifact Artifact { get; set; }
        public int? RMFSystemId { get; set; }

        public virtual RMFSystem RMFSystem { get; set; }
        public Boolean submitted { get; set; }
    }
}
