
namespace Delegates
{
    class FuncDelegate
    {
        static void Main(string[] args)
        {

            // Func Delegate
            // Representa um metodo que recebe zero ou mais argumentos, retornando um valor

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            
            // Func<Product, string> funcDelegate = NameUpper;
            // Func<Product, string> funcDelegate = p => p.Name.ToUpper();
            // List<string> result = list.Select(funcDelegate).ToList();
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                System.Console.WriteLine(result);
            }

        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}