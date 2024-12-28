using System;

class Program
{
    static void Main()
    {
        // Defining a list with mixed data types
        object[] vdt = { 
            516, 
            112.49, 
            true, 
            "meow", 
            Tuple.Create("Western", "Governors", "University"), 
            new System.Collections.Generic.Dictionary<string, int> 
            { 
                { "apple", 1 }, 
                { "pear", 5 } 
            } 
        };

        // Accepting integer input for the index
        Console.Write("Enter the index of the list element: ");
        int i = int.Parse(Console.ReadLine());

        // Getting the data type of the element
        string typeName = vdt[i].GetType().Name;

        // Outputting the result
        Console.WriteLine($"Element {i}: {typeName}");
    }
}