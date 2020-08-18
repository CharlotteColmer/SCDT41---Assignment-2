using System;
using System.Collections.Generic;

namespace MyDentist
{
    public class Nurse : Staff
    {

        private string treatmentRoom;

        public Nurse(string FirstName, string SecondName, string ContactNum, string Address, string treatmentRoom) : base(FirstName, SecondName, ContactNum, Address)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ContactNum = ContactNum;
            this.Address = Address;
            this.TreatmentRoom = treatmentRoom;
        }

        public string TreatmentRoom { get => treatmentRoom; set => treatmentRoom = value; }

        //list to store nurse information
        private static List<Nurse> NurseData = new List<Nurse>();

        public static void InitiateNurseData()
        {
            NurseData.Add(new Nurse("Daniel", "Beetle", "099848577", "Blackmoor Road", "Room 1"));
            NurseData.Add(new Nurse("Sammy", "Teffers", "025364534", "Simic Avenue", "Room A"));
            NurseData.Add(new Nurse("Gerard", "Way", "027354783", "KillJoy Road", "Room 5"));
            NurseData.Add(new Nurse("Kryton", "Mecha", "035436284", "Red Dwarf", "Room 3"));
        }

        //method for the user to add new nurse to the system
        public static void AddNurse()
        {
            Console.WriteLine("Please enter nurse's first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter nurse's last name:");
            string SecondName = Console.ReadLine();
            Console.WriteLine("Please enter nurse's contact number:");
            string ContactNum = Console.ReadLine();
            Console.WriteLine("Please enter nurses's address:");
            string Address = Console.ReadLine();
            Console.WriteLine("Please enter the treatment room assigned to this nurse:");
            string TreatmentRoom = Console.ReadLine();
            Console.WriteLine();
            NurseData.Add(new Nurse(FirstName, SecondName, ContactNum, Address, TreatmentRoom));
        }

        //method to view all nurses in the system
        public static void ViewNurseRecords()
        {
            foreach (Nurse nurse in NurseData)
            {
                Console.WriteLine("First Name: " + nurse.FirstName);
                Console.WriteLine("Second Name: " + nurse.SecondName);
                Console.WriteLine("Contact Number: " + nurse.ContactNum);
                Console.WriteLine("Address: " + nurse.Address);
                Console.WriteLine("Assigned Treatment Room: " + nurse.TreatmentRoom);
                Console.WriteLine();
            }
        }

    }
}
