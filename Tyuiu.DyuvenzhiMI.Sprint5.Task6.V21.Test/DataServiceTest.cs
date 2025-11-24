
using Tyuiu.DyuvenzhiMI.Sprint5.Task6.V21.Lib;
using System.IO;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
