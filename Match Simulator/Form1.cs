using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Match_Simulator
{
    public partial class MatchSimulator : Form
    {
        public MatchSimulator()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.teamAScoreboard.ListViewItemSorter = lvwColumnSorter;
            this.teamBScoreboard.ListViewItemSorter = lvwColumnSorter;
        }

        Game game = new Game();
        Bettor bettor1 = new Bettor();
        Bettor bettor2 = new Bettor();
        private ListViewColumnSorter lvwColumnSorter;

        private void startButton_Click(object sender, EventArgs e)
        {
            game.AddTeams(team1Box.Text, team2Box.Text, teamAName, teamBName, teamAScoreboard, teamBScoreboard, timer, startButton, speedBox, resetButton);
            bettor1.UpdateCashLabel(label7);
            bettor2.UpdateCashLabel(label10);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            game.CheckStatusField(statusBox);
            game.CheckScore(timer, statusBox, bettor1, bettor2, label7, label10, resetButton);
            game.UpdateScoreboards(teamAName, teamBName, teamAScoreboard, teamBScoreboard);

        }

        private void bettor1_Click(object sender, EventArgs e)
        {
            if (betteam1.Text != "")
            {
                game.CreateBet(betteam1.Text, (int)betamount1.Value, bettor1);
                bettor1button.Enabled = false;
            }
            else
            {
                MessageBox.Show("Nie wybrałeś drużyny!", "Błąd!");
            }
            
        }

        private void bettor2button_Click(object sender, EventArgs e)
        {
            if (betteam2.Text != "")
            {
                game.CreateBet(betteam2.Text, (int)betamount2.Value, bettor2);
                bettor2button.Enabled = false;
            }
            else
            {
                MessageBox.Show("Nie wybrałeś drużyny!", "Błąd!");
            }
        }

        private void teamAScoreboard_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.teamAScoreboard.Sort();
        }

        private void teamBScoreboard_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.teamBScoreboard.Sort();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            game.ResetGame(startButton, resetButton, teamAScoreboard, teamBScoreboard, teamAName, teamBName);
            statusBox.ResetText();
            bettor1button.Enabled = true;
            bettor2button.Enabled = true;
            
        }

        
        
        
    }
}
