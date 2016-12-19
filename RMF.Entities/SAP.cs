using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMF.Entities
{
    public class SAP
    {
        public int Id { get; set; }
        public ArtifactStatus? SAPStatus { get; set; }
        ApprovalResult? Approved { get; set; }
        // System.Web.HttpPostedFileBase file { get; set; }
        //Foreign key
        public int FileTemplateId { get; set; }
        public virtual FileTemplate FileTemplate { get; set; }
        //Foreing key
        public int RMFSystemsId { get; set; }
        public virtual RMFSystem RMFSystem { get; set; }
    }
}
