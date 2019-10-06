using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Entities
{
    /* : Account diz que tudo que a classe account tem, 
     a classe bussinesaccount também terá */
    class BussinesAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinesAccount()
        {
        }

        // the word base posso chamar os atibutos do construtor de acc para busacc.

        public BussinesAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
        }
    }
