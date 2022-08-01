using System;

namespace ProgChallenge
{
    class CheckingAcct : Account
    {
        public CheckingAcct(string FName, string LName, decimal Deposit, decimal Withdraw) : base(FName, LName, Deposit, Withdraw)
        {

        }

        public void Withdraw(decimal withdraw, decimal balance)
        {
            withdraw = balance - withdraw;

        }




    }

}