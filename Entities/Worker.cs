using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using PrimeiroProjeto.Entities.Enums;

namespace PrimeiroProjeto.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WokerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WokerLevel level, double salary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = salary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int month, int year)
        {
            double TotalIncome = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    TotalIncome += contract.TotalValue();
                }
            }
            return TotalIncome;
        }

        public override string ToString()
        {
            return $"Worker's data. Name: {Name}, Level: {Level}, Salary: {BaseSalary}";
        }
    }
}