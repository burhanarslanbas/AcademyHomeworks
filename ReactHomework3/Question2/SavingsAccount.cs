using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactHomework3.Question2
{
    public class SavingsAccount : BankAccount
    {

        public override void CalculateInterest()
        {
            Console.WriteLine("Interest: " + Balance * 0.05m);
        }
    }
}
