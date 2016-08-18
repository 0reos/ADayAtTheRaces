using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public partial class Form1 : Form
    {
       // Greyhound myGreyhound = new Greyhound();
       Greyhound[] dog = new Greyhound[4];
        Guy[] men = new Guy[3];

        public Form1()
        {
            InitializeComponent();
            Load();
            //AllRadioBtns();
        }
        
        public void Load()
        {
           dog[0] = new Greyhound() {Name = "Kappa", MyPictureBox = Pb1};
           dog[1] = new Greyhound() {Name = "KappaPride", MyPictureBox = Pb2};
           dog[2] = new Greyhound() {Name = "KappaSwag", MyPictureBox = Pb3};
           dog[3] = new Greyhound() {Name = "GoldenKappa", MyPictureBox = Pb4};

           men[0] = new Guy() {Name = "Joe"};
           men[1] = new Guy() {Name = "Bob"};
           men[2] = new Guy() {Name = "Al"};

        }
        
        private void btnRace_Click(object sender, EventArgs e)
        {
           //Checking random number generator on a label
           //  myGreyhound.RandomNumber();
           //  lbMaxbet.Text = myGreyhound.distance.ToString();

           bool end = false;
            while (end == false)
            {

                for (int i = 0; i < 4; i++)
                {
                    dog[i].MyPictureBox.Top += dog[i].RandomNumber();
                    
                    System.Threading.Thread.Sleep(20);
                    
                    //Stopping the race at the finish line
                    if (dog[i].MyPictureBox.Top > 400)
                    {
                        end = true;
                        //Display the winner and there winnings or someting like that through a dialog box
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Puts images back into the starting position
            for (int i = 0; i < 4; i++)
            {
                dog[i].MyPictureBox.Top = 3;
            }
        }

        private void btnPlaceBet_Click(object sender, EventArgs e)
        {

        }

        
        private void AllRadioBtns(object sender, EventArgs e)
        {

            RadioButton FakeRB = (RadioButton) sender;

            //Making the radiobuttons change the text of the place bet button.
            if (FakeRB.Checked == true)

                switch (FakeRB.Name)
                {

                    case "RbJoe":

                        btnPlaceBet.Text = "Place bet for Joe";

                        break;

                    case "RbBob":

                        btnPlaceBet.Text = "Place bet for Bob";

                        break;
                    case "RbAl":

                        btnPlaceBet.Text = "Place bet for AL";

                        break;
                }
        }
    }
}
