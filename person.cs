
namespace UmlSkola
{
    public class Person
    {
        public String ferstName;
        public String EfterName;
         
        //Polymorfisum 
        public virtual void visaName() 
        {
            Console.WriteLine(" The nmae is  "+ ferstName + EfterName);
        }
        
    }
}
