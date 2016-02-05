using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Match_Simulator
{
    class Bet
    {
        private int _amount = 0;
        private static int multiplier = 2;
        private string _bettedteam = "";


        public string Bettedteam
        {
            set { _bettedteam = value; }
        }

        public int Amount
        {
            set { _amount = value; }
        }

        public int Check(string winningteam, string team1, string team2)
        {
            if (_bettedteam == winningteam)
            {
                return _amount * multiplier;
            }
            else if (winningteam == "draw")
            {
                return _amount;
            }
            else if (_bettedteam != winningteam && (_bettedteam == team1 || _bettedteam == team2))
            {
                return 0;
            }
            else if (_bettedteam != team1 && _bettedteam != team2 && _bettedteam != "")
            {
                MessageBox.Show("Gracz obstawił drużynę która nie grała, zwrot środków!");
                return _amount;
            }
            else
            {
                return _amount;
            }

        }

        public void ClearBet()
        {
            _bettedteam = "";
            _amount = 0;
        }


    }
}
