using System;

class Person
{
    private string name;
    private int age;
    private string address;

    // Constructor 1: Default Constructor
    public Person() : this("Unknown") // Calls Constructor 2
    {
        Console.WriteLine("Default Constructor Called");
    }

    // Constructor 2: Single Parameter Constructor
    public Person(string name) : this(name, 0) // Calls Constructor 3
    {
        Console.WriteLine("Single Parameter Constructor Called");
    }

    // Constructor 3: Two Parameters Constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.address = "Not Provided";
        Console.WriteLine("Two Parameters Constructor Called");
    }

    // Display Method to Show Data
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Address: {address}");
    }
}

class Program
{
    static void Main()
    {
        // Using Default ConstructorS
        Person person1 = new Person();
        person1.DisplayDetails();
/*
        // Using Single Parameter Constructor
        Person person2 = new Person("John");
        person2.DisplayDetails();

        // Using Two Parameter Constructor
        Person person3 = new Person("Alice", 25);
        person3.DisplayDetails();*/
    }
}
