using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    abstract class Human
    {
        protected string? Name;
        protected string? Gender;
        protected string? Job;
        protected DateTime Birthdate;
        
        protected Human(string name, string gender, string job, DateTime birthdate) {
            Name = name;
            Gender = gender;
            Job = job;
            Birthdate = birthdate;

        }
        public virtual void Show()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine("Birthdate: {0}", Birthdate.ToString("yyyy-MM-dd")); // → 2023-01-09
            Console.WriteLine("Gender: {0}", Gender);
            Console.WriteLine("Job: {0}", Job);
        }
    }
}
