using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Match_Simulator
{
    class Bettor
    {

        Bet myBet = new Bet();
        
        private int _cash = 1000;

        public int Cash
        {
            get { return _cash; }
        }

        public void CreateBet(string teamtobet, int amount)
        {
            myBet.Amount = amount;
            myBet.Bettedteam = teamtobet;
            _cash = _cash - amount;

        }

        public void UpdateCashLabel(Label bettorlabel)
        {
            bettorlabel.Text = _cash.ToString();
        }

        public void CheckBet(string winningteam, string team1, string team2)
        {
            _cash = _cash + myBet.Check(winningteam, team1, team2);
            myBet.ClearBet();
        }
    
    }
}
