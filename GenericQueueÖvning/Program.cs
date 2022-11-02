using System;
using System.Collections.Generic;

namespace GenericQueueÖvning
{
    class Program
    {
        static void Main(string[] args)
        {
            Läkare läkare1 = new Läkare("Bengt", 56, "Man", 56000);
            Läkare läkare2 = new Läkare("Robert", 65, "Man", 65000);
            Läkare läkare3 = new Läkare("Märta", 42, "Kvinna", 53000);
            Sjuksköterska sjuksköterska1 = new Sjuksköterska("Sara", 24, "Kvinna", 45);
            Sjuksköterska sjuksköterska2 = new Sjuksköterska("Linnea", 28, "Kvinna", 40);
            Sjuksköterska sjuksköterska3 = new Sjuksköterska("Emma", 20, "Kvinna", 50);
            Sjuksköterska sjuksköterska4 = new Sjuksköterska("Alex", 25, "Man?", 35);
            Sjuksköterska sjuksköterska5 = new Sjuksköterska("Rogge", 70, "Gammal", 100);
            Sjuksköterska sjuksköterska6 = new Sjuksköterska("Lisa", 26, "Kvinna", 1);
            Patient patient1 = new Patient("Kalle", 17, "Man", "Aids", false);
            Patient patient2 = new Patient("Bert", 69, "Man", "Bryten Rygg", true);
            Patient patient3 = new Patient("Felicia", 8, "Flicka", "Cancer", false);
            Patient patient4 = new Patient("Jerry", 30, "Man", "Tappat håret", false);
            Patient patient5 = new Patient("Tom", 23, "Man", "Mutation", true);
            Patient patient6 = new Patient("Love", 19, "Kvinna", "Hallshuggen", true);
            Patient patient7 = new Patient("Jesus", 1985, "Man", "Uppstod inte", false);
            Patient patient8 = new Patient("Leonard", 28, "Man", "Förkyld", true);
            Patient patient9 = new Patient("Hannah", 22, "Kvinna", "Skeva tänder", false);

            List<Person> personsList = new List<Person>();
            personsList.Add(läkare1);
            personsList.Add(läkare2);
            personsList.Add(läkare3);
            personsList.Add(sjuksköterska1);
            personsList.Add(sjuksköterska2);
            personsList.Add(sjuksköterska3);
            personsList.Add(sjuksköterska4);
            personsList.Add(sjuksköterska5);
            personsList.Add(sjuksköterska6);
            personsList.Add(patient1);
            personsList.Add(patient2);
            personsList.Add(patient3);
            personsList.Add(patient4);
            personsList.Add(patient5);
            personsList.Add(patient6);
            personsList.Add(patient7);
            personsList.Add(patient8);
            personsList.Add(patient9);

            foreach (Person person in personsList)
            {
                person.GetInfo();
            }
            Console.WriteLine("\n\t----------------------------------------------------------------------------" +
                "\n\tSjuksköterska kollar om patienterna är vaccinerade");

            List<Patient> patientList = new List<Patient>();
            patientList.Add(patient1);
            patientList.Add(patient2);
            patientList.Add(patient3);
            patientList.Add(patient4);
            patientList.Add(patient5);
            patientList.Add(patient6);
            patientList.Add(patient7);
            patientList.Add(patient8);
            patientList.Add(patient9);

            Queue<Patient> patientVaccinationQueue = new Queue<Patient>();

            foreach (Patient patient in patientList)
            {
                if (sjuksköterska1.CheckPatientVaccination(patient) == false)
                {
                    patientVaccinationQueue.Enqueue(patient);
                }
            }

            Console.WriteLine("\n\t----------------------------------------------------------------------------" +
                "\n\tLäkare börjar vaccinera folk");

            while (patientVaccinationQueue.Count > 0)
            {
                läkare1.VaccinatePatient(patientVaccinationQueue.Dequeue());
                if (patientVaccinationQueue.Count == 0)
                {
                    Console.Write("\n\tAlla ovaccinerade person är nu vaccinerade");
                }
            }
            Console.ReadLine();
        }
    }
}
