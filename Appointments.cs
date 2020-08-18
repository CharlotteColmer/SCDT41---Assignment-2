using System;
using System.Collections.Generic;

namespace MyDentist
{
    public class Appointments
    {
        //attributes needed by this class
        private string patient;
        private DateTime dateTime;
        private string treatment;
        private string dentist;

        //constructors for the class
        public Appointments(string patient, DateTime dateTime, string treatment, string dentist)
        {
            this.Patient = patient;
            this.DateTime = dateTime;
            this.Treatment = treatment;
            this.Dentist = dentist;
        }

        //get/sets for encapsulation and security
        public string Patient { get => patient; set => patient = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public string Treatment { get => treatment; set => treatment = value; }
        public string Dentist { get => dentist; set => dentist = value; }

        //list to store the appointment records in
        private static List<Appointments> AppointmentRecords = new List<Appointments>();

        //method to establish this class with some dummy data for demonstration and testing purposes
        public static void InitiateAppointmentData()
        {
            AppointmentRecords.Add(new Appointments("Brendon", new DateTime(01/03/2020),"Band 1","Thomas"));
            AppointmentRecords.Add(new Appointments("Aiden", new DateTime(03/04/2019),"Band 2", "Arnold"));
            AppointmentRecords.Add(new Appointments("Jimmy", new DateTime(04/11/2019), "Band 3", "Tristan"));
            AppointmentRecords.Add(new Appointments("Tyler", new DateTime(06/01/2020), "Band 2", "Elise"));
        }


        //method for user to create a new appointment
        public static void CreateNewAppointment()
        {
            Console.WriteLine("Please enter the paitent arranging the appointment:");
            string Patient = Console.ReadLine();
            Console.WriteLine("Please enter the date of the appointment:");
            DateTime DateTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Please enter treatment band of this appointment");
            string Treatment = Console.ReadLine();
            Console.WriteLine("Please enter doctor taking the appointment:");
            string Dentist = Console.ReadLine();
            Console.WriteLine();
            AppointmentRecords.Add(new Appointments(Patient, DateTime, Treatment, Dentist));
        }

        //method for user to view all appointments
        public static void ViewAllAppointments()
        {
            foreach (Appointments appointment in AppointmentRecords)
            {
                Console.WriteLine("Patient: " + appointment.patient);
                Console.WriteLine("Date of Appointment: " + appointment.DateTime);
                Console.WriteLine("Band of Treatment: " + appointment.Treatment);
                Console.WriteLine("Dentist: " + appointment.Dentist);
                Console.WriteLine();
            }

        }
        

    }
}
