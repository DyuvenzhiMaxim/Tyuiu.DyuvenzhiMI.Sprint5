
using System.Data.SqlTypes;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task6.V21.Lib
{
    public class DataService : ISprint5Task6V21
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            int counTT = 0;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if ((str[i] == 'т' && (str[j] == 'т')) || (str[i] == 'Т' && (str[j] == 'т')))
                    {
                        counTT++;
                    }
                    break;
                }
            }
            return counTT;


            //string tt = "тт";
            /*string Tt = "Тт";
            int index = str.IndexOf(tt, 0);
            int index1 = str.IndexOf(Tt, 0);
            while (index != -1)
            {
                counTT++;
                index = str.IndexOf(tt, index + 1);
            }
            while (index1 != -1)
            {
                counTT++;
                index1 = str.IndexOf(Tt, index1 + 1);
            }*/

            /*string text = "Привет мир, привет всем!";
            string substring = "привет";
            string substring1 = "Привет";
            int count = 0;
            int index = text.IndexOf(substring, 0);
            int index1 = text.IndexOf(substring1, 0);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(substring, index + 1);
                
            }
            while (index1 != -1)
            {
                count++;
                index1 = text.IndexOf(substring1, index1 + 1);
            }*/

            /*int index = str.IndexOf("тт", 0);

            while (index != -1)
            {
                counTT++;
                index = str.IndexOf("тт", index + 1);
            }*/
        }
    }
}
