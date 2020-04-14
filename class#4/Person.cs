using System;

namespace classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void intro()
        {
            Console.WriteLine("First name " + FirstName + " " + "Last Name " + LastName);
        }
    }
}
