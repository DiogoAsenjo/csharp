using System;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto
{
    abstract class Shape
    {
        Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}