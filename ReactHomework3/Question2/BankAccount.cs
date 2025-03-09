using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactHomework3.Question2
{
    public class BankAccount
    {
        private string accountHolder;
        private string accountNumber;
        private decimal balance;
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public virtual void CalculateInterest() { }
    }
}
