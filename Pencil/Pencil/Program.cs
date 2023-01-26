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
            matita.Stampa();
            matita.Scrivi("1                22");
            matita.Stampa();
            Console.ReadKey();
        }
    }
}
