using System;
using System.Collections.Generic;

namespace MyDentist
{
    public class Patient
    {
        private string firstName;
        private string secondName;
        private string mobNum;
        private string address;

        public Patient(string firstName, string secondName, string mobNum, string address)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.MobNum = mobNum;
            this.Address = address;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string MobNum { get => mobNum; set => mobNum = value; }
        public string Address { get => address; set => address = value; }

        //create a list to store the patient information in 
        private static List<Patient> PatientData = new List<Patient>();

        //method to add some dummy data for testing and demonstration purposes
        public static void InitiatePatientData()
        {
            PatientData.Add(new Patient("Jimmy", "Jimbob", "0164398569", "Someplace Avenue"));
            PatientData.Add(new Patient("Brendon", "Urie", "0164302346", "Moholland Drive"));
            PatientData.Add(new Patient("Aiden", "Pearce", "0164387876", "The Loop"));
            PatientData.Add(new Patient("Tyler", "Joseph", "0164376876", "Clancy Road"));

        }

        //method for the user to add new patient to the system
        public static void AddPatient()
        {
            
            Console.WriteLine("Please enter patient first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter patient last name:");
            string SecondName = Console.ReadLine();
            Console.WriteLine("Please enter patient contact number:");
            string MobNum = Console.ReadLine();
            Console.WriteLine("Please enter patient address:");
            string Address = Console.ReadLine();
            Console.WriteLine();
            PatientData.Add(new Patient(FirstName, SecondName, MobNum, Address));

        }

        //method for user to view all patient records
        public static void ViewPatientRecords()
        {
            foreach (Patient patient in PatientData)
            {
                Console.WriteLine("First Name: " + patient.FirstName);
                Console.WriteLine("Second Name: " + patient.SecondName);
                Console.WriteLine("Mobile Number: " + patient.MobNum);
                Console.WriteLine("Address: " + patient.Address);
                Console.WriteLine();
            }
        }
    }
}
