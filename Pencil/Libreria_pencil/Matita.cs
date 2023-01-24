using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Libreria_pencil
{
    public struct righe
    {
        public string one;
        public string two;
        public string three;
        public string four;
    }
    public enum Colors
    {
        nero, blu, rosso, verde, viola, rosa
    }
    public class Matita
    {
        public int lungh;
        public Colors colori;
        int counter;
        string cronologia;
        public righe punta;
        public righe fine;
        public List<righe> corpo;

        public Matita()
        {
            lungh = 10;
            cronologia = "";
            colori = 0;
            punta.one = @"_____";
            punta.two = @"    /`-.";
            punta.three = @"--<     ##";
            punta.four = @"____\,-'";
            fine.one = @"  ____";
            fine.two = @" /\   ";
            fine.three = @"<()>--";
            fine.four = @" \/___";
            corpo = new List<righe>();
            for (int i = 0; i < lungh; i++)
            {
                righe c;
                c.one = @"|______|";
                c.two = @"|      |";
                c.three = @"|------|";
                c.four = @"|______|";
                corpo.Add(c);
            }
            Console.WriteLine(@"
                  _   _ _         
                 | | (_| |                      _____ __             __ 
  _ __ ___   __ _| |_ _| |_ __ _               / ___// /_____ ______/ /_
 | '_ ` _ \ / _` | __| | __/ _` |    ______    \__ \/ __/ __ `/ ___/ __/
 | | | | | | (_| | |_| | || (_| |   /_____/   ___/ / /_/ /_/ / /  / /_ 
 |_| |_| |_|\__,_|\__|_|\__\__,_|            /____/\__/\__,_/_/   \__/  
                                                                                                                                        
");
            Thread.Sleep(2500);
            Console.Clear();
        }

        //public string Scrivi(string s)
        //{

        //}
    }
    public class MatitaGommino : Matita
    {

    }
}
