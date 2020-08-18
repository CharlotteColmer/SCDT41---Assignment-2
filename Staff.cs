using System;
namespace MyDentist
{
    public class Staff
    {
        private string firstName;
        private string secondName;
        private string contactNum;
        private string address;

        public Staff(string firstName, string secondName, string contactNum, string address)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ContactNum = contactNum;
            this.Address = address;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string ContactNum { get => contactNum; set => contactNum = value; }
        public string Address { get => address; set => address = value; }

        //method to provide user with menu of which staff type to add
        public static void AddNewStaff()
        {
            Console.WriteLine("Which staff type would you like to add?");
            Console.WriteLine("1) Doctor, 2) Nurse, 3) Receptionist");

            //stores user input in a variable as their choice
            var choice = Console.ReadLine();

            //runs appropriate function to add new staff to the system
            if (choice == "1")
            {
                Doctor.AddDoctor();
            }
            else if (choice == "2")
            {
                Nurse.AddNurse();
            }
            else if (choice == "3")
            {
                Receptionist.AddReceptionist();
            }

        }

        public static void ViewStaffRecords()
        {
            Console.WriteLine("Which staff records would you like to view?");
            Console.WriteLine("1) Doctor, 2) Nurse, 3) Receptionist");

            //stores user input in a variable as their choice
            var choice = Console.ReadLine();

            //runs appropriate function to view staff records based on the user's choice
            if (choice == "1")
            {
                Doctor.ViewDoctorRecords();
            }
            else if (choice == "2")
            {
                Nurse.ViewNurseRecords();
            }
            else if (choice == "3")
            {
                Receptionist.ViewReceptionistRecords();
            }
        }
    }
}
