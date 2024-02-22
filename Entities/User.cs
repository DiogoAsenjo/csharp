using System;

namespace PrimeiroProjeto.Entities
{
    class User
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public User (int id, string name) 
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Usuário: {Name}";
        }
    }

    
}