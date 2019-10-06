using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace inheritance.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }

        // protected permite alterar na subclass. No entanto na classe principal não será permitido
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        // virtual significa que método pode ser subscrito nas subclass

        public virtual void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= (amount + 5);
            } else
            {
                Console.WriteLine($"Saldo indisponível para saque. Limite de saque {Balance}");
            }
        }

        public void Deposit(double amount)
        {

            Balance += amount;
        }

        public override string ToString()
        {
            return Number
                + (", ")
                + Holder
                + (", ")
            + Balance.ToString("F2", CultureInfo.InvariantCulture)
                + (".");
        }
    }
}
