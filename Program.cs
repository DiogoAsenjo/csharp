using System;
using System.ComponentModel;
using PrimeiroProjeto.Entities;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reservation res1 = new Reservation(1, new DateTime(2024, 03, 31), new DateTime(2024, 04, 01));
            Console.WriteLine(res1.Duration());
        }
    }
}