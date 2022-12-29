using System.Linq;
using linq;

namespace LINQ
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            System.Console.WriteLine(message);
            foreach (T obj in collection)
            {
                System.Console.WriteLine(obj);
            }
        }
        static void Main(string[] args)
        {
            // Langue Integrated Query
            // LINQ: É um conjunto de bibliotecas baseadas na integraçao de funcionalidades de consulta diretamente na linguagem C#
            // Consultas são objetos de primeira classe
            // Operaçoes chamadas diretamente a partir das colecoes
            // Possui diversas operaçoes de consulta, cujos parametros são na maioria expressoes lambda ou expressoes de sintaxe similar a SQL

            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Definir a expressao da query
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Executar a query
            foreach (int x in result)
            {
                // System.Console.WriteLine(x);
                // 20
                // 40
            }
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 2, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>(){
                new Product(){Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product(){Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product(){Id = 3, Name = "TV", Price = 1700.0, Category = c3},
                new Product(){Id = 4, Name = "Tablet", Price = 700.0, Category = c2},
                new Product(){Id = 5, Name = "Camera", Price = 700.0, Category = c3},
                new Product(){Id = 6, Name = "Printer", Price = 350.0, Category = c3},
                new Product(){Id = 7, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product(){Id = 8, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product(){Id = 9, Name = "Level", Price = 70.0, Category = c1},
            };


            // var result1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            var result1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            Print("TIER 1 AND PRICE < 900: ", result1);

            //var result2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var result2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("Names OF Products FROM Tools: ", result2);

            //var result3 = products.Where(p => p.Category.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var result3 =
                from p in products
                where p.Category.Name[0] == 'C'
                select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("Names started with C and Anonymous object: ", result3);

            //var result4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var result4 =
                 from p in products
                 where p.Category.Tier == 1
                 orderby p.Name
                 orderby p.Price
                 select p;
            Print("Tier 1 order by Preço Then by Name: ", result3);

            //var result5 = result4.Skip(2).Take(4);
            var result5 =
                (from p in result4
                 select p).Skip(2).Take(4);
            Print("Tier 1 order by Preço Then by Name, Skip 2 and Take 4: ", result3);

            //var result6 = products.FirstOrDefault();
            var result6 =
                (from p in products
                 select p).FirstOrDefault();
            System.Console.WriteLine("First result: " + result6);

            //var result7 = products.Where(p => p.Price > 3000.0);
            var result7 =
                (from p in products
                where p.Price > 3000.0
                select p).FirstOrDefault();
            System.Console.WriteLine("First or Default result of Price > 3000: ", result7);

            // Map and Reduce
            var result8 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            System.Console.WriteLine("Sum Price of Category ID: ", result8);

            var result9 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            System.Console.WriteLine("Average Price of Category ID: ", result8);

            // Map and Reduce (Select and Aggregate)
            var result10 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            System.Console.WriteLine("Mapping for price and aggregate sum: ", result10);

        }
    }
}