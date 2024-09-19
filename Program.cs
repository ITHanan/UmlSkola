using System.Xml.Linq;

namespace UmlSkola
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Skola myskola = new Skola() ;
            myskola.Names("NBI/Handelsakademin");


            Console.WriteLine("----------skola--------------");

            Skola schoolregis = new Skola();
            schoolregis.RegistrersStudent(".net");

            Console.WriteLine("----------kurser--------------");


            Kurser kurs1 = new Kurser() ;
            kurs1.visaKurser();



            Console.WriteLine("----------Teacher--------------");


            Teacher teacher = new Teacher() ;
            teacher.visaName();
            teacher.undervisas(".Net");
            teacher.delaLäx();
            teacher.geBetyg();
            teacher.geBetyg();

            Console.WriteLine("----------elevers--------------");


            Eleve eleve = new Eleve() ; 
            eleve.visaName();
            eleve.registeration();
            eleve.skikaläxa();
            eleve.göraProv();
            eleve.visaBetyg();

            Console.WriteLine("----------betyg--------------");


            Betyg betyg = new Betyg() ;
            betyg.geBetyg("VG");
            betyg.geKommentar(" The student completed the necessary tasks with efficiency.");






        }
    }
}
