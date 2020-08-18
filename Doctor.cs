using System;
using System.Collections.Generic;

namespace MyDentist
{
    public class Doctor : Staff
    {
        private string location;
        private string treatmentRoom;

        public Doctor(string FirstName, string SecondName, string ContactNum, string Address, string location, string treatmentRoom):base(FirstName,SecondName,ContactNum,Address)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ContactNum = ContactNum;
            this.Address = Address;
            this.Location = location;
            this.TreatmentRoom = treatmentRoom;
        }

        public string Location { get => location; set => location = value; }
        public string TreatmentRoom { get => treatmentRoom; set => treatmentRoom = value; }

        //list to store doctors information
        private static List<Doctor> DoctorData = new List<Doctor>();

        public static void InitiateDoctorData()
        {
            DoctorData.Add(new Doctor("Thomas", "Sanders", "0986646548", "Church Street", "Wellsprings", "Room 1"));
            DoctorData.Add(new Doctor("Elise", "yorvo", "098764546", "The Avenue", "Eastreach Doctors", "Room 3"));
            DoctorData.Add(new Doctor("Tristan", "Smith", "088765343", "Watery Lane", "Minehead Medical Centre", "Room A"));
            DoctorData.Add(new Doctor("Arnold", "Rimmer", "076426939", "Red Dwarf", "Bristol Medical Centre", "Room 5"));
        }

        //method for the user to add new doctor to the system
        public static void AddDoctor()
        {

            Console.WriteLine("Please enter doctor's first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter doctor's last name:");
            string SecondName = Console.ReadLine();
            Console.WriteLine("Please enter doctor's contact number:");
            string ContactNum = Console.ReadLine();
            Console.WriteLine("Please enter doctor's address:");
            string Address = Console.ReadLine();
            Console.WriteLine("Please enter the practise at which this doctor works:");
            string Location = Console.ReadLine();
            Console.WriteLine("Please enter this doctor's assigned treatment room:");
            string TreatmentRoom = Console.ReadLine();
            Console.WriteLine();
            DoctorData.Add(new Doctor(FirstName, SecondName, ContactNum, Address, Location, TreatmentRoom));
        }

        //method to view all doctors in the system
        public static void ViewDoctorRecords()
        {
            foreach (Doctor doctor in DoctorData)
            {
                Console.WriteLine("First Name: " + doctor.FirstName);
                Console.WriteLine("Second Name: " + doctor.SecondName);
                Console.WriteLine("Contact Number: " + doctor.ContactNum);
                Console.WriteLine("Address: " + doctor.Address);
                Console.WriteLine("Practise: " + doctor.Location);
                Console.WriteLine("Treatment Room: " + doctor.TreatmentRoom);
                Console.WriteLine();
            }
        }




    }
}
