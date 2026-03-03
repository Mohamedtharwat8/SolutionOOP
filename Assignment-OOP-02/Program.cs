#region Part 01 : Theoretical Questions


//Q1 : Consider the following class:
//    public class BankAccount
//{
//    public string Owner;
//    public double Balance;

//    public void Withdraw(double amount)
//    {
//        Balance -= amount;
//    }
//}

//a) Identify at least two problems with this design from an encapsulation perspective.
//answer :  
// 1- the two property Owner and Balance are public which means they can be accessed and modified directly from outside the class, which violates the principle of encapsulation.
// 2- the Withdraw method does not have any validation to check if the amount being withdrawn is greater than the current balance, which can lead to negative balances and potential issues with data integrity.

//b) Describe how you would fix this class to follow proper encapsulation principles. You do not need to write the full code.
//answer : 1- change  Owner and Balance properties to private and provide public getter and setter methods to access and modify them, which allows for better control over how these properties are accessed and modified.
// 2- add validation logic in the Withdraw method to check if the amount being withdrawn is greater than the current balance, and if so, throw an exception or return an error message to prevent negative balances and maintain data integrity.


//c) Explain why exposing fields directly (as public) is considered a bad practice in OOP.
//answer : Exposing fields directly as public is considered a bad practice in OOP because it breaks the principle of encapsulation, which is one of the core principles of OOP. When fields are exposed directly, it allows external code to access and modify the internal state of an object without any control or validation. This can lead to unintended consequences, such as data corruption, security vulnerabilities, and difficulties in maintaining and debugging the code. By using private fields and providing public getter and setter methods, you can control how the internal state of an object is accessed and modified, ensuring that it remains consistent and secure.


//Q02 : What is the difference between a field and a property in C#? Can a property contain logic? Give an example of a read-only property that returns a calculated value.
//answer : A field is a variable that is declared directly in a class or struct and can be accessed and modified directly.
//A property, on the other hand, is a member that provides a flexible mechanism to read, write, or compute the value of a private field.
//Properties can contain logic in their getter and setter methods, allowing for validation, transformation, or other operations when accessing or modifying the underlying field.
//Example of a read-only property that returns a calculated value: 
/*
 public class Rectangle
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Read-only property that calculates the area
    public double Area
    {
        get
        {
            return width * height; // property contains logic (calculation)
        }
    }
}
 */



//Q3 : Look at the following code and answer the questions below:
//    public class StudentRegister
//{
//    private string[] names = new string[5];

//    public string this[int index]
//    {
//        get { return names[index]; }
//        set { names[index] = value; }
//    }
//}

//a) What is `this[int index]` called? Explain its purpose.
//answer : `this[int index]` is called an indexer. An indexer allows an object to be indexed like an array, providing a way to access elements in a collection or array-like structure using the square bracket notation. In this case, the indexer allows you to access and modify the elements of the `names` array using an integer index.

//b) What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer safer?
//answer : If someone writes `register[10] = "Ali";`, it will throw an `IndexOutOfRangeException` because the index 10 is out of bounds for the `names` array, which has a length of 5. To make the indexer safer, you can add validation logic in the setter to check if the index is within the valid range before attempting to access or modify the array. For example:
//   public string this[int index]
//{
//    get { return names[index]; }
//    set 
//    {
//        if (index < 0 || index >= names.Length)
//        {
//            throw new IndexOutOfRangeException("Index is out of range.");
//        }
//        names[index] = value;
//    }
//}
//

//c) Can a class have more than one indexer? If yes, give an example of when that would be useful.
//answer : Yes, a class can have more than one indexer, as long as they have different parameter types or numbers of parameters. This can be useful in scenarios where you want to provide different ways to access the data within the class. For example, you could have one indexer that allows access by an integer index and another indexer that allows access by a string key



//Q4 : Consider the following code and answer the questions below:
//    public class Order
//{
//    public static int TotalOrders = 0;
//    public string Item;

//    public Order(string item)
//    {
//        Item = item;
//        TotalOrders++;
//    }
//}

//a) What does the `static` keyword mean on `TotalOrders`? How is it different from the `Item` field?
//answer : The `static` keyword on `TotalOrders` means that it belongs to the class itself rather than to any specific instance of the class. This means
//that there is only one copy of `TotalOrders` shared among all instances of the `Order` class. In contrast, the `Item` field is an instance member, meaning that each instance of the `Order` class has its own copy of the `Item` field.
//When a new `Order` is created, it increments the `TotalOrders` static field, which keeps track of the total number of orders created across all instances.


//b) Can a static method inside `Order` access the `Item` field directly? Why or why not?
//answer : No, a static method inside the `Order` class cannot access the `Item` field directly because `Item` is an instance member, and static methods do not have access to instance members. Static methods can only access other static members of the class. To access the `Item` field, a static method would need to create an instance of the `Order` class or receive an instance as a parameter.

#endregion




#region Part 02 : Practical (Extending the Movie Ticket Booking System)
using Assignment_OOP_02;
using System.Net.Sockets;

Console.WriteLine("========== Ticket Booking ==========");
Cinema cinema = new Cinema();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Enter details for ticket #{i + 1}:");
    Console.Write("Movie name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Ticket type (Standard = 0, Premium = 1, VIP = 2): ");
    TicketType type = (TicketType)int.Parse(Console.ReadLine());

    Console.Write("Seat row: ");
    char row = char.Parse(Console.ReadLine());
    Console.Write("Seat number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    Ticket ticket = new Ticket(name, type, new SeatLocation((char)row, number), price);
    bool added = cinema.AddTicket(ticket);
    if (!added)
        Console.WriteLine("Failed to add ticket, cinema is full!");
    Console.WriteLine("\n\n\n");
}

Console.WriteLine("\n========== All Tickets ==========");
for (int i = 0; i < 3; i++)
{
    Ticket t = cinema[i];
    if (t != null)
        Console.WriteLine(t);
}

Console.WriteLine("\n========== Search by Movie ==========");
Console.Write("\nEnter movie name to search: ");
string searchName = Console.ReadLine();
var foundTicket = cinema.GetMovieByName(searchName);
if (foundTicket != null)
    Console.WriteLine("Found: " + foundTicket);
else
    Console.WriteLine("Movie not found.");

Console.WriteLine($"\nTotal tickets sold: {Ticket.GetTotalTicketsSold()}");

Console.WriteLine($"Booking reference 1: {BookingHelper.GenerateBookingReference()}");
Console.WriteLine($"Booking reference 2: {BookingHelper.GenerateBookingReference()}");

Console.WriteLine($"\nGroup discount for 5 tickets at 80 EGP each: {BookingHelper.CalcGroupDiscount(5, 80)} EGP");

#endregion
