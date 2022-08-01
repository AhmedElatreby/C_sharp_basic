using System;

namespace ProgChallenge
{
    class SavingsAcct : Account
    {
        private int _withdrawacount = 0;
        private const decimal WITHDRAW_CHARGE = 2.0m;
        private const int WITHDRAW_LIMIT = 3;

        public SavingsAcct(string fname, string lname, decimal interest, decimal initial) : base(fname, lname, initial)
        {
            InterestRate = interest;
        }

        public decimal InterestRate { get; set; }

        public void ApplyInterest()
        {
            Balance += (Balance * InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine($"Attempt to overdraw saving - denied");

            }
            else
            {
                base.Withdraw(amount);

                _withdrawacount++;
                if (_withdrawacount > WITHDRAW_LIMIT)
                {
                    Console.WriteLine($"More than withdrawals - extra charge");
                    base.Withdraw(WITHDRAW_CHARGE);

                }
            }
        }



    }

}