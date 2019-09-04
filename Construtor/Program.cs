using System;
using System.Globalization;

namespace Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();

            p1.Nome = "notebook";
            Console.WriteLine(p1.Nome);
        }  
    }
}
