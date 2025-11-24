
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task3.V2.Lib
{
    public class DataService : ISprint5Task3V2
    {
        public string SaveToFileTextData(int x)
        {
            //string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
            string path1 = Path.GetTempPath();
            string path2 = "OutPutFileTask3.bin";
            string path = Path.Combine(path1, path2);
            FileInfo fileInfo = new FileInfo(path);

            double y = (Math.Pow(Math.E, x)) / x;
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}
