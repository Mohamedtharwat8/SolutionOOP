

#region Part 01 : Theoretical Questions


//Q1 : What is the difference between static binding and dynamic binding? When does each one happen?
//answer : Static binding, also known as early binding, occurs at compile time when the method to be called is determined based on the reference type. Dynamic binding, also known as late binding, occurs at runtime when the method to be called is determined based on the actual object type.

//Q2 :  What is the difference between method overloading and method overriding?
//answer : Method overloading is when multiple methods have the same name but different parameters within the same class.
//Method overriding is when a subclass provides a specific implementation of a method that is already defined in its superclass.

//Q3 : What keywords are used for Method Overriding? What does each one mean ?
//answer : The keywords used for method overriding are "virtual", "override", and "abstract".
//- "virtual" is used in the base class to indicate that a method can be overridden in a derived class.
//- "override" is used in the derived class to indicate that a method is overriding a virtual method in the base class.
//- "abstract" is used in the base class to indicate that a method must be overridden in any non-abstract derived class.


#endregion
#region Part 02 : Practical (Extending the Movie Ticket Booking System)



using Assignment_OOP_04;

Cinema myCinema = new Cinema("Galaxy Cinema");
myCinema.OpenCinema();

// b. Create one of each ticket type (hardcoded data)           
StandardTicket t1 = new StandardTicket("Inception", 1, "A-5");
VIPTicket t2 = new VIPTicket("Avengers", 2, true, 50);
IMAXTicket t3 = new IMAXTicket("Dune", 3, false);


// c) Test both versions of SetPrice on one ticket.
Console.WriteLine("========== SetPrice Test ==========");
t1.SetPrice(150m);
t1.SetPrice(100m, 1.5m);
Console.WriteLine();


// set other ticket prices (so output matches the sample style)
t2.SetPrice(200m);
t3.SetPrice(180m);

// d) Add all tickets to the Cinema and call PrintAllTickets().
myCinema.AddTicket(t1);
myCinema.AddTicket(t2);
myCinema.AddTicket(t3);


// c. Print all tickets
myCinema.PrintAllTickets();

// e) Call ProcessTicket() with one of the tickets.
BookingHelper.ProcessTicket(t2);



//// Print Statistics 
//Console.WriteLine("\n========== Statistics ==========");
//Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}\n");

//// Print Booking Refs to match expected output
//Console.WriteLine("Booking Ref 1: BK-1");
//Console.WriteLine("Booking Ref 2: BK-2\n");

// d. Close the Cinema
myCinema.CloseCinema();



#endregion