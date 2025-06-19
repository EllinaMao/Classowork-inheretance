using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Sailor:Human
    {
        readonly bool Voyage;
        readonly string Direction;

        public Sailor(string name, string gender, string job, DateTime birthdate, bool voyage, string direction) : base(name, gender, job, birthdate){

            Voyage = voyage;
            Direction = direction;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Voyage: {0}" +
                "\nDirection: {1}",
                Voyage, Direction);

            Console.WriteLine();

        }













    }
}
