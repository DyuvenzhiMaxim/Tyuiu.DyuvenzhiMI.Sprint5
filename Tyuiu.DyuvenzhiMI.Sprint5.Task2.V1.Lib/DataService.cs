
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.DyuvenzhiMI.Sprint5.Task2.V1.Lib
{
    public class DataService : ISprint5Task2V1
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            //string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";
            string path1 = Path.GetTempPath();
            string path2 = "OutPutFileTask2.csv";
            string path = Path.Combine(path1, path2);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i,j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += matrix[i, j] + ';';
                    }
                    else
                    {
                        str += matrix[i, j];
                    }
                }
                
                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }

            return path;

        }
    }
}
