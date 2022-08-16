using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        string player = "X";
        int usedsymbols = 0;
        int x = 0;
        int o = 0;

        Image arrowX = Properties.Resources.ArrowX;
        Image arrowO = Properties.Resources.ArrowO;

        public Form1()
        {
            InitializeComponent();
        }

        private void Restart()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            label.Text = player;
            label.Enabled = false;

            if (player == "X")
            {
                player = "O";
                pictureBoxX.Visible = false;
                pictureBoxO.Visible = true;
            }

            else
            {
                player = "X";
                pictureBoxO.Visible = false;
                pictureBoxX.Visible = true;
            }

            if (label1.Text == "X" && label2.Text == "X" && label3.Text == "X" ||
                label4.Text == "X" && label5.Text == "X" && label6.Text == "X" ||
                label7.Text == "X" && label8.Text == "X" && label9.Text == "X" ||
                label1.Text == "X" && label4.Text == "X" && label7.Text == "X" ||
                label2.Text == "X" && label5.Text == "X" && label8.Text == "X" ||
                label3.Text == "X" && label6.Text == "X" && label9.Text == "X" ||
                label1.Text == "X" && label5.Text == "X" && label9.Text == "X" ||
                label3.Text == "X" && label5.Text == "X" && label7.Text == "X")
            {
                MessageBox.Show("X WINNER!");
                x++;
                usedsymbols = 0;
                labelX.Text = Convert.ToString(x);
                Restart();

                if (labelX.Text == "10")
                {
                    MessageBox.Show("GAME OVER\nX WINS THE GAME!");
                    Close();
                }
            }

            if (label1.Text == "O" && label2.Text == "O" && label3.Text == "O" ||
                label4.Text == "O" && label5.Text == "O" && label6.Text == "O" ||
                label7.Text == "O" && label8.Text == "O" && label9.Text == "O" ||
                label1.Text == "O" && label4.Text == "O" && label7.Text == "O" ||
                label2.Text == "O" && label5.Text == "O" && label8.Text == "O" ||
                label3.Text == "O" && label6.Text == "O" && label9.Text == "O" ||
                label1.Text == "O" && label5.Text == "O" && label9.Text == "O" ||
                label3.Text == "O" && label5.Text == "O" && label7.Text == "O")
            {
                MessageBox.Show("O WINNER!");
                usedsymbols = 0;
                o++;
                labelO.Text = Convert.ToString(o);
                Restart();

                if (labelO.Text == "10")
                {
                    MessageBox.Show("GAME OVER\nO WINS THE GAME!");
                    Close();
                }
            }

            usedsymbols++;

            if (usedsymbols == 9)
            {
                MessageBox.Show("DRAW!");
                usedsymbols = 0;
                Restart();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            x = 0;
            o = 0;

            usedsymbols = 0;

            labelX.Text = Convert.ToString(0);
            labelO.Text = Convert.ToString(0);
            Restart();

            if (player == "O")
            {
                player = "X";
                pictureBoxX.Visible = true;
                pictureBoxO.Visible = false;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (player == "O")
            {
                player = "X";
                pictureBoxX.Visible = true;
                pictureBoxO.Visible = false;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (player == "X")
            {
                player = "O";
                pictureBoxX.Visible = false;
                pictureBoxO.Visible = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxX_Click(object sender, EventArgs e)
        {

        }
    }
}