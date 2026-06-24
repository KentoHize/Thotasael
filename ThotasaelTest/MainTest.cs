using System.Dynamic;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Thotasael;

namespace ThotasaelTest
{
    [TestClass]
    public sealed class MainTest
    {
        public const string TestAreaPath = @"C:\Programs\Thotasael\Thotasael\TestArea";

        [TestMethod]
        public void AESTest()
        {
            Aes ae = Aes.Create();
            ae.GenerateIV();
            for(int i = 0; i < ae.IV.Length; i++)
            {
                Console.Write(ae.IV[i] + " ");
            }
            //Console.WriteLine(Encoding.UTF8.GetString(ae.IV));
            Console.WriteLine();
            string a = "ABC";
            byte[] b = ae.EncryptCbc(Encoding.UTF8.GetBytes(a), ae.IV);            
            Console.WriteLine(Encoding.UTF8.GetString(b));
            byte[] c = ae.DecryptCbc(b, ae.IV);
            Console.WriteLine(Encoding.UTF8.GetString(c));
            
        }


        //表
        //ABC
        //欄位 A Int 16
        //欄位 B String *

        public class Table
        {
            public string TableName { get; set; }
            public Column[] Columns { get; set; }
        }

        public class Column
        {
            public string Name { get; set; }
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
            public int Length { get; set; }
            public string Type { get; set; }
        }
        
        [TestMethod]
        public void JsonTest()
        {
            string s = "[{\"TableName\":\"ABC\", \"Columns\":[" +
                "{\"Name\":\"A\", \"Length\":16, \"Type\":\"Int\"}," +
                "{\"Name\":\"B\", \"Length\":0, \"Type\":\"String\"}" +
                "]}]";

            Console.WriteLine(s);
            Table[] d = JsonSerializer.Deserialize<Table[]>(s);
            Console.WriteLine(d[0].TableName);
            Console.WriteLine(d[0].Columns[0].Name);
            Console.WriteLine(d[0].Columns[1].Type);

            string s2 = JsonSerializer.Serialize(d);
            Console.WriteLine(s2);
        }

        [TestMethod]
        public void NewDatabase()
        {
            Main.NewDatabase("TestDB", Path.Combine(TestAreaPath, "O1"));
        }
    }
}
