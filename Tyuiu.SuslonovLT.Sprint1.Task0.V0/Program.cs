using Tyuiu.SuslonovLT.Sprint1.Task0.V0.Lib;

class Program()
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Суслонов Л. Т. | ПКТб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #0                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Суслонов Леонид Тимофеевич | ПКТб-26-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение 3 / 3 * 2 +             *");
        Console.WriteLine("* + 12 / 4 / 3 - 2 и печатает результат на экране.                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* 3 / 3 * 2 + 12 / 4 / 3 - 2                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate());

        Console.ReadLine();
    }
}