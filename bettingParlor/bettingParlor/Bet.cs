using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingParlor
{
    class Bet
    {
        public int amt;
        public int dog;
        public Guy bettor;

        public string getDescription()
        {
            if (this.amt != 0)
                return this.bettor.name + " bets " + this.amt + " on dog #" + this.dog;

            else
                return this.bettor.name + " hasn't placed a bet";
        }

        public int payout(int winner)
        {
            if (winner == this.dog)
            {
                //this.reset();
                bettor.updateLabel();
                return this.amt;
            }
            else
            {
                //this.reset();
                bettor.updateLabel();
                return -this.amt;
            }

           
        }

        public void reset()
        {
            this.amt = 0;
            this.dog = 0;
        }
    }
}
