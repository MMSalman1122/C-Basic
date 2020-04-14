using System;
using classes.math;
namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.FirstName = "Salman";
            p1.LastName = "Ali";
            p1.intro();

            cal obj = new cal();
            obj.sum(3, 8);
            
            while(true)
            {

            }
        }
    }
}
