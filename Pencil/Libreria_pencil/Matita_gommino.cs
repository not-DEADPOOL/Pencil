using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Libreria_pencil
{
    public class MatitaGommino : Matita
    {
        public righe fine_gomma;
        public int lungh_gomma;
        public MatitaGommino(string color, int lungh, int lungh_gomma)
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

                fine.one = @"__ _ ___";
                fine.two = @"   | |   ";
                fine.three = @"--|||---|";
                fine.four = @"__|_|___";

                fine_gomma.one = @"   ____";
                fine_gomma.two = @"  /   ";
                fine_gomma.three = @"  /---|";
                fine_gomma.four = @"  /____";
            }

            this.lungh_gomma = lungh_gomma;
            Start(1);
            Console.CursorVisible = true;
        }
        
        public MatitaGommino(string color) : this(color, 10, 5) { }
        public MatitaGommino() : this("black", 10, 5) { }
        public MatitaGommino(int l, int lg) : this("black", l, lg) { }
        public override string ToString()
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color == "black" ? "blue" : color, true);
            return fine_gomma.one + StampaCorpo(1, lungh_gomma) + fine.one + StampaCorpo(1, lungh) + punta.one + "\n"
                + fine_gomma.two + StampaCorpo(2, lungh_gomma) + fine.two + StampaCorpo(2, lungh) + punta.two + "\n"
                + fine_gomma.three + StampaCorpo(3, lungh_gomma) + fine.three + StampaCorpo(3, lungh) + punta.three + "\n"
                + fine_gomma.four + StampaCorpo(4, lungh_gomma) + fine.four + StampaCorpo(4, lungh) + punta.four + "\n";
        }
        public string Scancellah(int k)
        {
            Console.WriteLine("\tScancellandoh... ");
            int counter = 0;
            if (cronologia.Length >= k)
            {
                lungh_gomma = lungh_gomma - (k / 5);
                if (lungh_gomma > 0)
                {
                    for (int i = cronologia.Length - 1; i >= k; i--)
                    {
                        counter += cronologia[i] == ' ' ? 1 : 0;
                    }
                    cronologia = cronologia.Remove(cronologia.Length - 1 - k - counter);
                }
            }
            Scrivi(cronologia);
            return cronologia;
        }
    }
}
