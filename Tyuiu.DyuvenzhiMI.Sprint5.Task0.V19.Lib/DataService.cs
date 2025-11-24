
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task0.V19.Lib
{
    public class DataService : ISprint5Task0V19
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            //string path = $@"{Path.GetTempFileName()}\OutPutFileTask0.txt";
            

            double y = ((2 * Math.Pow(x, 2) - 1) / (Math.Sqrt(Math.Pow(x, 2) - 2)));
            y = Math.Round(y, 3); 
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
