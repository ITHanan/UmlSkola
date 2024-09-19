

using System.Threading.Channels;

namespace UmlSkola
{
    public class Skola 
    {
        //Attributer
       public string name;
       public string adress;
       public string kurser;
       public string techer;
       public string elever; 
        //Metoder
      public void Names(string name)
      {
            Console.WriteLine("The school name is " + name);
      }
     
      public void RegistrersStudent(string kurser) 
      {
        Console.WriteLine("Student can register in "); 
      }

    }

   



}
