using System;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //a) Two problems with this design(Encapsulation issues):

            //Public fields(Owner, Balance)

            //Anyone can directly modify them.

            //Example: account.Balance = -100000; → Invalid state.

            //No validation in Withdraw

            //It allows withdrawing more than the balance.

            //It allows negative values.

            //b) How to fix it(Encapsulation improvement):

            //Make fields private.

            //Use public properties with validation.

            //Add validation inside Withdraw().

            //Example concept:

            //Owner → Property with validation(not null/empty).

            //Balance → Read-only property.

            //Withdraw() → Check:

            //amount > 0

            //amount ≤ Balance

            //c) Why exposing fields directly is bad practice?

            //Because:

            //It breaks encapsulation.

            //No validation control.

            //Internal data can be corrupted.

            //You cannot add logic later without breaking existing code.

            //Encapsulation protects object integrity.
            #endregion
            #region Q2
            //        Difference between Field and Property in C#
            //                    Field                                    Property
            //            Variable inside class               Controlled access to a field
            //                Usually private                         Usually public
            //             No validation logic                     Can contain validation

            //            Can a property contain logic?

            //                     Yes.



            //private double price;

            //    public double PriceAfterTax
            //    {
            //        get
            //        {
            //            return price * 1.14;
            //        }
            //    }

            //    It calculates the value instead of storing it.
            #endregion
            #region Q3
            //a) What is this[int index] called?

            //    It is called an Indexer.

            //    Purpose:

            //        Allows object to be accessed like an array:
            //register[0] = "Ali";
            //Instead of calling a method.
            // b)What happens with:
            //register[10] = "Ali";  IndexOutOfRangeException
            //    How to make it safer:

            //    Add validation:

            //    public string this[int index]
            //    {
            //    get
            //    {
            //        if (index >= 0 && index < names.Length)
            //            return names[index];
            //        return null;
            //    }
            //    set
            //    {
            //        if (index >= 0 && index < names.Length)
            //            names[index] = value;
            //    }
            //}
            //        c) Can a class have more than one indexer?

            //            Yes(by using different parameter types).


            //        public string this[string name]
            //         {
            //             get
            //             {
            //        foreach (var n in names)
            //        {
            //            if (n == name)
            //                return n;
            //        }
            //        return null;
            //    }
            //}
            //          Useful when accessing data by index or name.
            #endregion
            #region Q4
            //a) What does static mean?

            //TotalOrders belongs to the class itself, not to objects.

            //Shared between all objects.

            //Only one copy exists.

            //Item is:

            //Instance field.

            //Each object has its own copy.

            //b) Can static method access Item directly?

            //❌ No.

            //Because:

            //Item belongs to an object.

            //Static method belongs to the class.

            //Static methods cannot access instance members directly
            #endregion

            #region Part-02
            //Console.WriteLine("========== Ticket Booking ==========");

            //Cinema cinema = new Cinema();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"\nEnter data for Ticket {i + 1}:");

            //    Console.Write("Movie Name: ");
            //    string movieName = Console.ReadLine();

            //    Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
            //    TicketType type = (TicketType)int.Parse(Console.ReadLine());

            //    Console.Write("Seat Row (A-Z): ");
            //    char row = char.Parse(Console.ReadLine());

            //    Console.Write("Seat Number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    Console.Write("Price: ");
            //    double price = double.Parse(Console.ReadLine());

            //    SeatLocation seat = new SeatLocation { Row = row, Number = number };

            //    Ticket ticket = new Ticket(movieName, type, seat, price);

            //    cinema.AddTicket(ticket);
            //}

            //Console.WriteLine("\n========== All Tickets ==========");

            //for (int i = 0; i < 3; i++)
            //{
            //    var t = cinema[i];
            //    if (t != null)
            //    {
            //        Console.WriteLine(
            //            $"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | Seat: {t.Seat} | Price: {t.Price} EGP | After Tax: {t.PriceAfterTax} EGP");
            //    }
            //}

            //Console.WriteLine("\n========== Search by Movie ==========");
            //Console.Write("Enter movie name to search: ");
            //string search = Console.ReadLine();

            //var found = cinema.GetMovie(search);

            //if (found != null)
            //{
            //    Console.WriteLine(
            //        $"Found: Ticket #{found.TicketId} | {found.MovieName} | {found.Type} | Seat: {found.Seat} | Price: {found.Price} EGP");
            //}
            //else
            //{
            //    Console.WriteLine("Movie not found.");
            //}

            //Console.WriteLine("\n========== Statistics ==========");
            //Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");

            //Console.WriteLine($"\nBooking Reference 1: {BookingHelper.GenerateBookingReference()}");
            //Console.WriteLine($"Booking Reference 2: {BookingHelper.GenerateBookingReference()}");

            //double discount = BookingHelper.CalcGroupDiscount(5, 80);
            //Console.WriteLine($"\nGroup Discount (5 tickets x 80 EGP): {discount} EGP");
            #endregion
        }
    }
}
