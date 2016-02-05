using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Match_Simulator
{
    class Game
    {
        private int _timercount = 1;
        private int _roundsplayed = 0;

        List<Team> teams = new List<Team>();
        Random random = new Random();

        

        public void AddTeams(string team1Name, string team2Name, Label team1Label, Label team2Label, ListView team1Scoreboard, ListView team2Scoreboard, Timer timer, Button startbutton, ComboBox speed, Button resetButton)
        {
            if (team1Name == team2Name)
            {
                MessageBox.Show("Wybierz dwie różne drużyny!", "Błąd!");
            }
            if (team1Name == "" || team2Name == "")
            {
                MessageBox.Show("Nie wybrałeś jednej z drużyn!", "Błąd!");
            }
            else
            {
                try
                {
                    timer.Interval = 1000 / int.Parse(speed.Text);
                    timer.Enabled = true;
                    startbutton.Visible = false;
                    startbutton.Enabled = false;
                    resetButton.Visible = true;
                    resetButton.Enabled = false;
                    teams.Add(new Team(team1Name, team1Label, team1Scoreboard));
                    teams.Add(new Team(team2Name, team2Label, team2Scoreboard));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nie wybrałeś prędkości!", "Błąd!");
                }
            }
        }

        public void UpdateScoreboards(Label team1Label, Label team2Label, ListView team1Scoreboard, ListView team2Scoreboard)
        {
            teams[0].UpdateTeamScoreboard(team1Label, team1Scoreboard);
            teams[1].UpdateTeamScoreboard(team2Label, team2Scoreboard);
        }

        private void RoundWin(Team winningteam, RichTextBox status)
        {
            winningteam.AddTeamScore();
            status.AppendText(Environment.NewLine + "Drużyna " + winningteam.Teamname + " wygrała rundę");
            _roundsplayed++;
            foreach (var team in teams)
            {
                team.RevivePlayers();
            }

        }

        public void PickPlayer(Team killer, Team victim, RichTextBox status)
        {
            
            status.AppendText(Environment.NewLine + killer.PickPlayerToKill() + " zabił gracza " + victim.PickPlayerToDie());
            victim.MinusPlayersAlive();
        }

        private void CheckRoundStatus(RichTextBox status)
        {
            if (teams[0].Playersalive == 0)
            {
                RoundWin(teams[1], status);
            }
            if (teams[1].Playersalive == 0)
            {
                RoundWin(teams[0], status);
            }
        }

        public void Action(RichTextBox status)
        {
            
            {
                int teamtokill = random.Next(0, 2);
                if (teamtokill == 0)
                {
                    PickPlayer(teams[0], teams[1], status);
                    
                }

                if (teamtokill == 1)
                {
                    PickPlayer(teams[1], teams[0], status);
                }
                CheckRoundStatus(status);
            }
        }


        public void CheckScore(Timer timer, RichTextBox status, Bettor bettor1, Bettor bettor2, Label bettor1label, Label bettor2label, Button resetButton)
        {
            _timercount++;
            if (_roundsplayed == 30 && teams[0].Score != 16 && teams[1].Score != 16)
            {
                timer.Enabled = false;
                MessageBox.Show("Remis !");
                bettor1.CheckBet("draw", teams[0].Teamname, teams[1].Teamname);
                bettor2.CheckBet("draw", teams[0].Teamname, teams[1].Teamname);
                GetCashAmounts(bettor1label, bettor2label, bettor1, bettor2);
                resetButton.Enabled = true;
                
            }
            else
            {
                if (teams[0].Score == 16)
                {
                    timer.Enabled = false;
                    MessageBox.Show("Drużyna " + teams[0].Teamname + " wygrała mecz!");
                    bettor1.CheckBet(teams[0].Teamname, teams[0].Teamname, teams[1].Teamname);
                    bettor2.CheckBet(teams[0].Teamname, teams[0].Teamname, teams[1].Teamname);
                    GetCashAmounts(bettor1label, bettor2label, bettor1, bettor2);
                    resetButton.Enabled = true;
                }
                else if (teams[1].Score == 16)
                {
                    timer.Enabled = false;
                    MessageBox.Show("Drużyna " + teams[1].Teamname + " wygrała mecz!");
                    bettor1.CheckBet(teams[1].Teamname, teams[0].Teamname, teams[1].Teamname);
                    bettor2.CheckBet(teams[1].Teamname, teams[0].Teamname, teams[1].Teamname);
                    GetCashAmounts(bettor1label, bettor2label, bettor1, bettor2);
                    resetButton.Enabled = true;
                }
                else
                {
                    Action(status);
                }

            }
            
        }

        public void GetCashAmounts(Label bettor1Label, Label bettor2Label, Bettor bettor1, Bettor bettor2)
        {
            bettor1.UpdateCashLabel(bettor1Label);
            bettor2.UpdateCashLabel(bettor2Label);
        }

        public void CheckStatusField(RichTextBox statusbox)
        {
            if (_timercount % 17 == 1)
            {
                statusbox.ResetText();
            }
        }

        public void CreateBet(string teamtobet, int betamount, Bettor bettor)
        {
            if (bettor.Cash >= betamount)
            {
                bettor.CreateBet(teamtobet, betamount);
            }
            else
            {
                MessageBox.Show("Gracz ma zbyt mało środków!");
            }
        }

        public void ResetGame(Button startButton, Button resetButton, ListView teamAScoreboard, ListView teamBScoreboard, Label teamALabel, Label teamBLabel)
        {
            teams.Clear();
            startButton.Visible = true;
            startButton.Enabled = true;
            resetButton.Enabled = false;
            resetButton.Visible = false;
            teamAScoreboard.Items.Clear();
            teamBScoreboard.Items.Clear();
            teamALabel.Text = "Team A";
            teamBLabel.Text = "Team B";
            _roundsplayed = 0;
        }

    }
}
