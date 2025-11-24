
using Tyuiu.DyuvenzhiMI.Sprint5.Task0.V19.Lib;
using System.IO;
namespace Tyuiu.DyuvenzhiMI.Sprint5.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path1 = Path.GetTempPath();
            string fileName = "OutPutFileTask0.txt";
            string path = Path.Combine(path1, fileName);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
