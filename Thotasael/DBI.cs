using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thotasael
{
    //Database Info
    public class DBI
    {
        public const string RecordSubPath = "Record";
        public string Name { get; set; }
        public string MainDirectory { get; set; }
        public Dictionary<string, ArModel> Models { get; set; }
        public Dictionary<string, ArInstanceList> ILs { get; set; }
    }
}
