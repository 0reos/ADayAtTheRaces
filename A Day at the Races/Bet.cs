﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Day_at_the_Races
{
    class Bet
    {
        public int Amount; //The amount of cash that was bet
        public int Dog; //The number of the dog the bet is on
        public Guy Bettor; //The guy who placed the bet

        public string GetDecription()
        {
            //Return a string that says who placed the bet, how much cash was bet, and which dog he bet on("Joe bets 8 on dog #4).
            //If the amount is zero, no bet was placed ("Joe hasn't placed a bet").

            if (Amount != 0)
            {
                return (Bettor + " bets " + Amount + " on " + Dog);
            }
            else 
            {
                return (Bettor +  " hasn't placed a bet yet");
            }
        }

        public int Payout(int Winner)
        {
            //The parameter is the winner of the race. If the dog won, return the amount bet. 
            //Otherwise, return the negative of the amount bet
            //if (b)
            //{
                
            //}
            return Winner;
        }

    }
}
