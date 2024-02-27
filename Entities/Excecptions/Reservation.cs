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
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room number: {RoomNumber}, Check-in: {CheckIn}, Check-out: {CheckOut}";
        }
    }
}