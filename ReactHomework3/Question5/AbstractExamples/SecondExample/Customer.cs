using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactHomework3.Question5.AbstractExamples.SecondExample
{
    public class Customer : User
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Company { get; set; }
        public string Fax { get; set; }

        public void CreateOrder()
        {
            Console.WriteLine("Order created");
        }
    }
}
