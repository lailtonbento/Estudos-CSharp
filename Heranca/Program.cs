namespace Heranca
{
    class Program {
       static void Main(string[] args){

        
        //  Ela permite que você defina uma classe filha que reutiliza (herda), estende ou modifica o comportamento de uma classe pai

        // : (Estende)
        // base (referencia para a superclass)

        SO windows11 = new Windows(creator: "Bill Gates");
        SO linux = new Linux(creator: "Linus Torvalds");

        Console.WriteLine(windows11.ToString());
        // Creator: Bill Gates, Is Open-Source?: False

        Console.WriteLine(linux.ToString());
        // Creator: Linux Torvald, Is Open-Source?: True
       } 
    }
}