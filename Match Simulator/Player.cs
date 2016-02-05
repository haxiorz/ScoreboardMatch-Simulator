using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Match_Simulator
{
    class Player
    {
        private readonly string _playername;
        private int _kills = 0;
        private int _deaths = 0;
        private bool _alive = true;


        public Player(string name)
        {
            _playername = name;
        }

        public string Playername
        {
            get { return _playername; }
        }

        public string Kills
        {
            get { return _kills.ToString(); }
        }

        public string Deaths
        {
            get { return _deaths.ToString(); }
        }

        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }

        public void AddKills()
        {
            _kills++;
        }

        public void AddDeaths()
        {
            _deaths++;
        }

        
    }
}
