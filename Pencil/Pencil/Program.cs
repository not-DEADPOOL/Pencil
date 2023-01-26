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
            Matita m = new Matita();
            m.Stampa();
            Console.ReadKey();
        }
    }
}
