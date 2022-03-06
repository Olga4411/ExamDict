using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace ExamDict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dict book = new Dict("Словарь");
            book.English_Russian.Add("cat", "кошка");
            book.English_Russian.Add("dog", "собака");
            book.English_Russian.Add("country", "страна");
            book.English_Russian.Add("Ukraine", "Украина");
            book.English_Russian.Add("France", "Франция");
            book.English_Russian.Add("USA", "США");
            book.English_Russian.Add("China", "Китай");
            book.English_Russian.Add("Japan", "Япония");

            Console.WriteLine(book);
            Console.ReadLine();

            book.RemoveWordWithAtribute("cat");
            Console.WriteLine(book);
            Console.ReadLine();

        }

    }
}
