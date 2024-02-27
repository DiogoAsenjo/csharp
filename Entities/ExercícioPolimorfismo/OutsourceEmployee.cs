using System;
using PrimeiroProjeto.Entities;

namespace PrimeiroProjeto
{
    class OutsourceEmployee : Employee
    {
        double AditionalCharge { get; set; }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double aditionalCharge) : base(name, hours, valuePerHour)
        {
            AditionalCharge = aditionalCharge;
        }

        public override double Payment()
        {
            double baseSalary = base.Payment();
            return baseSalary + AditionalCharge;
        }

        public string OutsourceMethod()
        {
            return "This is an exclusive method of outsource employee";
        }
    }
}