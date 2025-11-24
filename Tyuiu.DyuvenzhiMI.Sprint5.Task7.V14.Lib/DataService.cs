
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {

            string path1 = Path.GetTempPath();
            string path2 = "OutPutDataFileTask7V14.txt";
            string str = Path.Combine(path1, path2);

            FileInfo fileInfo = new FileInfo(str);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(str);
            }


            string strLine = File.ReadAllText(path);
            strLine = strLine.ToUpper();

            File.AppendAllText(str, strLine + Environment.NewLine);

            return str;

        }
        
    }
}
