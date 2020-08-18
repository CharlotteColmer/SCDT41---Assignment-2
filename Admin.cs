using System;
namespace MyDentist
{
    public class Admin : Staff
    {
        public Admin(string FirstName, string SecondName, string ContactNum, string Address) : base(FirstName, SecondName, ContactNum, Address)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ContactNum = ContactNum;
            this.Address = Address;
        }

    }
}
