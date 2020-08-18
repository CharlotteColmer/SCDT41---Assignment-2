using System;

namespace MyDentist
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           //calls the appropriate methods to ensure there is dummy data in the system
            Patient.InitiatePatientData();
            Practise.InitiatePractiseData();
            Doctor.InitiateDoctorData();
            Nurse.InitiateNurseData();
            Receptionist.InitiateReceptionistData();
            Appointments.InitiateAppointmentData();


            //Main menu for users to choice which function to perform
            Console.WriteLine("Please Choose from the following options:");
            Console.WriteLine("1) Manage Appointments 2) Manage Staff 3) Manage Patients 4) Manage Practices");
            //variable storing menu option choice
            var MenuChoice = Console.ReadLine();

            //if statement that leads to sub-menus depending on the user's choice
            //first option: appointment related functions
            if (MenuChoice == "1")
            {
                Console.WriteLine("What would you like to do? 1) Create New Appointment 2) View Appointments");

                //variable storing sub-menu option choice
                var AppointmentChoice = Console.ReadLine();

                //calls appropriate method depending on user's choice
                if(AppointmentChoice == "1")
                {
                    Appointments.CreateNewAppointment();
                }
                if(AppointmentChoice == "2")
                {
                    Appointments.ViewAllAppointments();
                }
            }
            //second option: staff related functions
            if (MenuChoice == "2")
            {
                Console.WriteLine("What would you like to do? 1) Add New Staff 2) View All Staff");

                //variable storing sub-menu option choice
                var StaffChoice = Console.ReadLine();

                //calls appropriate method depending on user's choice
                if (StaffChoice == "1")
                {
                    Staff.AddNewStaff();
                }
                if (StaffChoice == "2")
                {
                    Staff.ViewStaffRecords();
                }
            }
            //third option: patient related functions
            if (MenuChoice == "3")
            {
                Console.WriteLine("What would you like to do? 1) Add New Patient 2) View All Patients");

                //variable storing sub-menu option choice
                var PatientChoice = Console.ReadLine();

                //calls appropriate method depending on user's choice
                if (PatientChoice == "1")
                {
                    Patient.AddPatient();
                }
                if (PatientChoice == "2")
                {
                    Patient.ViewPatientRecords();
                }
            }
            //fourth option: practice related functions
            if (MenuChoice == "4")
            {
                Console.WriteLine("What would you like to do? 1) Add New Practise 2) View All Practises");

                //variable storing sub-menu option choice
                var PractiseChoice = Console.ReadLine();

                //calls appropriate method depending on user's choice
                if (PractiseChoice == "1")
                {
                    Practise.AddNewPractise();
                }
                if (PractiseChoice == "2")
                {
                    Practise.ViewAllPractises();
                }
            }



        }
    }
}
