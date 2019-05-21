using Exercicio_Reservation_Exceptions.Entities;
using Exercicio_Reservation_Exceptions.Entities.Exceptions;
using System;


namespace Exercicio_Reservation_Exceptions
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation r = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine("Reservation: " + r);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");

                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                r.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + r);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
           
        }
    }

}
