
namespace UmlSkola
{
    public class Person
    {
        public String ferstName;
        public String EfterName;
         
        //Polymorfisum 
        public virtual void visaFirstName(string ferstName) 
        {
            Console.WriteLine(" The nmae is  "+ ferstName);
        }

        public virtual void visaEfterName(string EfterName)
        {
            Console.WriteLine(" The nmae is  " + EfterName);
        }

    }
}
