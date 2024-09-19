

namespace UmlSkola
{
    public class Betyg
    {
        public String betygVarde;
        public String Kommentar;

        public void geBetyg(string betygVarde)
        {
            Console.WriteLine("This student got.. " + betygVarde);
        }

        public void geKommentar(string Kommentar)
        {
            Console.WriteLine(" The  Teacher's comment om the student' performance: .... " + Kommentar);
        }

        
    }
}
