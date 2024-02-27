using System;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto
{
    class Circle : Shape
    {
        double Radius { get; set; }

        public Circle (Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}