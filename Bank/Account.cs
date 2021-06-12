using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account : IAccount
    {
        public string Name
        {
            get;
        }

        public decimal Balance 
        {
            get;
            private set;
        }

        public bool IsBlocked
        {
            get; private set;
        }


        public void Block()
        {
            IsBlocked = true;
        }

        public bool Deposit(decimal amount)
        {
            if (amount < 0)
                return false;
            else if (IsBlocked)
                return false;
            else
            {
                if (decimal.Round(amount, 4) > decimal.Round(Balance, 4))
                    {
                    Balance += decimal.Round(amount, 4);
                    return true;
                }
                else
                    return false;
            }
        }
        public void Unblock()
        {
            IsBlocked = false;    
        }

        public bool Withdrawal(decimal amount)
        {
            if (Balance < 0)
                return false;
            else if (IsBlocked)
                return false;
            else if(decimal.Round(amount,4) > decimal.Round(Balance,4))
            
                return false;
            else
            {
                Balance = Balance - decimal.Round(amount, 4);
                return true;
            }
        }

        public Account(string nazwa)
        {
            nazwa = nazwa.Trim();
            if(nazwa.Length > 2)
            Name = nazwa;

            Balance = 0;
        }

        public override string ToString()
        {
            if (IsBlocked)
                return $"Account name: {Name}, balance: {Balance}, blocked";
            else
                return $"Account name: { Name}, balance: { Balance}";
        }
    }

}
