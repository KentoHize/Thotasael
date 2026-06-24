using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thotasael
{
    public class ArModel
    {
        public ArModel InheritFrom { get; set; }
        public bool IsAbstract { get; set; }

        //public bool Inherit { get; set; }
        public Dictionary<string, ArProperty> Properties { get; set; }
    }
}
