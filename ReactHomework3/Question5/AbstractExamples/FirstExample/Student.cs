using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactHomework3.Question5.AbstractExamples.FirstExample
{
    public class Student:Human
    {
        public string SchoolNumber { get; set; }
        public string SchoolName { get; set; }
        public Student(string identityNumber, string name, string surname, string address, string email, string phoneNumber, string schoolNumber, string schoolName) : base(identityNumber, name, surname, address, email, phoneNumber)
        {
            SchoolNumber = schoolNumber;
            SchoolName = schoolName;
        }
        public override void Walk()
        {
            Console.WriteLine("Student is walking.");
        }
        public override void Eat()
        {
            Console.WriteLine("Student is eating.");
        }
    }
}
