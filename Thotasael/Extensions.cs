using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thotasael
{
    public static class Extensions
    {
        public static bool HavePermissionToWrite(this DirectoryInfo di)
        {
            if (!di.Exists)
                return false;
            try
            {
                FileStream fs = File.Create(Path.Combine(di.FullName, "test.txt"));
                byte[] data = Encoding.Unicode.GetBytes("Test");
                fs.Write(data, 0, data.Length);
                fs.Close();
                File.Delete(Path.Combine(di.FullName, "test.txt"));
            }
            catch (Exception ex)
            {
                return false;
                //To Do
                //throw new Exception($"Failed to wirte at {di.FullName}.", ex);
            }

            return true;
        }
    }
}
