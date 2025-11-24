
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace('.', ','); 
            double x = Convert.ToDouble(strX);
            double y = Math.Sin(2 / (3 * x)) + Math.Pow(x, 2);
            y = Math.Round(y, 3);
            return y;
        }
    }
}
