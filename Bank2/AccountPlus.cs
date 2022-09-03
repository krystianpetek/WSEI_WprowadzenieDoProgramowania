using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{

    class AccountPlus : Account, IAccountWithLimit
    {
        private decimal Limit;
        private decimal XLimit;

        public new decimal Balance { get; private set; }
        public new bool IsBlocked { get; private set; } = false;
        public new void Unblock() { if (XLimit <= Limit) { IsBlocked = false; } }
        public new void Block() { IsBlocked = true; }

        public AccountPlus(string name, decimal initialBalance = 0, decimal initialLimit = 100) : base(name, initialBalance)
        {
            Balance = initialBalance;
            if (initialLimit < 0)
            {
                XLimit = 0;
                this.OneTimeDebetLimit = 0;
            }
            else
            {
                XLimit = initialLimit;
                this.OneTimeDebetLimit = initialLimit;
            }
        }

        public decimal OneTimeDebetLimit
        {
            get
            {
                return Limit;
            }
            set
            {
                if (!IsBlocked)
                {
                    if (Limit != XLimit)
                    {
                        var Z = value - XLimit;
                        Limit += Z;
                    }

                    Limit = value;
                    XLimit = value;
                }
            }
        }

        public void SprawdzLimit()
        {

            if (XLimit > Limit)
                Block();
            else
                Unblock();
        }

        public new bool Withdrawal(decimal amount)
        {
            if (IsBlocked == true)
                return false;
            else if (amount <= 0)
                return false;
            else if (AvaibleFounds > amount)
            {
                if (decimal.Round(amount, PRECISION) > decimal.Round(Balance, PRECISION))
                {
                    amount -= decimal.Round(Balance, PRECISION);
                    Balance -= decimal.Round(Balance, PRECISION);

                    Limit -= decimal.Round(amount, PRECISION);
                    amount -= decimal.Round(amount, PRECISION);
                    SprawdzLimit();
                }
                else if (decimal.Round(amount, PRECISION) == decimal.Round(Balance, PRECISION))
                {
                    amount -= decimal.Round(Balance, PRECISION);
                    Balance -= decimal.Round(Balance, PRECISION); SprawdzLimit();
                }
                else
                {
                    Balance -= decimal.Round(amount, PRECISION);
                    SprawdzLimit();
                }


                return true;
            }
            else return false;
        }

        public new bool Deposit(decimal amount)
        {
            if (amount <= 0)
                return false;
            else if (IsBlocked)
            {
                if (amount > (XLimit - Limit))
                {
                    var X = XLimit - Limit;
                    Limit += X;
                    amount -= X;

                    Balance += amount;
                    Unblock();
                }
                else if(amount + Limit == XLimit)
                {
                    Limit += amount;
                    Unblock();
                }
                else
                {
                    Limit += amount;
                }
                return true;
            }


            else return false;
        }


        public decimal AvaibleFounds { get { return Limit + Balance; } }

        public override string ToString()
        {
            if (IsBlocked)
                return $"Account name: {Name}, balance: {decimal.Round(Balance, 2):F2}, blocked, avaible founds: {decimal.Round(AvaibleFounds, 2):F2}, limit: {decimal.Round(XLimit, 2):F2}";
            else
                return $"Account name: {Name}, balance: {decimal.Round(Balance, 2):F2}, avaible founds: {decimal.Round(AvaibleFounds, 2):F2}, limit: {decimal.Round(XLimit, 2):F2}";
        }
    }
}
