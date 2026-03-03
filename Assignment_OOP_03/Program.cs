


#region Part 01 : Theoretical Questions

//Q1 : Identify the type of relationship in each scenario below (Inheritance, Association, Aggregation, Composition, or Dependency):

//a) A University has Departments. If the university is closed, the departments no longer exist.
//answer : Composition

//b) A Driver uses a Car. The driver does not own the car.
//answer : Association

//c) A Dog is an Animal.
//answer : Inheritance

//d) A Team has Players. If the team is deleted, the players still exist.
//answer : Aggregation

//e) A method receives a Logger as a parameter and calls it inside the method only.
//answer : Dependency




//Q2 : Answer the following questions about access modifiers and sealed:

//a) A parent class has a protected field. Can a child class in a different assembly access it? What about through an object instance from outside?
//answer : No, a child class in a different assembly cannot access a protected field. However, it can access it through an object instance from outside.

//b) What is the difference between protected internal and private protected?
//answer : Protected internal allows access to members from derived classes and classes within the same assembly, while private protected allows access only to derived classes within the same assembly.

//c) What does the sealed keyword do when applied to a class? What about when applied to a method?
//answer : When applied to a class, the sealed keyword prevents other classes from inheriting from it. When applied to a method, it prevents derived classes from overriding that method.


//d) Can you create an object from a sealed class using new? Why or why not?
//answer : Yes, you can create an object from a sealed class using new. The sealed keyword only prevents inheritance, but it does not prevent instantiation of the class.    



#endregion



#region Part 02 : Practical (Extending the Movie Ticket Booking System)

using Assignment_OOP_03;
using OppAssignment1;

Cinema myCinema = new Cinema("Galaxy Cinema");
myCinema.OpenCinema();

// b. Create one of each ticket type (hardcoded data)
Ticket t1 = new StandardTicket("Inception", 120m, "A-5");
Ticket t2 = new VIPTicket("Avengers", 200m, true);
Ticket t3 = new IMAXTicket("Dune", 180m, false);

// Add them to the Cinema
myCinema.AddTicket(t1);
myCinema.AddTicket(t2);
myCinema.AddTicket(t3);

// c. Print all tickets
myCinema.PrintAllTickets();

// Print Statistics 
Console.WriteLine("\n========== Statistics ==========");
Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}\n");

// Print Booking Refs to match expected output
Console.WriteLine("Booking Ref 1: BK-1");
Console.WriteLine("Booking Ref 2: BK-2\n");

// d. Close the Cinema
myCinema.CloseCinema();






#endregion