using System;
using System.Collections.Generic;
using ExercicioHeranca.Entity;
using System.Globalization;
namespace ExercicioHeranca
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Trabalhador> listTrab = new List<Trabalhador>();

            Console.Write("Quantidade de Trabalhadores: ");
            int numberOfEmployee = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfEmployee; i++)
            {
                Console.WriteLine($"Trabalhador Numero #{i}: ");
                Console.Write("Terceirizado ? (y/n) ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por Hora: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Bonus Adicional: ");
                    double bonusAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listTrab.Add(new TrabalhadorTerceirizado(name, hours, valuePerHours, bonusAdicional));
                }
                else
                    listTrab.Add(new Trabalhador(name, hours, valuePerHours));

            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Pagamentos: ");

            foreach (Trabalhador trabalhador in listTrab)
            {
                Console.WriteLine($"Nome: {trabalhador.Name} - R$ {trabalhador.Pagamento()}");
            }
        }
    }
}
