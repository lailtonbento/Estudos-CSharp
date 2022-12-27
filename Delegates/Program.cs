using System.Linq;

namespace Delegates
{
    class Program
    {
        delegate void BinaryNumericOperation (double n1, double n2);
        delegate double BinaryNumericOperation1 (double n1, double n2);

        static void Main(string[] args)
        {
            // Delegates: É uma referencia para um ou mais metodos (É um tipo referencia)

            // Comunicacao entre objetos de forma flexivel e extensivel (events // callback)
            // Parametrizacao de operacoes por metodos (Programacao Funcional)
                // Passa uma funcao como parametro(delegate) pra outra funcao 

            // Delegates mais comum: ACTION, FUNC, PREDICATE


            // Sem delegate
            double a = 10;
            double b = 12;
            double result = CalculationService.Sum(a,b);

            System.Console.WriteLine(result);


            // Com Delegate
            BinaryNumericOperation1 op = CalculationService.Sum;
            double result2 = op(a, b);
            // double result2 = op.Invoke(a, b);
            System.Console.WriteLine(result);


            // Multicast Delegates
            BinaryNumericOperation op1 = CalculationService.ShowSum;
            op1 += CalculationService.ShowMax;
            op1(a, b);


            // Predicate Delegate
            // Representa um metodo que recebe um objeto do tipo T e retorna um valor booleano
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // list.RemoveAll(p => p.Price >= 100);
            list.RemoveAll(DeleteProductMaiorQue100);

            foreach (Product p in list)
            {
                System.Console.WriteLine(p);
            }


            // Action Delegate
            // Representa um metodo void que recebe zero ou mais argumentos

            Action<Product> act = p => {p.Price += p.Price * 0.1;};
            list.ForEach(act);
            // list.ForEach(p => {p.Price += p.Price * 0.1;});
            // list.ForEach(UpdatePriceForProductInList);

            foreach (Product p in list)
            {
                System.Console.WriteLine(p);
            }

            // Func Delegate
            // Representa um metodo que recebe zero ou mais argumentos, retornando um valor


        }
        public static bool DeleteProductMaiorQue100(Product p){
            return p.Price >= 100;
        }
        static void UpdatePriceForProductInList(Product p){
            p.Price += p.Price * 0.1;
        }
    }
}