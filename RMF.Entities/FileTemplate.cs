using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RMF.Entities
{
    public class FileTemplate
    {
        public int Id{ get; set; }
        public string FileName { get; set; }
        HttpPostedFileBase file { get; set; }
    }
}
