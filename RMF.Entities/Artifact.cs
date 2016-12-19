using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMF.Entities
{
    public class Artifact
    {
        public int Id { get; set; }
        public int? RMFSystemId { get; set; }
        public string ArtifactName { get; set; }
        public string Description { get; set; }
        //Foreing key
        public int FileTemplateId { get; set; }
        public virtual FileTemplate FileTemplate { get; set; }
        public virtual RMFSystem RMFSystem { get; set; }
    }
}
