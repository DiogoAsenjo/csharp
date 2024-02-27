using System;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto
{
    class Rectangle : Shape
    {
        double Widht { get; set; }
        double Height { get; set; }

        public Rectangle (Color color, double widht, double height) : base(color)
        {
            Widht = widht;
            Height = height;
        }

        public override double Area()
        {
            return Widht * Height;
        }
    }
}