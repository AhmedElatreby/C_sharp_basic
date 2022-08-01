using System;

namespace ProgChallenge
{
    class Account : Customer
    {
        protected decimal Deposit { get; set; }
        protected decimal Withdrawal { get; set; }
        public Account(string FName, string LName, decimal Deposit, decimal Withdraw) : base(FName, LName)
        {


        }

        public decimal Balance()
        {
            return Deposit - Withdrawal;
        }



    }

}