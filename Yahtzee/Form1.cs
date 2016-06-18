using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        YahtzeeScorer yahtzee;
        YahtzeeScorerTests yahtzeeTest;
        ListViewItem categoryListViewItem;

        List<Bitmap> images = new List<Bitmap>();

        public Form1()
        {
            InitializeComponent();
            //Instantiate the YathzeeScorer
            yahtzee = new YahtzeeScorer();
            yahtzeeTest = new YahtzeeScorerTests();

            //Run tests
            yahtzeeTest.test();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            yahtzee.shuffleAll();
            yahtzee.holdDice = new bool[5];
            rollsLeftLabel.Text = yahtzee.rollsLeft.ToString();
            if (yahtzee.rollsLeft == 0)
            {
                button1.Enabled = false;
            }
            this.scoreView.SelectedItems.Clear();
            update_dice();
        }

        private void update_dice()
        {
            int[] values = Array.ConvertAll(yahtzee.roll.Split(','), s => int.Parse(s));
            this.dice1.Image = images[values[0]-1];
            this.dice2.Image = images[values[1]-1];
            this.dice3.Image = images[values[2]-1];
            this.dice4.Image = images[values[3]-1];
            this.dice5.Image = images[values[4]-1];
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //Add score subitem for each catagory in the listview
            foreach (ListViewItem itemRow in this.scoreView.Items)
            {
                itemRow.SubItems.Add("");
            }

            //Add dice drawings
            images.Add(global::Yahtzee.Properties.Resources.one);
            images.Add(global::Yahtzee.Properties.Resources.two);
            images.Add(global::Yahtzee.Properties.Resources.three);
            images.Add(global::Yahtzee.Properties.Resources.four);
            images.Add(global::Yahtzee.Properties.Resources.five);
            images.Add(global::Yahtzee.Properties.Resources.six);

            images.Add(global::Yahtzee.Properties.Resources.one_);
            images.Add(global::Yahtzee.Properties.Resources.two_);
            images.Add(global::Yahtzee.Properties.Resources.three_);
            images.Add(global::Yahtzee.Properties.Resources.four_);
            images.Add(global::Yahtzee.Properties.Resources.five_);
            images.Add(global::Yahtzee.Properties.Resources.six_);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yahtzee.resetGame();
            this.dice1.Image = null;
            this.dice2.Image = null;
            this.dice3.Image = null;
            this.dice4.Image = null;
            this.dice5.Image = null;
            rollsLeftLabel.Text = yahtzee.rollsLeft.ToString();
            clearScoreTable();
        }

        private void clearScoreTable()
        {
            foreach (ListViewItem itemRow in this.scoreView.Items)
            {
                itemRow.SubItems[1].Text = "";
            }
        }

        private void scoreView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }

        private void scoreView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items =
                this.scoreView.SelectedItems;
            if(items.Count == 0)
            {
                button1.Enabled = false;
                return;
            }
            foreach (ListViewItem item in items)
            {
                if(item.SubItems[1].Text == "" && rollsLeftLabel.Text == "0")
                {
                    categoryListViewItem = item;
                    button1.Enabled = true;
                }
            }
        }

        private void dice1_Click(object sender, EventArgs e)
        {

            int[] values = Array.ConvertAll(yahtzee.roll.Split(','), s => int.Parse(s));
            if (yahtzee.rollsLeft < 3 && yahtzee.rollsLeft > 0)
            {
                if (!yahtzee.holdDice[0])
                {
                    yahtzee.holdDice[0] = true;
                    this.dice1.Image = images[values[0] + 5];
                }
                else
                {
                    yahtzee.holdDice[0] = false;
                    this.dice1.Image = images[values[0] - 1];
                }
            }
        }

        private void dice2_Click(object sender, EventArgs e)
        {
            int[] values = Array.ConvertAll(yahtzee.roll.Split(','), s => int.Parse(s));
            if (yahtzee.rollsLeft < 3 && yahtzee.rollsLeft > 0)
            {
                if (!yahtzee.holdDice[1])
                {
                    yahtzee.holdDice[1] = true;
                    this.dice2.Image = images[values[1] + 5];
                }
                else
                {
                    yahtzee.holdDice[1] = false;
                    this.dice2.Image = images[values[1] - 1];
                }
            }
        }


        private void scoreView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            categoryListViewItem.SubItems[1].Text = yahtzee.Score(yahtzee.roll, yahtzee.categoryList[categoryListViewItem.Index]).ToString();
            yahtzee.rollsLeft = 3;
            rollsLeftLabel.Text = yahtzee.rollsLeft.ToString();
            button1.Enabled = false;
        }

        private void dice3_Click(object sender, EventArgs e)
        {
            int[] values = Array.ConvertAll(yahtzee.roll.Split(','), s => int.Parse(s));
            if (yahtzee.rollsLeft < 3 && yahtzee.rollsLeft > 0)
            {
                if (!yahtzee.holdDice[2])
                {
                    yahtzee.holdDice[2] = true;
                    this.dice3.Image = images[values[2] + 5];
                }
                else
                {
                    yahtzee.holdDice[2] = false;
                    this.dice3.Image = images[values[2] - 1];
                }
            }
        }

        private void dice4_Click(object sender, EventArgs e)
        {
            int[] values = Array.ConvertAll(yahtzee.roll.Split(','), s => int.Parse(s));
            if(yahtzee.rollsLeft < 3 && yahtzee.rollsLeft > 0) { 
                if (!yahtzee.holdDice[3])
                {
                    yahtzee.holdDice[3] = true;
                    this.dice4.Image = images[values[3] + 5];
                }
                else
                {
                    yahtzee.holdDice[3] = false;
                    this.dice4.Image = images[values[3] - 1];
                }
            }
        }

        private void dice5_Click(object sender, EventArgs e)
        {
            int[] values = Array.ConvertAll(yahtzee.roll.Split(','), s => int.Parse(s));

            if (yahtzee.rollsLeft < 3 && yahtzee.rollsLeft > 0)
            {
                if (!yahtzee.holdDice[4])
                {
                    yahtzee.holdDice[4] = true;
                    this.dice5.Image = images[values[4] + 5];
                }
                else
                {
                    yahtzee.holdDice[4] = false;
                    this.dice5.Image = images[values[4] - 1];
                }
            }
        }
    }
}
