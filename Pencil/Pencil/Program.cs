using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_pencil;

namespace Pencil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matita matita = new Matita(3,"blue");
            Console.WriteLine(matita);
            Console.WriteLine(matita.Scrivi("12245673567234522222222"));
            Console.WriteLine(matita);
            Console.ReadKey();
        }
    }
}
