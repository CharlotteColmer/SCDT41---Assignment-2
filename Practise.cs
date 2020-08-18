using System;
using System.Collections.Generic;

namespace MyDentist
{
    public class Practise
    {
        private string name;
        private string location;
        private string address;
        private string contactNumber;
        //TreatmentRooms room1 = new TreatmentRooms("room1");

        public Practise(string name, string location, string address, string contactNumber)
        {
            this.Name = name;
            this.Location = location;
            this.Address = address;
            this.ContactNumber = contactNumber;
            //this.Room1 = room1;
        }

        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public string Address { get => address; set => address = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        //public TreatmentRooms Room1 { get => room1; set => room1 = value; }

        //create list to store practise information
        private static List<Practise> PractiseData = new List<Practise>();

        //method to add some dummy data on start up for testing and demo purposes
        public static void InitiatePractiseData()
        {
            PractiseData.Add(new Practise("Minehead Medical Centre", "Minehead","Townsend Road","01643680876"));
            PractiseData.Add(new Practise("Eastreach Doctors", "Taunton", "East Reach", "016478653849"));
            PractiseData.Add(new Practise("Bristol Medical Centre", "Bristol", "Bridgwater Road", "01647678987"));
            PractiseData.Add(new Practise("Wellsprings", "Taunton", "Flower Lane", "01643876579"));
        }

        //method for user to add new practise information
        public static void AddNewPractise()
        {
            Console.WriteLine("Please enter name of new practise:");
            string Name = Console.ReadLine();
            Console.WriteLine("Please enter practise location:");
            string Location = Console.ReadLine();
            Console.WriteLine("Please enter practise contact number:");
            string ContactNumber = Console.ReadLine();
            Console.WriteLine("Please enter practise address:");
            string Address = Console.ReadLine();
            Console.WriteLine();
            PractiseData.Add(new Practise(Name, Location, Address, ContactNumber));
        }

        //method for user to view all practises
        public static void ViewAllPractises()
        {
            foreach (Practise practise in PractiseData)
            {
                Console.WriteLine("Practise Name: " + practise.Name);
                Console.WriteLine("Location of Practise: " + practise.Location);
                Console.WriteLine("Contact Number: " + practise.ContactNumber);
                Console.WriteLine("Address: " + practise.Address);
                Console.WriteLine();
            }
        }





    }
}
