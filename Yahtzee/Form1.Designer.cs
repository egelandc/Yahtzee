namespace Yahtzee
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Ones");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Twos");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Threes");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Fours");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Fives");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Sixes");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Two pairs");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Three of a kind");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("Four of a kind");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("Small straight");
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("Large straight");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("Full house");
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("Chance");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("Yahtzee");
            this.roll_dice = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.filemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dice5 = new System.Windows.Forms.PictureBox();
            this.dice4 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rollsLeftLabel = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            this.SuspendLayout();
            // 
            // roll_dice
            // 
            this.roll_dice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roll_dice.Location = new System.Drawing.Point(136, 165);
            this.roll_dice.Name = "roll_dice";
            this.roll_dice.Size = new System.Drawing.Size(174, 47);
            this.roll_dice.TabIndex = 0;
            this.roll_dice.Text = "Roll dice";
            this.roll_dice.UseVisualStyleBackColor = true;
            this.roll_dice.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filemenu});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(692, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // filemenu
            // 
            this.filemenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filemenu.Name = "filemenu";
            this.filemenu.Size = new System.Drawing.Size(50, 20);
            this.filemenu.Text = "Menu";
            this.filemenu.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // scoreView
            // 
            this.scoreView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.scoreView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreView.GridLines = true;
            this.scoreView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.scoreView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28});
            this.scoreView.Location = new System.Drawing.Point(136, 218);
            this.scoreView.MultiSelect = false;
            this.scoreView.Name = "scoreView";
            this.scoreView.Size = new System.Drawing.Size(421, 338);
            this.scoreView.TabIndex = 4;
            this.scoreView.UseCompatibleStateImageBehavior = false;
            this.scoreView.View = System.Windows.Forms.View.Details;
            this.scoreView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.scoreView_ItemSelectionChanged);
            this.scoreView.SelectedIndexChanged += new System.EventHandler(this.scoreView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 163;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Score";
            this.columnHeader2.Width = 120;
            // 
            // dice5
            // 
            this.dice5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice5.Location = new System.Drawing.Point(468, 42);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(77, 77);
            this.dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dice5.TabIndex = 5;
            this.dice5.TabStop = false;
            this.dice5.Click += new System.EventHandler(this.dice5_Click);
            // 
            // dice4
            // 
            this.dice4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice4.Location = new System.Drawing.Point(385, 42);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(77, 77);
            this.dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dice4.TabIndex = 5;
            this.dice4.TabStop = false;
            this.dice4.Click += new System.EventHandler(this.dice4_Click);
            // 
            // dice3
            // 
            this.dice3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice3.Location = new System.Drawing.Point(302, 42);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(77, 77);
            this.dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dice3.TabIndex = 5;
            this.dice3.TabStop = false;
            this.dice3.Click += new System.EventHandler(this.dice3_Click);
            // 
            // dice2
            // 
            this.dice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice2.Location = new System.Drawing.Point(219, 42);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(77, 77);
            this.dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dice2.TabIndex = 5;
            this.dice2.TabStop = false;
            this.dice2.Click += new System.EventHandler(this.dice2_Click);
            // 
            // dice1
            // 
            this.dice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice1.Location = new System.Drawing.Point(136, 42);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(77, 77);
            this.dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dice1.TabIndex = 5;
            this.dice1.TabStop = false;
            this.dice1.Click += new System.EventHandler(this.dice1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rolls left:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(374, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Place into category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // rollsLeftLabel
            // 
            this.rollsLeftLabel.AutoSize = true;
            this.rollsLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollsLeftLabel.Location = new System.Drawing.Point(222, 138);
            this.rollsLeftLabel.Name = "rollsLeftLabel";
            this.rollsLeftLabel.Size = new System.Drawing.Size(20, 24);
            this.rollsLeftLabel.TabIndex = 8;
            this.rollsLeftLabel.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 604);
            this.Controls.Add(this.rollsLeftLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.scoreView);
            this.Controls.Add(this.roll_dice);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Yahtzee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roll_dice;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem filemenu;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView scoreView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.PictureBox dice4;
        private System.Windows.Forms.PictureBox dice5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label rollsLeftLabel;
    }
}

