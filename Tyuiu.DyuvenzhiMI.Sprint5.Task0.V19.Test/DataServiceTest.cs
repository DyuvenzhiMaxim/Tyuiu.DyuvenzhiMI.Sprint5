
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
            string path = @"D:\programming\repos\Tyuiu.DyuvenzhiMI.Sprint5\Tyuiu.DyuvenzhiMI.Sprint5.Task0.V19\bin\Debug\net8.0\OutPutFileTask0.txt";
            //string path = $@"{Path.GetTempFileName()}\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
