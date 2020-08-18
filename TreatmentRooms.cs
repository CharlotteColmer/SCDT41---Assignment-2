using System;
namespace MyDentist
{
    public class TreatmentRooms
    {
        private string roomNumber;

        public TreatmentRooms(string roomNumber)
        {
            this.RoomNumber = roomNumber;
        }

        public string RoomNumber { get => roomNumber; set => roomNumber = value; } 
    }
}
