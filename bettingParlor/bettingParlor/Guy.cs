using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bettingParlor
{
    class Guy
    {
        public string name;
        public Bet myBet;
        public int cash;

        public RadioButton myRadButton;
        public Label myLabel;

        public void updateLabel()
        {

            myBet.bettor = new Guy();
            myBet.bettor = this;
            myLabel.Text = myBet.getDescription();
            /*if (myBet == null)
                myLabel.Text = name + " has not placed any bets";
            else
                myLabel.Text = name + " bets " + myBet.amt + " on dog #" + myBet.dog;*/
            myRadButton.Text = name + " has " + cash + " bucks";
        }

        public void clearBet()
        {
            myBet.reset();
            this.updateLabel();
        }

        public bool placeBet(int amt, int dogOnBet)
        {
            if (cash >= amt)
            {
                myBet.amt = amt;
                myBet.dog = dogOnBet;
                myBet.bettor = this;
                this.updateLabel();
                return true;
            }
            MessageBox.Show("you don't have that much money in your account. \nbet NOT placed");
            return false;
        }

        public void collect(int winner)
        {
            cash += myBet.payout(winner);
            this.updateLabel();
        }
    }
}
