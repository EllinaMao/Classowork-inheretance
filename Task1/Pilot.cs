using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Pilot : Sailor
    {
        readonly int AmountOfPeople;
        public Pilot(string name, string gender, string job, DateTime birthdate, int amountOfPeople, bool voyage,  string? direction = null) : base(name, gender, job, birthdate, voyage, direction)
        {
            AmountOfPeople = amountOfPeople;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("People on board: {0}", AmountOfPeople);

            Console.WriteLine();

        }
    }

}
