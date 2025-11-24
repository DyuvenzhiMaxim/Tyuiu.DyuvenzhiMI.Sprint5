
using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            string str = File.ReadAllText(path);
            str = str.Replace('.', ',');
            string[] stringNumbers = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            int sum = 0;
            //int count1 = 0;
            //int sum1 = 0;

            foreach (string s in stringNumbers)
            {
                if (int.TryParse(s, out int number))
                {
                    if ((Math.Abs(number) % 5 == 0))
                    {
                        count++;
                        sum += number;
                    }
                }
            }
            res = (sum / count)+0.5; 

            /*using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    res = res + Convert.ToDouble(line);
                }
            }*/

            return res;
        }
    }
}
