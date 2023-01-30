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
        public string color;
        public string cronologia;
        public righe punta;
        public righe fine;
        public List<righe> corpo;
        //Loading loadong = new Loading();

        public Matita(int lungh, string color)
        {
            Console.ResetColor();
            Console.CursorVisible = false;
            //punta = @"_____" + "\n" + @"    /`-." + "\n" + @"---<    ##" + "\n"+ @"____\,-'" + "\n";
            //fine = @"  ____" + "\n" + @" /\   " + "\n" + @"<()>--" + "\n" + @" \/___" + "\n";
            this.color = color;
            this.lungh = lungh;
            cronologia = "";
            {
                punta.one = @"_____";
                punta.two = @"    /`-.";
                punta.three = @"--<    ##";
                punta.four = @"____\,-'";
                fine.one = @"    ____";
                fine.two = @"   /\   ";
                fine.three = @"  <()>--|";
                fine.four = @"   \/___";
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
            Start(0);
            Console.CursorVisible = true;
        }
        public void Start(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(@"
                  _   _ _             _____    
                 | | (_| |           / ___ `.                _____ __             __ 
  _ __ ___   __ _| |_ _| |_ __ _    |_/___) |               / ___// /_____  _____/ /_
 | '_ ` _ \ / _` | __| | __/ _` |    .'____.'     ______    \__ \/ __/ __ `/ ___/ __/
 | | | | | | (_| | |_| | || (_| | _ / /_____     /_____/   ___/ / /_/ /_/ / /  / /_ 
 |_| |_| |_|\__,_|\__|_|\__\__,_|(_)|_______|             /____/\__/\__,_/_/   \__/  
                                                                                                                                        
");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if(n==0)
            {
                Console.WriteLine(@"
                  _   _ _         
                 | | (_| |                      _____ __             __ 
  _ __ ___   __ _| |_ _| |_ __ _               / ___// /_____  _____/ /_
 | '_ ` _ \ / _` | __| | __/ _` |    ______    \__ \/ __/ __ `/ ___/ __/
 | | | | | | (_| | |_| | || (_| |   /_____/   ___/ / /_/ /_/ / /  / /_ 
 |_| |_| |_|\__,_|\__|_|\__\__,_|            /____/\__/\__,_/_/   \__/  
                                                                                                                                        
");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        public Matita() : this(10, "black") { }
        public Matita(int l) : this(l, "black") { }
        public string Scrivi(string s1)
        {
            Console.CursorVisible = false;
            Console.Write("\tWriting... ");
            string s = scrivi(s1);
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = true;
            return s;
        }
        public string scrivi(string s)
        {
            string scrivo = "";
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (lungh <= 0)
                    break;
                if (counter == 10)
                {
                    counter = 0;
                    lungh--;
                    if (lungh <= 0)
                        break;
                }
                if (s[i] != ' ' || s[i] != '\n')
                    counter++;

                scrivo += s[i];
            }
            cronologia += scrivo;
            //  Console.WriteLine("c:"+cronologia);
            return scrivo;
        }
        internal string StampaCorpo(int n, int l)
        {
            string riga = "";
            switch (n)
            {
                case 1:
                    for (int i = 0; i < l; i++)
                        riga += corpo[i].one;
                    return riga;
                case 2:
                    for (int i = 0; i < l; i++)
                        riga += corpo[i].two;
                    return riga;
                case 3:
                    for (int i = 0; i < l; i++)
                        riga += corpo[i].three;
                    return riga;
                case 4:
                    for (int i = 0; i < l; i++)
                        riga += corpo[i].four;
                    return riga;
                default:
                    break;
            }
            return "";
        }

        public override string ToString()
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color == "black" ? "blue" : color, true);
            return fine.one + StampaCorpo(1, lungh) + punta.one + "\n"
                + fine.two + StampaCorpo(2, lungh) + punta.two + "\n"
                + fine.three + StampaCorpo(3, lungh) + punta.three + "\n"
                + fine.four + StampaCorpo(4, lungh) + punta.four + "\n";
        }
    }

}
