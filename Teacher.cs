
using System.Security.Cryptography.X509Certificates;

namespace UmlSkola
{
    public class Teacher : Person  
    {
        public String kursen;
       
       // Polymorfisum

        public override void visaName()
        {
            Console.WriteLine(" The teacher's name is  " + ferstName + EfterName);
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
