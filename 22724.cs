using System;

class Program
{

    // 1. Create a method called Add
    //    Takes two ints, returns the sum

    // 2. Method to take your name and return a greeting

    // 3. Method that takes a string and a number
    //    Returns the string multiplied by the number
    //    eg. MultString("hi", 3) --> "hihihi"

    public static void Main(string[] args)
    {
        int sum = Add(5, 7);
        Console.WriteLine(sum);

        Console.WriteLine('Enter name:');
        // gets name from line
        string name = Console.Readline();
        Console.WriteLine("Hello, " + name);
    }
}