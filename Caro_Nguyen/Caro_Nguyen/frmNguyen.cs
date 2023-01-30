using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_Nguyen
{
    public partial class frmNguyen : Form
    {
        #region Properties
        Banco Ban_Co;
    
        #endregion

        public frmNguyen()
        {
            InitializeComponent();
            Ban_Co = new Banco(panel1);
            Ban_Co.VeBanCo();
            panel1.Enabled = false;
            prcbtime1.Step = Bien.Step;
            prcbtime1.Maximum = Bien.times;
            prcbtime1.Value = 0;

            prcbtime2.Step = Bien.Step;
            prcbtime2.Maximum = Bien.times;
            prcbtime2.Value = 0;

            timer.Interval = Bien.Interval;
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                 MessageBox.Show("ten k duoc trong");
            }
            else
            {
                player1.Text = textBox1.Text;
                Bien.RoundLeft = 0;
                roundL.Text = "0";
                label8.Text = "0";
                Bien.winx = 0;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("ten k duoc trong");
            }
            else
            {
                player2.Text = textBox2.Text;
                Bien.RoundRight = 0;
                roundR.Text = "0";
                label9.Text = "0";
                Bien.wino = 0;
            }
        }

        
        private void Start_Click(object sender, EventArgs e)
        {
            Bien.player = true;
            panel1.Enabled = true;
            Ban_Co.VeBanCo();
            Banco.highLight.Clear();
            Bien.giayX = Bien.giayO = Bien.phutX = Bien.phutO = 0;
            label10.Text = "0 m 0 s";

            player1.ForeColor = Color.Red;
            player2.ForeColor = Color.Blue;
            timer.Start();
            prcbtime1.Value = 0;
            prcbtime2.Value = 0;
            timerX.Start();

            Bien.RoundLeft++;
            roundL.Text = Bien.RoundLeft.ToString();

            Bien.RoundRight++;
            roundR.Text = Bien.RoundRight.ToString();

            
            

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Ban_Co.VeBanCo();
            Banco.highLight.Clear();
            prcbtime1.Value = prcbtime2.Value = 0;

            timer.Stop();
            timerO.Stop();
            timerX.Stop();

            Bien.player = true;

            Bien.demundoO =  Bien.demUndoX = 0;

            button8.Text = button7.Text = "UNDO: 00";

            label8.Text = label9.Text = "0";

            roundL.Text = roundR.Text = "0";

            Bien.RoundLeft = Bien.RoundRight = 0;

            Bien.giayX = Bien.giayO = 0;
            Bien.phutX = Bien.phutO = 0;

            label10.Text = label2.Text = "0 m 0 s";

            Bien.wino = Bien.winx = 0;

        }

        private void timerplayer1_Tick(object sender, EventArgs e)
        {
            
            if (Bien.player == true)
            {
                prcbtime1.PerformStep();
                prcbtime2.Value = 0;
            }
            else
            {
                prcbtime2.PerformStep();
                prcbtime1.Value = 0;
            }
            if(prcbtime1.Value >= prcbtime1.Maximum || prcbtime2.Value >= prcbtime2.Maximum)
            {
                ketthuc();
            }

        }

        void ketthuc( )
        {
            timer.Stop();
            timerX.Stop();
            timerO.Stop();
            panel1.Enabled = false;
            if (Banco.check == "x")
            {
                Bien.winx += 1;
                label10.Text = Bien.phutX.ToString() + " m " + Bien.giayX.ToString() + " s";
                label8.Text = Bien.winx.ToString();
                MessageBox.Show("Het thoi gian. "+ player1.Text+ " thang!" 
                    +"\n"+"Time Win "+label10.Text);
            }
            else if(Banco.check == "O")
            {
                label2.Text = Bien.phutO.ToString() + " m " + Bien.giayO.ToString() + " s";
                Bien.wino += 1;
                label9.Text = Bien.wino.ToString();
                MessageBox.Show("Het thoi gian. "+ player2.Text+" thang!" 
                    + "\n" + "Time Win " + label2.Text);
            }
            else
            {
                MessageBox.Show("Het thoi gian. Hoa!");
            }
            

        }
        void undo()
        {
            MessageBox.Show("So lan Undo round nay da het!");
        }
        private void Undo_Click(object sender, EventArgs e)
        {
            if (Bien.demUndoX < 3)
            {
                Banco.undo_x();
                Bien.player = true;
                Bien.demUndoX++;
                button7.Text = "UNDO: 0" + Bien.demUndoX.ToString();
            }
            else
            {
                undo();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (Bien.demundoO < 3)
            {
                Banco.undo_O();
                Bien.player = false;
                Bien.demundoO++;
                button8.Text = "UNDO: 0" + Bien.demundoO.ToString();
            }
            else
            {
                undo();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Bien.giayO == 60)
            {
                Bien.giayO = 0;
                Bien.phutO += 1;
            }
            else
            {
                Bien.giayO += 1;
            }
            label2.Text = Bien.phutO + " m " + Bien.giayO.ToString() + " s";
        }

        private void timerX_Tick(object sender, EventArgs e)
        {
            if(Bien.giayX == 60)
            {
                Bien.giayX = 0;
                Bien.phutX += 1;
            }
            else
            {
                Bien.giayX += 1;
            }
            label10.Text = Bien.phutX+" m "+Bien.giayX.ToString() + " s";
        }

        private void prcbtime1_Click(object sender, EventArgs e)
        {

        }
    }
}
