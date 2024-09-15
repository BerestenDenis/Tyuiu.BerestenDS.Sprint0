using Tyuiu.BerestenDS.Sprint0.Task7.V0.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #0 | Выполнил: Берестень Д. С. | ИБКСБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #0                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #0                                                              *");
        Console.WriteLine("* Выполнил: Берестень Денис Сергеевич | ИБКСБ-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
        Console.WriteLine("* одиныковых массивов по длинне.                                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");








        int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5, };

        Console.WriteLine("Значение элементов массива №1");
        for (int i = 0; i < arrayNums1.Length; i++)
        {
            Console.Write(arrayNums1[i] + ", ");

        }

        Console.WriteLine();

        int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5, };

        Console.WriteLine("Значение элементов массива №2");
        for (int i = 0; i < arrayNums2.Length; i++)
        {
            Console.Write(arrayNums2[i] + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (arrayNums1.Length == arrayNums2.Length)
        {
            int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

            Console.WriteLine("Сумма элементов массива ровна:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine(resultArray[i] + ", ");
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Исходные элементы массива имеют разное количество элементов");
        }
        Console.ReadKey();
    }
}   