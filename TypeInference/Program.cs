using System;
namespace TypeInference {
internal class Program
{
    private static void Main(string[] args)
    {
        int x = 10;

        // Type Inferece: permite que armazene qualquer tipo de valor implicitamente

        var y = 10; // armazena o tipo int
        var name = "Lailton"; // armazena o tipo string
        var d = 20.0; //armazena o tipo double

        Console.WriteLine("Type X: " + x.GetType());
        Console.WriteLine("Type Y: " + y.GetType());
        Console.WriteLine("Type Name: " + name.GetType());
        Console.WriteLine("Type D: " + d.GetType());
    }
    
}

}

