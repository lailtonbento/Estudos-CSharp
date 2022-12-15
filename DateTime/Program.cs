namespace Datetime
{
    internal class Program {
        static void Main (string [] args){

            // Datetime represent an Instant (date and hour)
            // Many constructors and builders for DateTime

            // Properts: Date, Day, DayOfWeek, DayOfYears, Hour, Kind, Millisecond, Minute, Month, Second, TimeOfDay, Year
            
            DateTime dateNow = DateTime.Now; 
            Console.WriteLine(dateNow);
            // 15/12/2022 13:06:30 -> Data atual e horario atual
            
            DateTime date2 = new DateTime(2022, 12, 15);
            Console.WriteLine(date2);
            // 15/12/2022 00:00:00 -> Data atual e horario padrao (meia noite)
            DateTime date3 = DateTime.Today; // Dia de hoje e horario padrao (meia noite)

            DateTime date4 = new DateTime(2023, 04, 13, 14, 14, 0);
            Console.WriteLine(date4);
            // 13/04/2023 14:14:00 -> Data e horario especifico

            DateTime date5 = DateTime.Parse("2022-12-15");
            Console.WriteLine(date5);
            // 15/12/2022 00:00:00

        }
    }
}