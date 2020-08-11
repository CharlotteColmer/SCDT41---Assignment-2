using System;
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
    }
}
