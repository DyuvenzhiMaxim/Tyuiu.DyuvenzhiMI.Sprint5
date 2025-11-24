
using Tyuiu.DyuvenzhiMI.Sprint5.Task3.V2.Lib;
using System.IO;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string path = @"D:\programming\repos\Tyuiu.DyuvenzhiMI.Sprint5\Tyuiu.DyuvenzhiMI.Sprint5.Task3.V2\bin\Debug\net8.0\OutPutFileTask3.bin";
            string path1 = Path.GetTempPath();
            string path2 = "OutPutFileTask3.bin";
            string path = Path.Combine(path1, path2);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
