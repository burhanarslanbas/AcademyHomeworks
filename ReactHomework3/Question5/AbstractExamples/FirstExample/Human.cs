using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactHomework3.Question5.AbstractExamples.FirstExample
{
    public abstract class Human
    {
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        protected Human(string identityNumber, string name, string surname, string address, string email, string phoneNumber)
        {
            IdentityNumber = identityNumber;
            Name = name;
            Surname = surname;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public abstract void Walk();
        public virtual void Eat()
        {
            Console.WriteLine("Human is eating.");
        }
    }
}
