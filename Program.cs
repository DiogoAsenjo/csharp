﻿using System;
using System.ComponentModel;
using PrimeiroProjeto.Entities;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Departament d1 = new Departament("Operations");

            Worker w1 = new Worker("Diogo", WokerLevel.Junior, 1600.00, d1);

            HourContract hc1 = new HourContract(new DateTime(2023, 12, 29), 1.00, 1);
            HourContract hc2 = new HourContract(new DateTime(2023, 12, 29), 1.00, 2);

            w1.AddContract(hc1);
            w1.AddContract(hc2);
            w1.RemoveContract(hc2);

            double salary = w1.Income(12, 2023);


            Console.WriteLine(salary);
        }
    }
}