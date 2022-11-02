using System;
using System.Collections.Generic;
using System.Text;

namespace GenericQueueÖvning
{
    class Person
    {
        public string Name;
        protected int Age;
        protected string Gender;
        protected string Role;

        public virtual void GetInfo()
        {
            Console.Write($"\n\tNamn: {Name}" +
                $"\n\tÅlder: {Age}" +
                $"\n\tKön: {Gender}" +
                $"\n\tRoll: {Role}");
        }
    }
}
