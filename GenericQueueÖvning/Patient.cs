using System;
using System.Collections.Generic;
using System.Text;

namespace GenericQueueÖvning
{
    class Patient : Person
    {
        public string Sickness;
        public bool Vaccinated;
        public Patient(string name, int age, string gender, string sickness, bool vaccinated)
        {
            Role = "Läkare";
            Name = name;
            Age = age;
            Gender = gender;
            Sickness = sickness;
            Vaccinated = vaccinated;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.Write($"\n\tSjukdom: {Sickness}");
            Console.WriteLine();
        }
    }
}
