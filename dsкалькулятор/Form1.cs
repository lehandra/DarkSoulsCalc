using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using dsкалькулятор.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;




namespace dsкалькулятор
{

    public partial class Form1 : Form
    {
        SoundPlayer player;
        public Form1()
        {
            InitializeComponent();

            player = new SoundPlayer("C:\\Users\\aleks\\source\\repos\\dsкалькулятор\\dsкалькулятор\\Resources\\soundtrack.wav");
            player.PlayLooping();

        }
        private bool isPlaying = true;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (player.IsLoadCompleted)
            {
                if (isPlaying)
                    player.Stop();
                else
                    player.Play();
                isPlaying = !isPlaying;
            }
        }

        //textbox1 при наведении
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            var tb = sender as System.Windows.Forms.TextBox;
            Graphics g = tb.CreateGraphics();
            ControlPaint.DrawBorder(g, tb.DisplayRectangle, Color.FromArgb(125, 94, 46), ButtonBorderStyle.Solid);
            g.Dispose();
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            var tb = sender as System.Windows.Forms.TextBox;
            tb.BorderStyle = BorderStyle.None;
            tb.Invalidate();
        }

        //textbox2 при наведении
        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            var tb = sender as System.Windows.Forms.TextBox;
            Graphics g = tb.CreateGraphics();
            ControlPaint.DrawBorder(g, tb.DisplayRectangle, Color.FromArgb(125, 94, 46), ButtonBorderStyle.Solid);
            g.Dispose();
        }
        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            var tb = sender as System.Windows.Forms.TextBox;
            tb.BorderStyle = BorderStyle.None;
            tb.Invalidate();
        }

        //textbox3 при наведении
        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            var tb = sender as System.Windows.Forms.TextBox;
            Graphics g = tb.CreateGraphics();
            ControlPaint.DrawBorder(g, tb.DisplayRectangle, Color.FromArgb(125, 94, 46), ButtonBorderStyle.Solid);
            g.Dispose();
        }
        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            var tb = sender as System.Windows.Forms.TextBox;
            tb.BorderStyle = BorderStyle.None;
            tb.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int mylvl = Convert.ToInt32(textBox1.Text);
            int needlvl = Convert.ToInt32(textBox2.Text);
            double sololvl = 0;
            double result = 0;
            {
                for (int i = mylvl + 1; i <= needlvl; i++)
                {
                    if (i < 12)
                    {
                        sololvl = Math.Pow(0.0068 * i, 3) - Math.Pow(0.06 * i, 2) + (17.1 * i) + 639;
                        sololvl = Convert.ToInt32(Math.Round(sololvl));
                        result += sololvl;
                    }
                    else if (i >= 12)
                    {
                        sololvl = 0.02 * Math.Pow(i, 3) + 3.06 * Math.Pow(i, 2) + 105.6 * i - 895;
                        sololvl = Convert.ToInt32(Math.Round(sololvl));
                        result += sololvl;

                    }
                }

            }
            textBox3.Text = result.ToString();
        }

    }
}
