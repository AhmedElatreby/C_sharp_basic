using System;

namespace ProgChallenge
{
    class CheckingAcct : Account
    {
        private const decimal OVERDRAW_CHARGE = 20.0m;
        public CheckingAcct(string fname, string lname, decimal initial) : base(fname, lname, initial)
        {

        }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                amount += OVERDRAW_CHARGE;
            }
            base.Withdraw(amount);

        }




    }

}