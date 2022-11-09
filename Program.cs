using System;

interface ICustomer // we create an interface using prefix I
{
    void Print();
}

interface IStudent : ICustomer // so interface can inherit from another interface 
{
    void Stud();
}

public class Customer : IStudent // so IStudent is inheriting from ICustomer so ICustomer is also a Parent for Customer class
{
    public void Print() // we call the methods inside the Customer class 
    {
        Console.WriteLine("I am interface method");
    }

    public void Stud()
    {
        Console.WriteLine("I am interface 2");
    }
}

class Interface
{
    public static void Main()
    {
        Customer C = new Customer(); // creating an instance of Customer class and calling the methods in our main class.
        C.Print();
        C.Stud();
    }
}