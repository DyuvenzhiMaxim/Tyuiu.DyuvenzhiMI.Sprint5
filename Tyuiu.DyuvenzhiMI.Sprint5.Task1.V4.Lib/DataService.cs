
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using Microsoft.Win32;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path1 = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string path = Path.Combine(path1, fileName);
            //string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string stry;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (Math.Cos(x) / (x + 1)) - Math.Cos(x)*(1.3) + 3*x;
                    y = Math.Round(y, 2);
                }
                stry = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }

            return path;
        }
    }
}
