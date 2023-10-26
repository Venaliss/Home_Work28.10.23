using System;
using System.IO;
using System.Linq;
using System.Text;

public class Tasks
{
    /*Упражнение 8.2 Тумаков (Реализовать метод, который в качестве входного параметра принимает строку string, 
     * возвращает строку типа string, буквы в которой идут в обратном порядке.)*/
    public static void Reverse_Task2(string s)
    {
        char[] ch = s.ToCharArray();
        for (int i = ch.Length - 1; i >= 0; i--)
        {
            Console.Write(ch[i]);
        }
    }



    public static void Main(string[] args)
    {
        /*Упражнение 8.2 Тумаков - Реализовать метод который в качестве входного параметра принимает string, возвращает string(строку) в обр.порядке*/
        Console.WriteLine("Реализовать метод который в качестве входного параметра принимает string, возвращает string(строку) в обр.порядке");
        Tasks.Reverse_Task2(Console.ReadLine());



        /*Упражнение 8.3 Тумаков - Написать программу, которая спрашивает у пользователя имя файла. 
         * Если такого файла не существует, то программа выдает пользователю сообщение и заканчивает работу, 
         * иначе в выходной файл записывается содержимое исходного файла, но заглавными буквами.*/
        Console.WriteLine("Написать программу, которая спрашивает имя файла.Если его нет, то заканчивает работу, иначе написать имя файла заглавными буквами.");
        const string outputFileName = "ResultText.out";
        string inputFileName = string.Empty;

        Console.Write("Введите название входного файла: ");
        inputFileName = Console.ReadLine();

        if (File.Exists(inputFileName))
        {
            File.WriteAllText(outputFileName, File.ReadAllText(inputFileName, Encoding.UTF8).ToUpper(), Encoding.UTF8);
            Console.WriteLine("Результат успешно записан в файл с именем \"{0}\"", outputFileName);
        }
        else
        {
            Console.WriteLine("Файл с именем \"{0}\" не найден!", inputFileName);
        }




        Console.ReadKey();
    }
}