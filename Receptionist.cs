using System;
using System.Collections.Generic;

namespace MyDentist
{
    public class Receptionist : Staff
    {
        public Receptionist(string FirstName, string SecondName, string ContactNum, string Address) : base(FirstName, SecondName, ContactNum, Address)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ContactNum = ContactNum;
            this.Address = Address;
        }

        //list to store receptionist information
        private static List<Receptionist> ReceptionistData = new List<Receptionist>();

        public static void InitiateReceptionistData()
        {
            ReceptionistData.Add(new Receptionist("Isabelle", "Tzu", "05364893", "Horizon Lane"));
            ReceptionistData.Add(new Receptionist("Timmy", "Nook", "067850434", "Cranny Road"));
            ReceptionistData.Add(new Receptionist("KK", "Slider", "036473834", "New Leaf Lane"));
            ReceptionistData.Add(new Receptionist("Lottie", "Otter", "024747386", "Happy Home Avenue"));
        }

        //method for the user to add new receptionist to the system
        public static void AddReceptionist()
        {
            Console.WriteLine("Please enter receptionist's first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter receptionist's last name:");
            string SecondName = Console.ReadLine();
            Console.WriteLine("Please enter receptionist's contact number:");
            string ContactNum = Console.ReadLine();
            Console.WriteLine("Please enter receptionist's address:");
            string Address = Console.ReadLine();
            Console.WriteLine();
            ReceptionistData.Add(new Receptionist(FirstName, SecondName, ContactNum, Address));
        }

        //method to view all receptionists in the system
        public static void ViewReceptionistRecords()
        {
            foreach (Receptionist receptionist in ReceptionistData)
            {
                Console.WriteLine("First Name: " + receptionist.FirstName);
                Console.WriteLine("Second Name: " + receptionist.SecondName);
                Console.WriteLine("Contact Number: " + receptionist.ContactNum);
                Console.WriteLine("Address: " + receptionist.Address);
                Console.WriteLine();
            }
        }


    }
}
