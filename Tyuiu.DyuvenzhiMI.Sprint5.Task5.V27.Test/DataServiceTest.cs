
using Tyuiu.DyuvenzhiMI.Sprint5.Task5.V27.Lib;
using System.IO;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V27.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists); 
        }
    }
}
