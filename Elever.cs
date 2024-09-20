

using System.Runtime.InteropServices;

namespace UmlSkola
{
    public class Eleve : Person  //Polymorfisum
    
    {
        private int personNumber;
        public int kurser;
        public int Betyg;



        public override void visaFirstName(string ferstName)
        {
            Console.WriteLine(" The student's nmae is  " + ferstName );

        }
        
        

        public  void visaBetyg()
        {
            Console.WriteLine(" The student got..  ");
        }

        public void registeration() 
        { 
          Console.WriteLine(" The student can register ..");  
        }

        public void skikaläxa() 
        
        {  
          Console.WriteLine(" Student can send  homework");
        }

        public void göraProv()

        {
            Console.WriteLine(" Student and prov ...");
        }


    }
}
