namespace bettingParlor
{
    partial class gameGrid
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
            this.parlorBox = new System.Windows.Forms.GroupBox();
            this.alLabel = new System.Windows.Forms.Label();
            this.bobLabel = new System.Windows.Forms.Label();
            this.joeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.dogBets = new System.Windows.Forms.NumericUpDown();
            this.statusLabel2 = new System.Windows.Forms.Label();
            this.bucksBet = new System.Windows.Forms.NumericUpDown();
            this.placeBets = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.alButton = new System.Windows.Forms.RadioButton();
            this.bobButton = new System.Windows.Forms.RadioButton();
            this.joeButton = new System.Windows.Forms.RadioButton();
            this.minBetNote = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.parlorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // parlorBox
            // 
            this.parlorBox.Controls.Add(this.alLabel);
            this.parlorBox.Controls.Add(this.bobLabel);
            this.parlorBox.Controls.Add(this.joeLabel);
            this.parlorBox.Controls.Add(this.startButton);
            this.parlorBox.Controls.Add(this.dogBets);
            this.parlorBox.Controls.Add(this.statusLabel2);
            this.parlorBox.Controls.Add(this.bucksBet);
            this.parlorBox.Controls.Add(this.placeBets);
            this.parlorBox.Controls.Add(this.statusLabel);
            this.parlorBox.Controls.Add(this.alButton);
            this.parlorBox.Controls.Add(this.bobButton);
            this.parlorBox.Controls.Add(this.joeButton);
            this.parlorBox.Controls.Add(this.minBetNote);
            this.parlorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parlorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parlorBox.Location = new System.Drawing.Point(0, 312);
            this.parlorBox.Name = "parlorBox";
            this.parlorBox.Size = new System.Drawing.Size(1153, 313);
            this.parlorBox.TabIndex = 1;
            this.parlorBox.TabStop = false;
            this.parlorBox.Text = "Betting parlor";
            // 
            // alLabel
            // 
            this.alLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alLabel.Location = new System.Drawing.Point(248, 123);
            this.alLabel.Name = "alLabel";
            this.alLabel.Size = new System.Drawing.Size(225, 23);
            this.alLabel.TabIndex = 12;
            this.alLabel.Text = "label1";
            // 
            // bobLabel
            // 
            this.bobLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobLabel.Location = new System.Drawing.Point(248, 99);
            this.bobLabel.Name = "bobLabel";
            this.bobLabel.Size = new System.Drawing.Size(225, 23);
            this.bobLabel.TabIndex = 11;
            this.bobLabel.Text = "label1";
            // 
            // joeLabel
            // 
            this.joeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeLabel.Location = new System.Drawing.Point(248, 75);
            this.joeLabel.Name = "joeLabel";
            this.joeLabel.Size = new System.Drawing.Size(225, 23);
            this.joeLabel.TabIndex = 10;
            this.joeLabel.Text = "label1";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(758, 75);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(189, 155);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Let\'s go for it ! ";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dogBets
            // 
            this.dogBets.Location = new System.Drawing.Point(420, 202);
            this.dogBets.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogBets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogBets.Name = "dogBets";
            this.dogBets.Size = new System.Drawing.Size(49, 29);
            this.dogBets.TabIndex = 8;
            this.dogBets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // statusLabel2
            // 
            this.statusLabel2.AutoSize = true;
            this.statusLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel2.Location = new System.Drawing.Point(245, 202);
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(156, 18);
            this.statusLabel2.TabIndex = 7;
            this.statusLabel2.Text = "bucks on dog number ";
            // 
            // bucksBet
            // 
            this.bucksBet.Location = new System.Drawing.Point(170, 199);
            this.bucksBet.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.bucksBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bucksBet.Name = "bucksBet";
            this.bucksBet.Size = new System.Drawing.Size(46, 29);
            this.bucksBet.TabIndex = 6;
            this.bucksBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // placeBets
            // 
            this.placeBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeBets.Location = new System.Drawing.Point(67, 196);
            this.placeBets.Name = "placeBets";
            this.placeBets.Size = new System.Drawing.Size(67, 34);
            this.placeBets.TabIndex = 5;
            this.placeBets.Text = "bets";
            this.placeBets.UseVisualStyleBackColor = true;
            this.placeBets.Click += new System.EventHandler(this.placeBets_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(16, 202);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(45, 18);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "name";
            // 
            // alButton
            // 
            this.alButton.AutoSize = true;
            this.alButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alButton.Location = new System.Drawing.Point(16, 123);
            this.alButton.Name = "alButton";
            this.alButton.Size = new System.Drawing.Size(75, 20);
            this.alButton.TabIndex = 3;
            this.alButton.Text = "al status";
            this.alButton.UseVisualStyleBackColor = true;
            this.alButton.CheckedChanged += new System.EventHandler(this.alButton_CheckedChanged);
            // 
            // bobButton
            // 
            this.bobButton.AutoSize = true;
            this.bobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobButton.Location = new System.Drawing.Point(16, 99);
            this.bobButton.Name = "bobButton";
            this.bobButton.Size = new System.Drawing.Size(88, 20);
            this.bobButton.TabIndex = 2;
            this.bobButton.Text = "bob status";
            this.bobButton.UseVisualStyleBackColor = true;
            this.bobButton.CheckedChanged += new System.EventHandler(this.bobButton_CheckedChanged);
            // 
            // joeButton
            // 
            this.joeButton.AutoSize = true;
            this.joeButton.Checked = true;
            this.joeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeButton.Location = new System.Drawing.Point(16, 75);
            this.joeButton.Name = "joeButton";
            this.joeButton.Size = new System.Drawing.Size(83, 20);
            this.joeButton.TabIndex = 1;
            this.joeButton.TabStop = true;
            this.joeButton.Text = "joe status";
            this.joeButton.UseVisualStyleBackColor = true;
            this.joeButton.CheckedChanged += new System.EventHandler(this.joeButton_CheckedChanged);
            // 
            // minBetNote
            // 
            this.minBetNote.AutoSize = true;
            this.minBetNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBetNote.Location = new System.Drawing.Point(12, 29);
            this.minBetNote.Name = "minBetNote";
            this.minBetNote.Size = new System.Drawing.Size(204, 22);
            this.minBetNote.TabIndex = 0;
            this.minBetNote.Text = "Minimum Bet: 5 bucks";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::bettingParlor.Properties.Resources.dog;
            this.pictureBox4.Location = new System.Drawing.Point(19, 256);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 30);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::bettingParlor.Properties.Resources.dog;
            this.pictureBox3.Location = new System.Drawing.Point(19, 172);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 29);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::bettingParlor.Properties.Resources.dog;
            this.pictureBox2.Location = new System.Drawing.Point(19, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 34);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bettingParlor.Properties.Resources.dog;
            this.pictureBox1.InitialImage = global::bettingParlor.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // racetrack
            // 
            this.racetrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.racetrack.Image = global::bettingParlor.Properties.Resources.racetrack;
            this.racetrack.Location = new System.Drawing.Point(0, 0);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1153, 312);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // gameGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 625);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.parlorBox);
            this.Controls.Add(this.racetrack);
            this.MaximizeBox = false;
            this.Name = "gameGrid";
            this.Text = "The Betting Parlor, Try your luck !";
            this.parlorBox.ResumeLayout(false);
            this.parlorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.GroupBox parlorBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown dogBets;
        private System.Windows.Forms.Label statusLabel2;
        private System.Windows.Forms.NumericUpDown bucksBet;
        private System.Windows.Forms.Button placeBets;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.RadioButton alButton;
        private System.Windows.Forms.RadioButton bobButton;
        private System.Windows.Forms.RadioButton joeButton;
        private System.Windows.Forms.Label minBetNote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label alLabel;
        private System.Windows.Forms.Label bobLabel;
        private System.Windows.Forms.Label joeLabel;
    }
}

