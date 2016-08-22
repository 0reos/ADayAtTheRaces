using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    class Guy
    {
        public string Name; //The guy's names
        public Bet MyBet; //An instance of Bet() that has his bet
        public int Cash; //How much cash he has

        //These last two fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton;
        public Label MyLabel;


        public void UpdateLabelsButtons()
        {
            //Set my label to my bet's description, and the label on my
            //Radio button to show my cash ("Joe has $43")      
            
        }

        public void ClearBet()
        {
            //Reset my bet so it equals zero 
            //MyBet = 0;
            
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            //Place a new bet and store it in my bet field
            //Return true if the guy had enough money to bet
            return true;
        }

        //public Collect(int Winner)
        //{
        //    //Asks my bet to pay out
        //    return;
        //}

    }
}
