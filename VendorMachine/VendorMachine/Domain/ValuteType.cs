using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class ValuteType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Par { get; set; } // Прим. Влад: ЧТО ТЫ ТАКОЕ? Прим. Ден: Знакомся, номинал
        public int CurrentAmount { get; set; }

        public ValuteType(int id, string name, int par, int amount)
        {
            ID = id;
            Name = name;
            Par = par;
            CurrentAmount = amount;
        }

        public ValuteType(string name, int par)
        {
            Name = name;
            Par = par;
        }

        public void AddAmount() => CurrentAmount++;

        public override string ToString() => $"{Name} номиналом {Par} единиц";
    }
}