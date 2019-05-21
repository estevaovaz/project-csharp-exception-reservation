using System;
using Exercicio_Reservation_Exceptions.Entities.Exceptions;


namespace Exercicio_Reservation_Exceptions.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public Reservation()
        {

        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            else if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            
            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Room: "
                + RoomNumber
                + ", "
                + " Check-in:  "
                + Checkin.ToString("dd/MM/yyyy")
                + ", "
                + "Check-out: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights ";
        }
    }
}
