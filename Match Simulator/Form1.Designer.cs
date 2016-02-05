namespace Match_Simulator
{
    partial class MatchSimulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchSimulator));
            this.teamAScoreboard = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamBScoreboard = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusBox = new System.Windows.Forms.RichTextBox();
            this.teamAName = new System.Windows.Forms.Label();
            this.teamBName = new System.Windows.Forms.Label();
            this.team1Box = new System.Windows.Forms.ComboBox();
            this.team2Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.speedBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.betamount1 = new System.Windows.Forms.NumericUpDown();
            this.betamount2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bettor2button = new System.Windows.Forms.Button();
            this.bettor1button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.betteam2 = new System.Windows.Forms.ComboBox();
            this.betteam1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.betamount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamount2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamAScoreboard
            // 
            this.teamAScoreboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.teamAScoreboard.GridLines = true;
            this.teamAScoreboard.Location = new System.Drawing.Point(441, 35);
            this.teamAScoreboard.Name = "teamAScoreboard";
            this.teamAScoreboard.Size = new System.Drawing.Size(310, 114);
            this.teamAScoreboard.TabIndex = 0;
            this.teamAScoreboard.UseCompatibleStateImageBehavior = false;
            this.teamAScoreboard.View = System.Windows.Forms.View.Details;
            this.teamAScoreboard.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.teamAScoreboard_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Player";
            this.columnHeader1.Width = 185;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kills";
            this.columnHeader2.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Deaths";
            // 
            // teamBScoreboard
            // 
            this.teamBScoreboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.teamBScoreboard.GridLines = true;
            this.teamBScoreboard.Location = new System.Drawing.Point(441, 190);
            this.teamBScoreboard.Name = "teamBScoreboard";
            this.teamBScoreboard.Size = new System.Drawing.Size(310, 114);
            this.teamBScoreboard.TabIndex = 1;
            this.teamBScoreboard.UseCompatibleStateImageBehavior = false;
            this.teamBScoreboard.View = System.Windows.Forms.View.Details;
            this.teamBScoreboard.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.teamBScoreboard_ColumnClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Player";
            this.columnHeader5.Width = 186;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kills";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Deaths";
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.White;
            this.statusBox.Enabled = false;
            this.statusBox.Location = new System.Drawing.Point(12, 12);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(423, 292);
            this.statusBox.TabIndex = 2;
            this.statusBox.Text = "";
            // 
            // teamAName
            // 
            this.teamAName.AutoSize = true;
            this.teamAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamAName.Location = new System.Drawing.Point(441, 10);
            this.teamAName.MaximumSize = new System.Drawing.Size(310, 0);
            this.teamAName.MinimumSize = new System.Drawing.Size(310, 0);
            this.teamAName.Name = "teamAName";
            this.teamAName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.teamAName.Size = new System.Drawing.Size(310, 20);
            this.teamAName.TabIndex = 3;
            this.teamAName.Text = "Team A";
            this.teamAName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamBName
            // 
            this.teamBName.AutoSize = true;
            this.teamBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamBName.Location = new System.Drawing.Point(441, 167);
            this.teamBName.MaximumSize = new System.Drawing.Size(310, 0);
            this.teamBName.MinimumSize = new System.Drawing.Size(310, 0);
            this.teamBName.Name = "teamBName";
            this.teamBName.Size = new System.Drawing.Size(310, 20);
            this.teamBName.TabIndex = 4;
            this.teamBName.Text = "Team B";
            this.teamBName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1Box
            // 
            this.team1Box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.team1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.team1Box.FormattingEnabled = true;
            this.team1Box.Items.AddRange(new object[] {
            "NiP",
            "Virtus Pro",
            "fnatic",
            "TSM"});
            this.team1Box.Location = new System.Drawing.Point(12, 370);
            this.team1Box.Name = "team1Box";
            this.team1Box.Size = new System.Drawing.Size(121, 21);
            this.team1Box.TabIndex = 6;
            // 
            // team2Box
            // 
            this.team2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.team2Box.FormattingEnabled = true;
            this.team2Box.Items.AddRange(new object[] {
            "NiP",
            "Virtus Pro",
            "fnatic",
            "TSM"});
            this.team2Box.Location = new System.Drawing.Point(12, 397);
            this.team2Box.Name = "team2Box";
            this.team2Box.Size = new System.Drawing.Size(121, 21);
            this.team2Box.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wybierz 2 teamy";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(58, 465);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(139, 48);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // speedBox
            // 
            this.speedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedBox.FormattingEnabled = true;
            this.speedBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "100"});
            this.speedBox.Location = new System.Drawing.Point(139, 370);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(121, 21);
            this.speedBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wybierz prędkość";
            // 
            // betamount1
            // 
            this.betamount1.Location = new System.Drawing.Point(114, 55);
            this.betamount1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.betamount1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betamount1.Name = "betamount1";
            this.betamount1.Size = new System.Drawing.Size(80, 20);
            this.betamount1.TabIndex = 12;
            this.betamount1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betamount2
            // 
            this.betamount2.Location = new System.Drawing.Point(113, 122);
            this.betamount2.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.betamount2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betamount2.Name = "betamount2";
            this.betamount2.Size = new System.Drawing.Size(80, 20);
            this.betamount2.TabIndex = 13;
            this.betamount2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bettor2button);
            this.groupBox1.Controls.Add(this.bettor1button);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.betteam2);
            this.groupBox1.Controls.Add(this.betteam1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.betamount1);
            this.groupBox1.Controls.Add(this.betamount2);
            this.groupBox1.Location = new System.Drawing.Point(287, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 171);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bukmacher";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "1000";
            // 
            // bettor2button
            // 
            this.bettor2button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bettor2button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bettor2button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bettor2button.Location = new System.Drawing.Point(372, 122);
            this.bettor2button.Name = "bettor2button";
            this.bettor2button.Size = new System.Drawing.Size(59, 23);
            this.bettor2button.TabIndex = 22;
            this.bettor2button.Text = "OK";
            this.bettor2button.UseVisualStyleBackColor = false;
            this.bettor2button.Click += new System.EventHandler(this.bettor2button_Click);
            // 
            // bettor1button
            // 
            this.bettor1button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bettor1button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bettor1button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bettor1button.Location = new System.Drawing.Point(372, 55);
            this.bettor1button.Name = "bettor1button";
            this.bettor1button.Size = new System.Drawing.Size(59, 23);
            this.bettor1button.TabIndex = 15;
            this.bettor1button.Text = "OK";
            this.bettor1button.UseVisualStyleBackColor = false;
            this.bettor1button.Click += new System.EventHandler(this.bettor1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Team:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Team:";
            // 
            // betteam2
            // 
            this.betteam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.betteam2.FormattingEnabled = true;
            this.betteam2.Items.AddRange(new object[] {
            "NiP",
            "Virtus Pro",
            "fnatic",
            "TSM"});
            this.betteam2.Location = new System.Drawing.Point(245, 122);
            this.betteam2.Name = "betteam2";
            this.betteam2.Size = new System.Drawing.Size(121, 21);
            this.betteam2.TabIndex = 19;
            // 
            // betteam1
            // 
            this.betteam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.betteam1.FormattingEnabled = true;
            this.betteam1.Items.AddRange(new object[] {
            "NiP",
            "Virtus Pro",
            "fnatic",
            "TSM"});
            this.betteam1.Location = new System.Drawing.Point(245, 55);
            this.betteam1.Name = "betteam1";
            this.betteam1.Size = new System.Drawing.Size(121, 21);
            this.betteam1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kwota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kwota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gracz 2 kasa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gracz 1 kasa: ";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetButton.Enabled = false;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetButton.Location = new System.Drawing.Point(58, 465);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(139, 48);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset!";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // MatchSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(759, 552);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.team2Box);
            this.Controls.Add(this.team1Box);
            this.Controls.Add(this.teamBName);
            this.Controls.Add(this.teamAName);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.teamBScoreboard);
            this.Controls.Add(this.teamAScoreboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatchSimulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symulator Meczu";
            ((System.ComponentModel.ISupportInitialize)(this.betamount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamount2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView teamAScoreboard;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView teamBScoreboard;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.RichTextBox statusBox;
        private System.Windows.Forms.Label teamAName;
        private System.Windows.Forms.Label teamBName;
        private System.Windows.Forms.ComboBox team1Box;
        private System.Windows.Forms.ComboBox team2Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox speedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown betamount1;
        private System.Windows.Forms.NumericUpDown betamount2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bettor2button;
        private System.Windows.Forms.Button bettor1button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox betteam2;
        private System.Windows.Forms.ComboBox betteam1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetButton;







    }
}

