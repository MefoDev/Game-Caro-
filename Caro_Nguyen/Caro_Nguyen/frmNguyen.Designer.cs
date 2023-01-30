
using System.Windows.Forms;

namespace Caro_Nguyen
{
    partial class frmNguyen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlayer1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            label10 = new Label();
            this.roundL = new System.Windows.Forms.Label();
            label8 = new Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prcbtime1 = new System.Windows.Forms.ProgressBar();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            player1 = new Label();
            this.pnlayer2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            label2 = new Label();
            label9 = new Label();
            this.roundR = new System.Windows.Forms.Label();
            this.round = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prcbtime2 = new System.Windows.Forms.ProgressBar();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            player2 = new Label();
            timer = new Timer(this.components);
            timerX = new Timer(this.components);
            timerO = new Timer(this.components);
            this.pnlayer1.SuspendLayout();
            this.pnlayer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(160, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 540);
            this.panel1.TabIndex = 238;
            // 
            // pnlayer1
            // 
            this.pnlayer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlayer1.Controls.Add(this.label7);
            this.pnlayer1.Controls.Add(this.label3);
            pnlayer1.Controls.Add(label10);
            this.pnlayer1.Controls.Add(this.roundL);
            pnlayer1.Controls.Add(label8);
            this.pnlayer1.Controls.Add(this.label6);
            this.pnlayer1.Controls.Add(this.label1);
            this.pnlayer1.Controls.Add(this.prcbtime1);
            this.pnlayer1.Controls.Add(this.button7);
            this.pnlayer1.Controls.Add(this.button5);
            this.pnlayer1.Controls.Add(this.button3);
            this.pnlayer1.Controls.Add(this.button1);
            this.pnlayer1.Controls.Add(this.textBox1);
            pnlayer1.Controls.Add(player1);
            this.pnlayer1.Location = new System.Drawing.Point(1, 1);
            this.pnlayer1.Name = "pnlayer1";
            this.pnlayer1.Size = new System.Drawing.Size(160, 540);
            this.pnlayer1.TabIndex = 239;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 40);
            this.label7.TabIndex = 21;
            this.label7.Text = "Time Win";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "Time Down";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(80, 400);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(70, 15);
            label10.TabIndex = 19;
            label10.Text = "0 m 0 s";
            // 
            // roundL
            // 
            this.roundL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundL.Location = new System.Drawing.Point(100, 504);
            this.roundL.Name = "roundL";
            this.roundL.Size = new System.Drawing.Size(36, 27);
            this.roundL.TabIndex = 16;
            this.roundL.Text = "0";
            this.roundL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(13, 504);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(36, 27);
            label8.TabIndex = 15;
            label8.Text = "0";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "ROUND";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "WIN";
            // 
            // prcbtime1
            // 
            this.prcbtime1.Location = new System.Drawing.Point(53, 335);
            this.prcbtime1.Name = "prcbtime1";
            this.prcbtime1.Size = new System.Drawing.Size(100, 23);
            this.prcbtime1.TabIndex = 6;
            this.prcbtime1.Click += new System.EventHandler(this.prcbtime1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Navy;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(32, 250);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 38);
            this.button7.TabIndex = 5;
            this.button7.Text = "UNDO: 00";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Undo_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(32, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(32, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "START";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Start_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(41, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Name";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 1;
            // 
            // player1
            // 
            player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            player1.ForeColor = System.Drawing.Color.Red;
            player1.Location = new System.Drawing.Point(3, 112);
            player1.Name = "player1";
            player1.Size = new System.Drawing.Size(153, 23);
            player1.TabIndex = 0;
            player1.Text = "layer1";
            player1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlayer2
            // 
            this.pnlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlayer2.Controls.Add(this.label11);
            this.pnlayer2.Controls.Add(label2);
            this.pnlayer2.Controls.Add(label9);
            this.pnlayer2.Controls.Add(this.roundR);
            this.pnlayer2.Controls.Add(this.round);
            this.pnlayer2.Controls.Add(this.label5);
            this.pnlayer2.Controls.Add(this.label4);
            this.pnlayer2.Controls.Add(this.prcbtime2);
            this.pnlayer2.Controls.Add(this.button8);
            this.pnlayer2.Controls.Add(this.button6);
            this.pnlayer2.Controls.Add(this.button4);
            this.pnlayer2.Controls.Add(this.button2);
            this.pnlayer2.Controls.Add(this.textBox2);
            this.pnlayer2.Controls.Add(player2);
            this.pnlayer2.Location = new System.Drawing.Point(700, 1);
            this.pnlayer2.Name = "pnlayer2";
            this.pnlayer2.Size = new System.Drawing.Size(160, 540);
            this.pnlayer2.TabIndex = 240;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 40);
            this.label11.TabIndex = 22;
            this.label11.Text = "Time Win";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(80, 400);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 15);
            label2.TabIndex = 20;
            label2.Text = "0 m 0 s";
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(13, 504);
            label9.Name = "label9";
            label9.TabIndex = 15;
            label9.Size = new System.Drawing.Size(36, 27);
            label9.Text = "0";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundR
            // 
            this.roundR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundR.Location = new System.Drawing.Point(99, 504);
            this.roundR.Name = "roundR";
            this.roundR.Size = new System.Drawing.Size(36, 27);
            this.roundR.TabIndex = 14;
            this.roundR.Text = "0";
            this.roundR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // round
            // 
            this.round.AutoSize = true;
            this.round.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round.Location = new System.Drawing.Point(89, 462);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(63, 16);
            this.round.TabIndex = 12;
            this.round.Text = "ROUND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "WIN";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time Down";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prcbtime2
            // 
            this.prcbtime2.Location = new System.Drawing.Point(52, 335);
            this.prcbtime2.Name = "prcbtime2";
            this.prcbtime2.Size = new System.Drawing.Size(100, 23);
            this.prcbtime2.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Navy;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(31, 250);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 38);
            this.button8.TabIndex = 6;
            this.button8.Text = "UNDO: 00";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(31, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 38);
            this.button6.TabIndex = 5;
            this.button6.Text = "CLEAR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(31, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "START";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Start_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(41, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Name";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(7, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 26);
            this.textBox2.TabIndex = 2;
            // 
            // player2
            // 
            player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            player2.ForeColor = System.Drawing.Color.Blue;
            player2.Location = new System.Drawing.Point(3, 112);
            player2.Name = "player2";
            player2.Size = new System.Drawing.Size(153, 23);
            player2.TabIndex = 1;
            player2.Text = "layer2";
            player2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Tick += new System.EventHandler(timerplayer1_Tick);
            // 
            // timerX
            // 
            timerX.Interval = 1000;
            timerX.Tick += new System.EventHandler(timerX_Tick);
            // 
            // timerO
            // 
            timerO.Interval = 1000;
            timerO.Tick += new System.EventHandler(timer2_Tick);
            // 
            // frmNguyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 580);
            this.Controls.Add(this.pnlayer2);
            this.Controls.Add(this.pnlayer1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(880, 580);
            this.MinimumSize = new System.Drawing.Size(880, 580);
            this.Name = "frmNguyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro";
            this.pnlayer1.ResumeLayout(false);
            this.pnlayer1.PerformLayout();
            this.pnlayer2.ResumeLayout(false);
            this.pnlayer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlayer1;
        private System.Windows.Forms.Panel pnlayer2;
        private System.Windows.Forms.ProgressBar prcbtime1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar prcbtime2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Label roundL;
        private System.Windows.Forms.Label roundR;
        private Label label7;
        private Label label3;
        private Label label11;
        public static Label label10;
        public static Label label2;
        public static Label player1;
        public static Label player2;
        public static Timer timerX;
        public static Timer timerO;
        public static Timer timer;
        public static Label label9;
        public static Label label8;
    }
}

