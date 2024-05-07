using System;

namespace PrimeiroProjeto.Entities
{
    public class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }

        public override string ToString()
        {
            return $"Model: {Model}";
        }
    }
}