using System;

namespace PrimeiroProjeto
{
    class Employee
    {
        string Name { get; set; }
        int Hours { get; set; }
        double ValuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return $"Employee. Name: {Name}, Hours: {Hours}, Value per Hour: {ValuePerHour}";
        }
    }
}