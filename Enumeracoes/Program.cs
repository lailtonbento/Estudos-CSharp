using System;


namespace Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Enum
            //Definicao: Espeficiar de forma literal um conjunto de constantes

            Order order1 = new Order(1, DateTime.Now, OrderStatus.PENDINGPAYMENT);

            Console.WriteLine(order1);
            // Id: 1, Date: 16/12/2022 14:03:23, Order Status: PENDINGPAYMENT


            // Converte Enum para string
            string EnumToString = OrderStatus.PENDINGPAYMENT.ToString();

        }
    }
};