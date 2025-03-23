//class Person
//{
//    public string Name;
//    public int Age;
//}

//class Program
//{
//    static void Main()
//    {
//        Person person = new Person(); // Default constructor
//        person.Name = "John";
//        person.Age = 25;
//    }
//}
//Static Method Se
class Person
{
    public string Name;
    public int Age;

    private Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static Person CreatePerson(string name, int age)
    {
        return new Person(name, age);
    }
}

class Program
{
    static void Main()
    {
        Person person = Person.CreatePerson("Alice", 30); // Using static method
    }
}
