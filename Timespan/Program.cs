namespace Timespan
{
    internal class Program {
        static void Main (string [] args){

            // TimeSpan represent an duration
            // Instanciacao: constructor, fields, methods From, Parse
            // Represents a duration in the form of ticks

                                        // hora, min, segundo
            TimeSpan tspan = new TimeSpan(0, 1, 30);
            Console.WriteLine(tspan);
            // 00:01:30

            // Timespan de 1 dia e meio
            TimeSpan tspan1 = TimeSpan.FromDays(1.5);
            Console.WriteLine(tspan1);
            // 1.12:00:00

            // Timespan de 1 hora e meia
            TimeSpan tspan2 = TimeSpan.FromHours(1.5);
            Console.WriteLine(tspan2);
            // 01:30:00 

            // Timespan de 1 minuto e meio
            TimeSpan tspan3 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(tspan3);
            // 00:01:30

            
            // Timespan de 1 segundo e meio
            TimeSpan tspan4 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(tspan4);
            // 00:00:01.5000000

            
            // Timespan de 1 milisegundos e meio
            TimeSpan tspan5 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(tspan5);
            // 00:00:00.0015000
        }
    }
}