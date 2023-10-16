using System.Xml;

class Variable
{
    static void Main(string[] qwe)
    {
        object height = 1.88;
        object name = "Amir";
        Console.WriteLine($"{name} is {height} meters tall.");
        // int length1 = name.Length; // gives error
        int length2 = ((string)name).Length;
        Console.WriteLine($"{name} has {length2} characters.");
        dynamic something = "Harry";
        Console.WriteLine($"Length is {something.Length}");
        Console.WriteLine($"default(int) = {default(int)}");
        Console.WriteLine($"default(bool) = {default(bool)}");
        Console.WriteLine($"default(DateTime) = {default(DateTime)}");
        Console.WriteLine($"default(string) = {default(string)}");
        
    }
}



// class Person
// {
//     public DateTime BirthDate;
// }

// Person kim = new();
// kim.BirthDate = new(1997,12,3)