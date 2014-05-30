using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bettingParlor
{
    public partial class gameGrid : Form
    {
        Random myRandomizer = new Random();
        Greyhound[] greyHoundArray = new Greyhound[4];
        Guy[] GuyArray = new Guy[3];
        int winner = 0;
        public gameGrid()
        {
            InitializeComponent();
            Bet b = new Bet();
            b.bettor = new Guy();
            greyHoundArray[0] = new Greyhound()
            {
                myPicBox = pictureBox1,
                startPos = pictureBox1.Left,
                raceTrackLen = racetrack.Width - pictureBox1.Width,
                randomizer = myRandomizer
            };
            greyHoundArray[1] = new Greyhound()
            {
                myPicBox = pictureBox2,
                startPos = pictureBox2.Left,
                raceTrackLen = racetrack.Width - pictureBox2.Width,
                randomizer = myRandomizer
            };
            greyHoundArray[2] = new Greyhound()
            {
                myPicBox = pictureBox3,
                startPos = pictureBox3.Left,
                raceTrackLen = racetrack.Width - pictureBox3.Width,
                randomizer = myRandomizer
            };
            greyHoundArray[3] = new Greyhound()
            {
                myPicBox = pictureBox4,
                startPos = pictureBox4.Left,
                raceTrackLen = racetrack.Width - pictureBox4.Width,
                randomizer = myRandomizer
            };

            GuyArray[0] = new Guy()
            {
                name = "Joe",
                cash = 50,
                myBet = new Bet(),
                myRadButton = joeButton,
                myLabel = joeLabel
            };
            GuyArray[1] = new Guy()
            {
                name = "Bob",
                cash = 75,
                myBet = new Bet(),
                myRadButton = bobButton,
                myLabel = bobLabel,
            };
            GuyArray[2] = new Guy()
            {
                name = "Al",
                cash = 45,
                myBet = new Bet(),
                myRadButton = alButton,
                myLabel = alLabel
            };

            GuyArray[0].updateLabel();
            GuyArray[1].updateLabel();
            GuyArray[2].updateLabel();
            statusLabel.Text = GuyArray[whoIsChecked()].name;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            parlorBox.Enabled = false;
            winner = 0;
            for (int j = 0; j < 4; j++)
            {
                greyHoundArray[j].takeStartPos();
            }
            while(winner == 0)
            {
                Application.DoEvents();
                for (int i = 0; i < 4; i++)
                {
                    System.Threading.Thread.Sleep(10);
                    if (greyHoundArray[i].run())
                    {
                        parlorBox.Enabled = true;
                        winner = i + 1;
                        MessageBox.Show("winner is dog : " + winner);
                        break;
                    }
                }
            }
            for (int a = 0; a < 3; a++)
            {
                GuyArray[a].collect(winner);
                GuyArray[a].clearBet();
            }
        }
        private int whoIsChecked()
        {
            if (joeButton.Checked)
                return 0;
            else if (bobButton.Checked)
                return 1;
            else
                return 2;
                
        }

        private void placeBets_Click(object sender, EventArgs e)
        {
                       GuyArray[whoIsChecked()].placeBet((int)bucksBet.Value, (int)dogBets.Value);

        }

        private void joeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (joeButton.Checked)
                statusLabel.Text = GuyArray[0].name;
        }

        private void bobButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bobButton.Checked)
                statusLabel.Text = GuyArray[1].name;
        }

        private void alButton_CheckedChanged(object sender, EventArgs e)
        {
            if (alButton.Checked)
                statusLabel.Text = GuyArray[2].name;
        }

       

    }
}
