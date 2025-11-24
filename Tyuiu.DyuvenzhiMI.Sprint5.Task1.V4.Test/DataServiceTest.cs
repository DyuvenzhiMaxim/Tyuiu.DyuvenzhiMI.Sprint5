
using Tyuiu.DyuvenzhiMI.Sprint5.Task1.V4.Lib;
using System.IO;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string path = @"D:\programming\repos\Tyuiu.DyuvenzhiMI.Sprint5\Tyuiu.DyuvenzhiMI.Sprint5.Task1.V4\bin\Debug\net8.0\OutPutFileTask1.txt";
            string path1 = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string path = Path.Combine(path1, fileName);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
