using ExContratoTrabalho.Entities.Enums;
using System.Collections.Generic;
using System;

namespace ExContratoTrabalho.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level {get; set;}
        public double BaseSalay { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts {get; private set;} =  new List<HourContract>();

        public Worker ()
        {

        }

        public Worker (string name, WorkerLevel level, double baseSalay, Departament departament) 
        {
            Name = name;
            Level = level;
            BaseSalay = baseSalay;
            Departament = departament;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalay;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                   sum+= contract.totalValue();
                }
            }

            return sum;
        }
    }
}