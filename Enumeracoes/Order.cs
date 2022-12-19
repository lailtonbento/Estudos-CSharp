using System;

namespace Enumeracoes
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        OrderStatus Status { get; set; }

        public Order(int id, DateTime date, OrderStatus status)
        {
            Id = id;
            Date = date;
            Status = status;
        }

        public override string ToString()
        {
            return "Id: " + Id
            + ", "
            + "Date: " + Date
            + ", "
            + "Order Status: " + Status;
        }
    }
}