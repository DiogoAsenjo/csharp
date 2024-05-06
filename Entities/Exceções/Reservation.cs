using System;

namespace PrimeiroProjeto
{
    class Reservation
    {
        int RoomNumber { get; set; }
        DateTime CheckIn { get; set; }
        DateTime CheckOut { get; set; }

        public Reservation(int room, DateTime checkIn, DateTime checkOut)
        {
            this.checkDates(checkIn, checkOut);
            RoomNumber = room;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            return CheckOut.Subtract(CheckIn).Days;
        }

        public void updateReservation(DateTime checkIn, DateTime checkOut)
        {
            this.checkDates(checkIn, checkOut);
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public void checkDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime today = DateTime.Now;
            if (checkIn < today || checkOut < today) 
            {
                throw new DomainException("You can't make a reservation in the past!");
            }

            if (checkOut <= checkIn)
            {
                throw new DomainException("Your checkout should be after your checkin!");
            }
        }

        public override string ToString()
        {
            return $"Room number: {RoomNumber}, Check-in: {CheckIn.ToString("dd/MM/yyyy")}, Check-out: {CheckOut.ToString("dd/MM/yyyy")}";
        }
    }
}