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
            Console.WriteLine(m.fine.one + m.corpo.one + m.punta.one);
            Console.WriteLine(m.fine.two + m.corpo.two + m.punta.two);
            Console.WriteLine(m.fine.three + m.corpo.three + m.punta.three);
            Console.WriteLine(m.fine.four + m.corpo.four + m.punta.four);
            Console.ReadKey();
        }
    }
}
