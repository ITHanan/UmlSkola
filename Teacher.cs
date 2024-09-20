
using System.Security.Cryptography.X509Certificates;

namespace UmlSkola
{
    public class Teacher : Person  
    {
        public String kursen;

        // Polymorfisum

        public override void visaFirstName(string ferstName)
        {

            Console.WriteLine(" The teacher's name is  " + ferstName);

        }


        public override void visaEfterName(string EfterName)
        {
            Console.WriteLine(" The teacher's name is  "  + EfterName);

        }
        

        public void undervisas(string kursen)
        {
            Console.WriteLine("The teacher is teaching " + kursen);
        }

        public void delaLäx()
        {
          Console.WriteLine(" Your homeworks are here ");
        }

        public  void geBetyg()
        {
            Console.WriteLine("  ");

        }




    }

}
