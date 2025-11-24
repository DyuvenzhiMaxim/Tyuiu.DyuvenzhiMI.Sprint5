
using Tyuiu.DyuvenzhiMI.Sprint5.Task7.V14.Lib;
using System.IO;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path1 = Path.GetTempPath();
            string path2 = "OutPutDataFileTask7V14.txt";
            string str = Path.Combine(path1, path2);

            FileInfo fileInfo = new FileInfo(str);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
