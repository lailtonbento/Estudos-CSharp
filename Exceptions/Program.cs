namespace Exceptions
{
 class Program
 {
        static double SafeDivision(double x, double y)
    {
        if (y == 0)
            throw new DivideByZeroException();
        return x / y;
    }


    static void Main(string[] args)
    {
        // Exceptions é uma condicao de erro ou comportamento inesperado lancadas pelo compilador em tempo de execucao
        // As exceptions derivam de System.Exceptions

        double a = 98, b = 2;
        // Exception: DivideByZeroException
        double result;

        // Bloco Try: codigo que representa a execucao normal do codigo que pode lancar uma exception
        try
        {
            result = SafeDivision(a, b);
            Console.WriteLine($"{a} divided by {b} = {result}");
        }
        // Bloco Catch: Contem o codigo que sera executado caso ocorra a exception
        // Deve ser especificado o tipo de exception a ser tratada
        catch (DivideByZeroException)
        {
            Console.WriteLine("Attempted divide by zero.");
        }
        
    }
 }   
}