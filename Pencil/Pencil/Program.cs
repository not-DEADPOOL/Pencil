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
            Matita matita = new Matita(5);
            Console.WriteLine(matita);
            matita.Scrivi("11 11111111 11111111");
            Console.WriteLine(matita);
            MatitaGommino matita1 = new MatitaGommino("red", 5, 3);
            Console.WriteLine(matita1);
            matita1.Scrivi("1222 222   2");
            matita1.Scancellah(6);
            Console.WriteLine(matita1);
            Console.ReadKey();
        }
    }
}
