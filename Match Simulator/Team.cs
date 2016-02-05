using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Match_Simulator
{
    class Team
    {
        private int _score = 0;
        private int _playersalive = 5;

        List<Player> players = new List<Player>();
        List<ListViewItem> items = new List<ListViewItem>();
        Random random = new Random();

     

        public Team(string name, Label teamlabel, ListView scoreboard)
        {
            Teamname = name;
            if (name == "Virtus Pro")
            {
                players.Add(new Player("TaZ"));
                players.Add(new Player("neo"));
                players.Add(new Player("snax"));
                players.Add(new Player("pasha"));
                players.Add(new Player("byali"));

            }
            if (name == "NiP")
            {
                players.Add(new Player("GeT_RiGhT"));
                players.Add(new Player("f0rest"));
                players.Add(new Player("allu"));
                players.Add(new Player("friberg"));
                players.Add(new Player("Xizt"));
            }
            if (name == "TSM")
            {
                players.Add(new Player("karrigan"));
                players.Add(new Player("device"));
                players.Add(new Player("dupreeh"));
                players.Add(new Player("xyp9x"));
                players.Add(new Player("cajunb"));

            }
            if (name == "fnatic")
            {
                players.Add(new Player("pronax"));
                players.Add(new Player("flusha"));
                players.Add(new Player("olofmeister"));
                players.Add(new Player("KRiMZ"));
                players.Add(new Player("JW"));

            }
            for (int i = 0; i < 5; i++)
            {
                items.Add(new ListViewItem(players[i].Playername));
                items[i].SubItems.Add("0");
                items[i].SubItems.Add("0");
                scoreboard.Items.Add(items[i]);
            }

        }

        public void UpdateTeamScoreboard(Label teamlabel, ListView scoreboard)
        {
            for (int i = 0; i < 5; i++)
            {
                items[i].Text = players[i].Playername;
                items[i].SubItems[1].Text = players[i].Kills;
                items[i].SubItems[2].Text = players[i].Deaths;
            }
            teamlabel.Text = Teamname + ": " + _score;
        }

        public int PickPlayer()
        {
            int player = random.Next(0, 5);
            while (players[player].Alive == false)
            {
                player = random.Next(0, 5);
            }
            return player;
        }

        public string PickPlayerToKill()
        {
            int pickedplayer = PickPlayer();
            players[pickedplayer].AddKills();
            return players[pickedplayer].Playername;
        }
        public string PickPlayerToDie()
        {
            int pickedplayer = PickPlayer();
            players[pickedplayer].AddDeaths();
            players[pickedplayer].Alive = false;
            return players[pickedplayer].Playername;
        }

        public void RevivePlayers()
        {
            foreach (var player in players)
            {
                player.Alive = true;
            }
            _playersalive = 5;
        }


        public string Teamname { get; set; }


        public int Score
        {
            get { return _score; }
        }

        public void AddTeamScore()
        {
            _score++;
        }

        public void ResetTeamScore()
        {
            _score = 0;
        }

        public int Playersalive
        {
            get { return _playersalive; }
        }

        public void MinusPlayersAlive()
        {
            _playersalive--;
        }

       
    }
}
