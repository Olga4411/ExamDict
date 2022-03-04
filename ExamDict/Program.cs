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
            Dict r = new Dict("Test");
            r.AddWord("cat","кошка");
            r.AddWord("dog", "собака");
            Console.WriteLine(r);
            Console.ReadLine();
        }
        
    }
}
