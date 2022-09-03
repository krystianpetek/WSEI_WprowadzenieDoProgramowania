using System;

namespace Bank
{
    class Account : IAccount
    {
        protected const int PRECISION = 4;
        public string Name { get; }
        public decimal Balance { get; private set; }
        public bool IsBlocked { get; private set; } = false;

        public void Unblock() { IsBlocked = false; }
        // public void Unblock() => IsBlocked = false;
        public void Block() { IsBlocked = true; }
        //public void Block() => IsBlocked = false;

        public bool Deposit(decimal amount)
        {
            if (amount < 0)
                return false;
            else if (IsBlocked)
                return false;
            else
            {
                Balance = decimal.Round(Balance, PRECISION) + decimal.Round(amount, PRECISION);
                return true;
            }
        }

        public bool Withdrawal(decimal amount)
        {
            if (amount <= 0)
                return false;
            else if (Balance < 0)
                return false;
            else if (IsBlocked)
                return false;
            else if (decimal.Round(amount, PRECISION) > decimal.Round(Balance, PRECISION))
                return false;
            else
            {
                Balance = decimal.Round(Balance, PRECISION) - decimal.Round(amount, PRECISION);
                return true;
            }
        }

        public Account(string name, decimal initialBalance = 0)
        {
            if (name == null)
                throw new ArgumentOutOfRangeException();

            name = name.Trim();
            if (name.Length > 2)
                Name = name;
            else
                throw new ArgumentException();

            if (initialBalance >= 0)
                Balance = decimal.Round(initialBalance, PRECISION);
            else
                throw new ArgumentOutOfRangeException();
        }

        public override string ToString()
        {
            if (IsBlocked)
                return $"Account name: {Name}, balance: {decimal.Round(Balance, 2):F2}, blocked";
            else
                return $"Account name: {Name}, balance: {decimal.Round(Balance, 2):F2}";
        }
    }

}
