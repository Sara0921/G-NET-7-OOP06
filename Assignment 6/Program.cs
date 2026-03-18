using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_6
{
    #region Part01
    #region Question01
    //Abstraction vs Encapsulation
    //Abstraction is about hiding complexity — you show only what's necessary and hide the implementation details. It answers: "What does it do?"
    //Encapsulation is about bundling and protecting data — you wrap data and methods together and restrict direct access.It answers: "How is it protected?"
    //Example: A Coffee Machine
    //Abstraction:
    //Encapsulation:
    //The water tank level, internal temperature, and bean count are stored privately inside the machine.You can't directly change them — you interact only through buttons, and the machine controls its own state.
    #endregion
    #region Question02
    //4 Key Differences
    //                    Abstract Class                          | Interface
    //Methods     | Can have both complete and incomplete methods | All methods are incomplete(no body)
    //Variables   | Can have instance variables                   |Only constants(final static)
    //Inheritance |A class can extend only one                    |A class can implement multiple
    //Constructor |✅ Can have a constructor                      |❌ Cannot
    #endregion
    #region Question03
    //A) No. Appliance is an abstract class — you cannot instantiate it directly.
    //B)PowerConsumption()>>abstract>>Every appliance consumes different power — there's no sensible default. Each subclass must provide its own value.
    //Status()>>virtual>>Most appliances start on "Standby" — a reasonable default. But subclasses can override it if needed.
    //Label()>>concrete>>The format "Brand - XW" is the same for all appliances.t reuses the other methods internally.
    //C) what will it return? >> Standby
    //Because Toaster does not override Status(), so it falls back to the parent's virtual implementation which returns "Standby".
    #endregion
    #region Question04
    //A)Partial Class >> A partial class splits one class across multiple files using the partial keyword — at compile time, they're merged into one single class.
    // Organize large classes , Team collaboration , Enable code generation , Protect manual code
    //B) partial method is declared in one part of a partial class and optionally implemented in another part.
    //Yes, it still compiles.
    //Because If a partial method has no implementation, the compiler silently removes all calls to it as if they never existed. No error, no crash.
    //C)Extension Methods >> An extension method lets you add new methods to an existing type without modifying its source code, without inheritance, and without recompiling.
    //Three rules:
    //1.Must be in a static class
    //2.The method itself must be static
    //3.First parameter must use this followed by the type being extended
    //D)$20.00 


    #endregion
    #endregion
    #region Part02
    ////Interfaces
    //interface IPrintable
    //{
    //    void PrintTicket();

    //}
    //interface IBookable
    //{
    //    bool IsBooked { get; }
    //    void Book();
    //    void Cancel();


    //}
    //enum TicketType
    //{
    //    Standard,
    //    VIP,
    //    IMAX
    //}
    //struct Seat
    //{
    //    public char Row;
    //    public int Number;
    //    public Seat(char row, int number)
    //    {
    //        Row = row;
    //        Number = number;
    //    }
    //    public override string ToString() => $"{Row}{Number}";
    //}
    //public abstract class Ticket : IPrintable, IBookable, ICloneable
    //{
    //    public static int counter = 0;
    //    public string MovieName { get; set; }
    //    public int Ticketid { get; set; }
    //    private decimal _price;
    //    public decimal Price
    //    {
    //        get
    //        {
    //            return _price;
    //        }
    //        set
    //        {
    //            if (value > 0)
    //                _price = value;
    //        }
    //    }
    //    public decimal PriceAfterTax => _price + (_price * 14m / 100);

    //    // Abstract — no default, every subclass MUST provide its own implementation
    //    public abstract decimal GetFinalPrice();
    //    // Concrete
    //    public bool IsBooked { get; protected set; }

    //    public void Book()
    //    {
    //        if (IsBooked)
    //            Console.WriteLine($"Ticker #{Ticketid} is already booked.");
    //        else
    //            IsBooked = true;
    //    }

    //    public void Cancel()
    //    {
    //        if (!IsBooked)
    //            Console.WriteLine($"Ticker #{Ticketid} is not  booked , Can't cancel");
    //        else
    //            IsBooked = false;
    //    }

    //    public Ticket(string moviename, decimal price)
    //    {
    //        MovieName = moviename;
    //        Price = price;
    //        counter++;
    //        Ticketid = counter;
    //    }
    //    //IPrintable
    //    public virtual void PrintTicket()
    //    {
    //        Console.WriteLine($"[Ticket #{Ticketid}] {MovieName} | Price: {Price} | Final: {GetFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
    //    }

    //    // ICloneable 
    //    public virtual object Clone()
    //    {
    //        counter++;
    //        Ticket copy = (Ticket)this.MemberwiseClone();
    //        copy.Ticketid = counter;
    //        copy.IsBooked = false;
    //        return copy;
    //    }
    //    public static int GetTotalTickets() => counter;

    //}
    //class StandardTicket : Ticket
    //{
    //    public string SeatNumber { get; set; }
    //    public StandardTicket(string moviename, decimal price, string seatnumber) : base(moviename, price)
    //    {
    //        SeatNumber = seatnumber;
    //    }

    //    public override void PrintTicket()
    //    {
    //        Console.WriteLine($"[Ticket #{Ticketid}] {MovieName} | Standard | Seat: {SeatNumber} | Price: {Price} | Final: {GetFinalPrice():F2}  | Booked: {(IsBooked ? "Yes" : "No")}");

    //    }
    //    public override decimal GetFinalPrice() => Price + (Price * 14m / 100);
    //}
    //class VIPTicket : Ticket
    //{
    //    public bool LoungeAccess { get; set; }
    //    public decimal ServiceFee { get; } = 50;
    //    public VIPTicket(string moviename, decimal price, bool loungeAccess) : base(moviename, price)
    //    {
    //        LoungeAccess = loungeAccess;
    //    }

    //    public override void PrintTicket()
    //    {
    //        Console.WriteLine($"[Ticket #{Ticketid}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | Final: {GetFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");

    //    }
    //    // Deep clone 
    //    public override object Clone()
    //    {
    //        VIPTicket copy = (VIPTicket)base.Clone();
    //        return copy;
    //    }
    //    public override decimal GetFinalPrice() => Price + (Price * 17.5m / 100) + ServiceFee;
    //}
    //class IMAXTicket : Ticket
    //{
    //    private bool _is3D;
    //    public bool Is3D
    //    {
    //        get { return _is3D; }
    //        set
    //        {
    //            if (value && !_is3D)
    //                Price += 30;
    //            if (!value && _is3D)
    //                Price -= 30;
    //            value = _is3D;
    //        }
    //    }
    //    public IMAXTicket(string moviename, decimal price, bool is3D) : base(moviename, price)
    //    {
    //        if (is3D) Price += 30;
    //        _is3D = is3D;
    //    }

    //    public override void PrintTicket()
    //    {
    //        Console.WriteLine($"[Ticket #{Ticketid}] {MovieName} | IMAX | 3D: {(_is3D ? "Yes" : "No")} | Price: {Price} | Final: {GetFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");

    //    }
    //    public override decimal GetFinalPrice() => Price + (Price * 14m / 100);
    //}
    //class Projector
    //{
    //    public bool IsRunning { get; private set; }
    //    public void Start()
    //    {
    //        IsRunning = true;
    //        Console.WriteLine("Projector ON");
    //    }
    //    public void Stop()
    //    {
    //        IsRunning = false;
    //        Console.WriteLine("Projector OOF");
    //    }
    //}
    //public partial class Cinema
    //{
    //    public string CinemaName { get; set; }
    //    private Projector _projector = new Projector();
    //    private Ticket[] tickets = new Ticket[20];
    //    public Cinema(string cinemaname)
    //    {
    //        CinemaName = cinemaname;
    //    }
    //    public Ticket this[int index]
    //    {
    //        get
    //        {
    //            if (index < 0 || index >= tickets.Length)
    //                return null;
    //            return tickets[index];
    //        }
    //        set
    //        {
    //            if (index < 0 || index >= tickets.Length)
    //                return;
    //            tickets[index] = value;
    //        }
    //    }
    //    public Ticket this[string movieName]
    //    {
    //        get
    //        {
    //            foreach (Ticket t in tickets)
    //            {
    //                if (t != null && t.MovieName == movieName)
    //                    return t;
    //            }
    //            return null;
    //        }
    //    }
    //    public bool AddTicket(Ticket t)
    //    {
    //        for (int i = 0; i < tickets.Length; i++)
    //        {
    //            if (tickets[i] == null)
    //            {
    //                tickets[i] = t;
    //                return true;
    //            }
    //        }
    //        Console.WriteLine("Cinema is full.");
    //        return false;
    //        {
    //        }
    //    }
    
    //    public void OpenCinema()
    //    {
    //        Console.WriteLine("========== Cinema Opened ==========");
    //        _projector.Start();
    //    }
    //    public void CloseCinema()
    //    {
    //        _projector.Stop();
    //        Console.WriteLine("========== Cinema Closed ==========");
    //    }
    //    internal Ticket[] GetTickets() => tickets;
    //}
    //public partial class Cinema
    //{
    //    public void PrintAllTickets()
    //    {
    //        Console.WriteLine($"\n-- All Tickets (from Cinema.Reporting) ---");
    //        foreach (Ticket t in tickets)
    //        {
    //            if (t != null)
    //            {

    //                t.PrintTicket();
    //            }
    //        }
    //    }
    //    public void PrintStatistics()
    //    {
    //        int count = 0;
    //        decimal total = 0;
    //        foreach (Ticket t in GetTickets())
    //        {
    //            if (t != null)
    //            {
    //                count++;
    //                total += t.GetFinalPrice(); 
    //            }
    //        }
    //        Console.WriteLine($"\n--- Cinema Stats ---");
    //        Console.WriteLine($"Total Tickets : {count}");
    //        Console.WriteLine($"Total Revenue : {total} EGP");
    //    }
    //}
    //// static class with at least two extension methods
    //public static class TicketExtensions
    //{
    //    public static string ToReceipt(this Ticket t)
    //    {
    //        return $"\n========== RECEIPT ==========\n" +
    //          $"  Movie  : {t.MovieName}\n" +
    //          $"  Type   : {t.GetType().Name}\n" +
    //          $"  Price  : {t.Price}\n" +
    //          $"  Final  : {t.GetFinalPrice():F2}\n" +
    //          $"  Status : {(t.IsBooked ? "Booked" : "Not Booked")}\n" +
    //          $"==============================";
    //    }
    //    public static decimal TotalRevenue(this Ticket[] tickets)
    //    {
    //        decimal total = 0;
    //        foreach (Ticket t in tickets)
    //        {
    //            if(t != null)
    //            {
    //                total += t.GetFinalPrice();
    //            }
    //        }
    //        return total;

    //    }
    //}
    //static class BookingHelper
    //{
    //    private static int counter = 0;
    //    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    //    {
    //        double total = numberOfTickets * pricePerTicket;
    //        if (numberOfTickets > 5)
    //        {
    //            return total - (total * 10.0 / 100);
    //        }
    //        return total;
    //    }
    //    public static string GenerateBookingReference()
    //    {
    //        counter++;
    //        return $"BK-{counter}";
    //    }
    //    public static void ProcessTicket(Ticket t)
    //    {
    //        Console.WriteLine("========== Process Single Ticket ==========");
    //        t.PrintTicket();
    //    }
    //    // // Interface polymorphism
    //    public static void PrintAll(IPrintable[] items)
    //    {
    //        foreach (IPrintable item in items)
    //        {
    //            item.PrintTicket();
    //        }
    //    }
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part02
            //Cinema cinema01 = new Cinema("Galaxy");
            //cinema01.OpenCinema();
            //Console.WriteLine();

            ////a
            //// Ticket t = new Ticket("LOLO" , 100m);
            ////ERROR -compiler prevents it.

            ////b
            //StandardTicket s = new StandardTicket("Inception", 80, "A5");
            //VIPTicket v = new VIPTicket("Avengers", 200, true);
            //IMAXTicket m = new IMAXTicket("Dune", 100, true);
            //s.Book();
            //v.Book();
            //m.Book();

            ////c
            //cinema01.AddTicket(s);
            //cinema01.AddTicket(v);
            //cinema01.AddTicket(m);
            //cinema01.PrintAllTickets();

            ////d
            //Ticket[] ticketArray = { s, v, m };
            //Console.WriteLine("\n-- Polymorphism: Final Price per Ticket ---");
            //foreach (Ticket t in ticketArray)
            //{
            //    Console.WriteLine($"{t.GetType().Name} => Final Price: {t.GetFinalPrice():F2}");
            //}

            ////e
            //Console.WriteLine("\n-- Etension Method : Recipt ---");
            //Console.WriteLine(v.ToReceipt());

            ////f
            //Console.WriteLine("\n--- Extension Method: Total Revenue ---");
            //Console.WriteLine($"Total Revenue ; {ticketArray.TotalRevenue():F2}");

            ////g
            //Console.WriteLine();
            //cinema01.CloseCinema();

            #endregion



        }
    }
}
