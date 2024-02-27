using System;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return $"Value per hour: {ValuePerHour}, Hours: {Hours}";
        }
    }
}