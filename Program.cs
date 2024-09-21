using System.Xml.Linq;

namespace UmlSkola
{
    internal class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("----------skola--------------");
            Skola myskola = new Skola() ;
            myskola.Names("");

            Skola schoolregis = new Skola();
            schoolregis.RegistrersStudent("");

            Console.WriteLine("----------kurser--------------");


            Kurser kurs1 = new Kurser() ;
            kurs1.visaKurser();



            Console.WriteLine("----------Teacher--------------");


            Teacher teacher = new Teacher() ;
            teacher.visaFirstName("");
            teacher.visaEfterName("");
            teacher.undervisas("");
            teacher.delaLäx();
            teacher.geBetyg();
            teacher.geBetyg();

            Console.WriteLine("----------elevers--------------");


            Eleve eleve = new Eleve() ;
            eleve.visaFirstName("");
            teacher.visaEfterName("");

            eleve.registeration();
            eleve.skikaläxa();
            eleve.göraProv();
            eleve.visaBetyg();

            Console.WriteLine("----------betyg--------------");


            Betyg betyg = new Betyg() ;
            betyg.geBetyg("");
            betyg.geKommentar(" ");






        }
    }
}
