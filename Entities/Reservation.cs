using System;
using Curso7.Entities.Exceptions;


namespace Curso7.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if(Checkin <= Checkout)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        private int Duration()
        {
            
            TimeSpan duration = Checkin.Subtract(Checkout);
            return (int)Math.Ceiling(duration.TotalDays);
            
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
           DateTime now = DateTime.Now;
            if (checkIn < now || checkOut< now )
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            else if(checkIn >= checkOut )
            {
                throw new DomainException("Check out date must be after check in date");
            }
            Checkin = checkIn;
            Checkout = checkOut;
        }

        public override string ToString()
        {
            return $"Room: {RoomNumber}\n" +
                $"Check In:{Checkin.ToString("dd/MM/yyyy")}\n" +
                $"Check Out{Checkout.ToString("dd/MM/yyyy")}\n" +
                $"Duration: {Duration()} days ";
        }
    }
}
