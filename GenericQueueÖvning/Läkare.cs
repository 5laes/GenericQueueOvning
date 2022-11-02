using System;
using System.Collections.Generic;
using System.Text;

namespace GenericQueueÖvning
{
    class Läkare : Person 
    {
        int Salary;
        public Läkare(string name, int age, string gender, int salary)
        {
            Role = "Läkare";
            Name = name;
            Age = age;
            Gender = gender;
            Salary = salary;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.Write($"\n\tLön: {Salary}");
            Console.WriteLine();
        }

        public void VaccinatePatient(Patient patient)
        {
            patient.Vaccinated = true;
            Console.Write($"\n\t{patient.Name} är nu vaccinerad");
            Console.WriteLine();
        }
    }
}
