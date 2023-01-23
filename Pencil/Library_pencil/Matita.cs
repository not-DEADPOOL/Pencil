namespace Library_pencil
{
    public enum Colors
    {
        nero,blu,rosso,verde,viola,rosa
    }
    public class Matita
    {
        public int lungh;
        public Colors colori;
        public int Durabilita { get; private set; }
        string punta;
        string fine;
        string corpo;

        public Matita()
        {
            punta = @"
                    _____
                        /`-.
                    --<     ##
                    ____\,-'
            ";
            fine = @"
                      ____
                     /\   
                    <()>--
                     \/___
            ";
            corpo = @"
                    |________|
                    |        |
                    |--------|
                    |________|
            ";
        }

        //public string Scrivi(string s)
        //{

        //}
    }
    public class MatitaGommino : Matita
    {

    }
}