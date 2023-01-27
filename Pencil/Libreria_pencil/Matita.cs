using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using loading;

namespace Libreria_pencil
{
    public struct righe
    {
        public string one;
        public string two;
        public string three;
        public string four;
    }
    public class Matita
    {
        public int lungh;
        int counter;
        public string cronologia;
        public righe punta;
        public righe fine;
        public List<righe> corpo;

        public Matita(int lungh, string color)
        {
            //punta = @"_____" + "\n" + @"    /`-." + "\n" + @"---<    ##" + "\n"+ @"____\,-'" + "\n";
            //fine = @"  ____" + "\n" + @" /\   " + "\n" + @"<()>--" + "\n" + @" \/___" + "\n";
            this.lungh = lungh;
            cronologia = "";
            {
                punta.one = @"_____";
                punta.two = @"    /`-.";
                punta.three = @"---<   ##";
                punta.four = @"____\,-'";
                fine.one = @"  ____";
                fine.two = @" /\   ";
                fine.three = @"<()>--|";
                fine.four = @" \/___";
            }
            corpo = new List<righe>();
            for (int i = 0; i < this.lungh; i++)
            {
                righe c;
                //c = @"|______|" + "\n" + @"|      |" + "\n" + @"|------|" + "\n" + @"|______|" + "\n";
                c.one = @"________";
                c.two = @"        ";
                c.three = @"-------|";
                c.four = @"________";
                corpo.Add(c);
            }
            Console.WriteLine(@"
                  _   _ _         
                 | | (_| |                      _____ __             __ 
  _ __ ___   __ _| |__ | |_ __ _               / ___// /_____ ______/ /_
 | '_ ` _ \ / _` | __| | __/ _` |    ______    \__ \/ __/ __ `/ ___/ __/
 | | | | | | (_| | |_| | || (_| |   /_____/   ___/ / /_/ /_/ / /  / /_ 
 |_| |_| |_|\__,_|\__|_|\__\__,_|            /____/\__/\__,_/_/   \__/  
                                                                                                                                        
");
            Thread.Sleep(2500);
            Console.Clear();
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color=="black"?"blue":color, true);
        }
        public Matita() : this(10, "black") { }

        public string Scrivi(string s)
        {
            Console.BackgroundColor = ConsoleColor.White;
            string scrivo = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (lungh <= 0)
                {

                    break;
                }
                if (counter == 10)
                {
                    counter = 0;
                    lungh--;
                }
                if (s[i] != ' ')
                    counter++;

                scrivo += s[i];
            }
            cronologia += scrivo;
            Console.ResetColor();
            return scrivo;
        }
        string StampaCorpo(int n)
        {
            string riga = "";
            switch (n)
            {
                case 1:
                    for (int i = 0; i < lungh; i++)
                        riga += corpo[i].one;
                    return riga;
                case 2:
                    for (int i = 0; i < lungh; i++)
                        riga += corpo[i].two;
                    return riga;
                case 3:
                    for (int i = 0; i < lungh; i++)
                        riga += corpo[i].three;
                    return riga;
                case 4:
                    for (int i = 0; i < lungh; i++)
                        riga += corpo[i].four;
                    return riga;
                default:
                    break;
            }
            return "";
        }

        public override string ToString()
        {
            return fine.one + StampaCorpo(1) + punta.one + "\n" 
                + fine.two + StampaCorpo(2) + punta.two + "\n" 
                + fine.three + StampaCorpo(3) + punta.three + "\n" 
                + fine.four + StampaCorpo(4) + punta.four + "\n";
        }
    }
    
}
