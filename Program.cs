using System;
using Curso7.Entities;
using Curso7.Entities.Exceptions;

namespace Curso7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Chek in date: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check out Date: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine(reservation);

                Console.WriteLine("Enter data to update Reservation: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check out Date: ");
                checkOut = DateTime.Parse(Console.ReadLine());
                reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);



            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: "+ e.Message);
            }
        }
    }
}
