using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Entities.Generics

{
    class Product : IComparable 
    {
        string Name { get; set; }
        double Price { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public override string ToString() {
            return $"{this.Name} costs: {this.Price}";
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Product)) 
            {
                throw new ArgumentException("Argument is not a product");
            }

            Product other = obj as Product;
            return this.Price.CompareTo(other.Price);

        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Product)) return false;

            Product other = obj as Product;
            return Name.Equals(other.Name);
        }

        public override int GetHashCode() 
        {
            return Name.GetHashCode();
        }
    }
}