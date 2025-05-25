using Thotasael;

namespace ThotasaelTest
{
    [TestClass]
    public sealed class MainTest
    {
        public const string TestAreaPath = @"C:\Programs\Thotasael\Thotasael\TestArea";

        [TestMethod]
        public void NewDatabase()
        {
            Main.NewDatabase("TestDB", Path.Combine(TestAreaPath, "O1"));
        }
    }
}
