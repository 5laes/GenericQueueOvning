using System;
using System.Collections.Generic;
using System.Text;

namespace GenericQueueÖvning
{
    class Sjuksköterska : Person
    {
        private int WorkTime;
        public Sjuksköterska(string name, int age, string gender, int worktime)
        {
            Role = "Sjuksköterska";
            Name = name;
            Age = age;
            Gender = gender;
            WorkTime = worktime;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.Write($"\n\tJobbtimmar: {WorkTime}");
            Console.WriteLine();
        }

        public bool CheckPatientVaccination(Patient patient)
        {
            if (patient.Vaccinated == true)
            {
                Console.Write($"\n\t{patient.Name} är vaccinerad");
            }
            else
            {
                Console.Write($"\n\t{patient.Name} är inte vaccinerad");
            }
            Console.WriteLine();
            return patient.Vaccinated;
        }
    }
}
