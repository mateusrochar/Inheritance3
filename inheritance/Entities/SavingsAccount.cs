using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Entities
{

    // sealed class imped que saving accout seja herdada, ou seja, tenha subclass
    sealed class SavingsAccount : Account
    {

        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        /*public override void Withdraw(double amount)
        {
            Balance -= amount;
        } */

            // palavra base. chama o metodo da superclasse.
            // sealed metódo impede que método receba override em uma subclass. - só serve para metodos override
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }




    }
}
