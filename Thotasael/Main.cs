using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Thotasael
{
    public static class Main
    {
        public static DBI DBI { get; set; }

        public static void NewDatabase(string name, string path)
        {   
            DirectoryInfo di = new DirectoryInfo(path);
            //寫入驗證 - 或許可研究
            if (!di.HavePermissionToWrite())
                throw new Exception("Directory can't write or not exists.");

            DBI.MainDirectory = path;
            DBI.Name = name;
            //確認Record存在
            if (!Path.Exists(Path.Combine(DBI.MainDirectory, DBI.RecordSubPath)))
                Directory.CreateDirectory(Path.Combine(DBI.MainDirectory, DBI.RecordSubPath));

            

        }
    }
}
