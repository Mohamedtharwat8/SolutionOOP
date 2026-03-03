#region Part 01 - Q1
// Explain with code example how class and struct behave differently

class Person
{
    public string Name;
}

struct Point
{
    public int X;
    public int Y;
}
#endregion


#region Part 01 - Q2
// Explain the difference between public and private access modifiers with an example

class Student
{
    public string Name;
    private int Grade;

    public void SetGrade(int grade)
    {
        Grade = grade;
    }

    public int GetGrade()
    {
        return Grade;
    }
}
#endregion


#region Part 01 - Q4
/*
 What is a class library?
 A class library is a separate project that contains reusable classes and logic
 that can be referenced and used in other projects.

 Why do we use it?
 1. Code reuse
 2. Better organization
 3. Separation of concerns
 4. Easier maintenance
*/
#endregion


#region Part 02 - Movie Ticket Booking System

public enum TicketType
{
    Standard,
    VIP,
    IMAX
}

public struct Seat
{
    public char Row;
    public int Number;

    public Seat(char row, int number)
    {
        Row = row;
        Number = number;
    }
}

public class Ticket
{
    public string MovieName { get; set; }
    public TicketType Type { get; set; }
    public Seat Seat { get; set; }
    private double Price;

    public Ticket(string movieName, TicketType type, Seat seat, double price)
    {
        MovieName = movieName;
        Type = type;
        Seat = seat;
        Price = price;
    }

    public Ticket(string movieName)
        : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
    {
    }

    public double CalcTotal(double taxPercent)
    {
        double tax = Price * taxPercent / 100;
        return Price + tax;
    }

    public void ApplyDiscount(ref double discountAmount)
    {
        if (discountAmount > 0 && discountAmount <= Price)
        {
            Price -= discountAmount;
            discountAmount = 0;
        }
    }

    public void PrintTicket()
    {
        Console.WriteLine("----- Ticket Info -----");
        Console.WriteLine("Movie: " + MovieName);
        Console.WriteLine("Type: " + Type);
        Console.WriteLine("Seat: " + Seat.Row + Seat.Number);
        Console.WriteLine("-----------------------");
    }
}

#endregion


#region Program

internal class Program
{
    static void Main(string[] args)
    {
        // Class vs Struct example
        Person p1 = new Person();
        p1.Name = "Yara";

        Person p2 = p1;
        p2.Name = "Ali";

        Console.WriteLine("Class Example:");
        Console.WriteLine("p1.Name = " + p1.Name);

        Point pt1;
        pt1.X = 10;
        pt1.Y = 20;

        Point pt2 = pt1;
        pt2.X = 50;

        Console.WriteLine("Struct Example:");
        Console.WriteLine("pt1.X = " + pt1.X);

        // Public vs Private example
        Student s = new Student();
        s.Name = "Omar";
        s.SetGrade(95);
        Console.WriteLine("Student Grade: " + s.GetGrade());

        // Movie Ticket System
        Console.Write("Enter Movie Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Ticket Type (Standard, VIP, IMAX): ");
        TicketType type = Enum.Parse<TicketType>(Console.ReadLine());

        Console.Write("Enter Seat Row: ");
        char row = char.Parse(Console.ReadLine());

        Console.Write("Enter Seat Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());

        Ticket ticket = new Ticket(name, type, new Seat(row, number), price);

        Console.Write("Enter Discount: ");
        double discount = double.Parse(Console.ReadLine());

        ticket.ApplyDiscount(ref discount);

        Console.Write("Enter Tax Percentage: ");
        double tax = double.Parse(Console.ReadLine());

        double total = ticket.CalcTotal(tax);

        ticket.PrintTicket();
        Console.WriteLine("Total After Tax: " + total);
    }
}

#endregion