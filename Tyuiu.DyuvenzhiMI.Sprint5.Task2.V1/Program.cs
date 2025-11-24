
using Tyuiu.DyuvenzhiMI.Sprint5.Task2.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Дювенжи М. И. | ПИНТб-25-1";
        //Длина строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Дювенжи Максим Иванович | ПИНТб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] mrtx1 = new int[3, 3] { { 0, 1, 0 }, { 10, 10, 1 }, { 0, 1, 1 } };
        int[,] mrtx = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Введите {i},{j} число: ");
                mrtx[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int rows = mrtx.GetUpperBound(0) + 1;
        int colms = mrtx.Length / rows; //или int colms = mrtx.GetUpperBound(1) +1;

        DataService ds = new DataService();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colms; j++)
            {
                Console.Write($"{mrtx[i, j]} \t");
            }
            Console.WriteLine(); 
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(mrtx);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан!");
        Console.ReadLine();
        
    }
}