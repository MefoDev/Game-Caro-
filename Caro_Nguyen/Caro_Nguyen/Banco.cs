using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_Nguyen
{
    public class Banco
    {

        #region Properties
        public  Panel Ban_Co;
        public static String check;
        public static Boolean kt = true;
        public static Stack<Button> undoX = new Stack<Button>();
        public static Stack<Button> undoO = new Stack<Button>();
        public static Stack<Button> highLight = new Stack<Button>();
        public static List<List<Button>> matrix;
        public static List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; } 
        }
        #endregion

        #region Initialize
        public Banco(Panel Ban_Co)
        {
            this.Ban_Co = Ban_Co;
        }
        #endregion

        #region Methods
        public void VeBanCo()
        {
            Ban_Co.Controls.Clear();
            Matrix = new List<List<Button>>();

            Button ButtonCu = new Button() { Width = 0, Location = new Point(0, 0), Text = "" };
            for (int i = 0; i < Bien.Banco_cao; i++)
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j <= Bien.Banco_rong; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Bien.O_rong,
                        Height = Bien.O_cao,
                        Location = new Point(ButtonCu.Location.X + ButtonCu.Width, ButtonCu.Location.Y),
                        Tag = i.ToString()
                    };
                    btn.Click += Btn_Click;

                    Ban_Co.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    ButtonCu = btn;
                }
                ButtonCu.Location = new Point(0, ButtonCu.Location.Y + Bien.O_cao);
                ButtonCu.Width = 0;
                ButtonCu.Height = 0;
            }
            highLight.Clear();
        }
        public static void undo_x()
        {
            if(undoX.Count < 0) 
            {
                return;
            }
            if (undoX.Count > 0)
            {
                Button btn = undoX.Pop();
                int doc = Convert.ToInt32(btn.Tag);
                int ngang = Matrix[doc].IndexOf(btn);
                Matrix[doc][ngang].BackColor = default;
                Matrix[doc][ngang].Text = "";
               
            }
        }
        public static void undo_O()
        {
            if (undoO.Count < 0) return;
            if (undoO.Count > 0)
            {
                Button btn = undoO.Pop();
                int doc = Convert.ToInt32(btn.Tag);
                int ngang = Matrix[doc].IndexOf(btn);
                Matrix[doc][ngang].BackColor = default;
                Matrix[doc][ngang].Text = "";
               
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text != "")
            {
                return;
            }

            if (Bien.player == true)
            {

                btn.Text = "x";
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
                Bien.player = false;
                undoX.Clear();
                undoX.Push(btn);
                frmNguyen.timer.Start();
                frmNguyen.timerO.Start();
                frmNguyen.timerX.Stop();
            }
            else
            {

                btn.Text = "O";
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White;
                Bien.player = true;
                undoO.Clear();
                undoO.Push(btn);
                frmNguyen.timer.Start();
                frmNguyen.timerX.Start();
                frmNguyen.timerO.Stop();

            }
            check = btn.Text.ToString();
            if (neuketthuc(btn))
            {
                ketthuc(btn);
                kt = false;
            }

        }
        private void ketthuc(Button btn)
        {
            frmNguyen.timer.Stop();
            frmNguyen.timerX.Stop();
            frmNguyen.timerO.Stop();
            if (btn.Text == "x")
            {
                Bien.winx += 1;
                frmNguyen.label10.Text = Bien.phutX.ToString() + " m " + Bien.giayX.ToString() + " s";
                frmNguyen.label8.Text = Bien.winx.ToString();
                MessageBox.Show("ket thuc. " +frmNguyen.player1.Text + " thang!" 
                    +"\nTime Win " + frmNguyen.label10.Text);


            }
            else
            {
                Bien.wino += 1;
                frmNguyen.label9.Text = Bien.wino.ToString();
                MessageBox.Show("ket thuc. " + frmNguyen.player2.Text + " thang!"
                +"\nTime Win " + frmNguyen.label2.Text);
            }
            highLight.Clear();
            inHighLight(btn);
            Ban_Co.Enabled = false;
        }
        private bool neuketthuc(Button btn)
        {
            return neuketthucngang(btn) ||neuketthuchangdoc(btn) ||neuketthucCheochinh(btn) ||neuketthucCheophu(btn) ;
        }

        private Point GetchessPoin(Button btn)
        {
            int doc = Convert.ToInt32(btn.Tag);
            int ngang = Matrix[doc].IndexOf(btn);

            Point point = new Point(ngang,doc);

            return point;
        }
        private void inHighLight(Button b)
        {
            neuketthucngang(b);
            neuketthuchangdoc(b);
            neuketthucCheochinh(b);
            neuketthucCheophu(b);

            while (highLight.Count > 0)
                {

                    Button btn = highLight.Pop();

                    for (int i = 0; i < Bien.Banco_cao; i++)
                    {
                        for (int j = 0; j <= Bien.Banco_rong; j++)
                        {
                            if (Matrix[i][j] == btn)
                            {
                                Matrix[i][j].BackColor = System.Drawing.Color.Yellow;
                            }

                        }
                    }

                } 

            
        }

        private bool neuketthucngang(Button btn)
        {
            Point point = GetchessPoin(btn);

            int countl = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].Text == btn.Text)
                {
                    countl++;
                    highLight.Push(Matrix[point.Y][i]);// tương tự
                }
                else
                    break;
            }

            int countR = 0;
            for (int i = point.X + 1; i< Bien.Banco_rong; i++)
            {
                if (Matrix[point.Y][i].Text == btn.Text)
                {
                    countR++;
                    highLight.Push(Matrix[point.Y][i]); 
                }
                else
                    break;
            }
            if(countl + countR < 5)
            {
                int dem = countl + countR;
                while (dem > 0)
                {
                    dem -= 1;
                    if (highLight.Count > 0) highLight.Pop();
                }
            }

            return countl+countR>=5;
        }
        private bool neuketthuchangdoc(Button btn)
        {
            Point point = GetchessPoin(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].Text == btn.Text)
                {
                    countTop++;
                    highLight.Push(Matrix[i][point.X]);
                }
                else
                    break;
            }

            int countBot = 0;
            for (int i = point.Y + 1; i < Bien.Banco_cao; i++)
            {
                if (Matrix[i][point.X].Text == btn.Text)
                {
                    countBot++;
                    highLight.Push(Matrix[i][point.X]);
                }
                else
                    break;
            }
            if (countBot + countTop < 5)
            {
                int dem = countBot + countTop;
                while (dem > 0)
                {
                    dem -= 1;
                    if(highLight.Count>0) highLight.Pop();
                }
            }
            return countTop + countBot >= 5;
        }
        private bool neuketthucCheochinh(Button btn)
        {
            Point point = GetchessPoin(btn);

            int countCTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X - i].Text == btn.Text)
                {
                    countCTop++;
                    highLight.Push(Matrix[point.Y - i][point.X - i]);
                }
                else
                    break;
            }

            int countCBot = 0;
            for (int i = 1; i <= Bien.Banco_rong - point.X; i++)
            {
                if (point.Y + i >= Bien.Banco_cao || point.X + i >= Bien.Banco_rong)
                    break;
                if (Matrix[point.Y + i][point.X + i].Text == btn.Text)
                {
                    countCBot++;
                    highLight.Push(Matrix[point.Y + i][point.X + i]);
                }
                else
                    break;
            }
            if (countCBot + countCTop < 5)
            {
                
                    int dem = countCBot + countCTop;
                    while (dem > 0)
                    {
                        dem -= 1;
                        if (highLight.Count > 0) highLight.Pop();
                    }
                
            }
            return countCTop + countCBot >= 5;
        }
        private bool neuketthucCheophu(Button btn)
        {
            Point point = GetchessPoin(btn);

            int countPTop = 0;
            for (int i = 0; i <= point.Y; i++)
            {
                if (point.X + i > Bien.Banco_rong || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X + i].Text == btn.Text)
                {
                    countPTop++;
                    highLight.Push(Matrix[point.Y - i][point.X + i]);
                }
                else
                    break;
            }

            int countPBot = 0;
            for (int i = 1; i < Bien.Banco_cao - point.Y; i++)
            {
                if (point.Y + i >= Bien.Banco_rong || point.X - i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].Text == btn.Text)
                {
                    countPBot++;
                    highLight.Push(Matrix[point.Y + i][point.X - i]);
                }
                else
                    break;
            }
            if (countPTop + countPBot < 5)
            {
                int dem = countPTop + countPBot;
                while (dem > 0)
                {
                    dem -= 1;
                    if (highLight.Count > 0) highLight.Pop();
                }
            }

            return countPTop + countPBot >= 5;
        }
        #endregion

    }
}
