using System;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Moment: {Moment}, Status: {Status}";
        }
    }
}