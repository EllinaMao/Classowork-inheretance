using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1
{
    internal class Builder:Human
    {
        readonly string Project;

        public Builder(string name, string gender, string job, DateTime birthdate, string project):base (name, gender, job, birthdate)
        {

            Project = project;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Project: {0}", Project);

            Console.WriteLine();
        }

    }
}
