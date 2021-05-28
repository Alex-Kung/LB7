using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace EngGame
{
    public partial class Form1 : Form
    {
        public int points = 0;
        public bool reverse = false;
        public int counter = 1;
        public int now = 0;
        public static string[] rus = Properties.Resources.Rus.Split(' ');
        public static string[] eng = Properties.Resources.Eng.Split(' ');
        public Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            HideAll();
            pts.Text = "";
            word.Text = "";       
        }
        private void HideAll()
        {
            Ruseng.Show();
            Engrus.Show();
            Exit.Show();
            menu.Hide();
            pictureBox1.Hide();
            pts.Hide();
            word.Hide();
            transword.Hide();
            check.Hide();
            label1.Hide();
        }
        private void ShowAll()
        {
            label1.Show();
            menu.Show();
            pictureBox1.Show();
            pts.Show();
            word.Show();
            transword.Show();
            check.Show();
            Engrus.Hide();
            Ruseng.Hide();
            Exit.Hide();
        }

        private void Ruseng_Click(object sender, EventArgs e)
        {
                ShowAll();
                reverse = false;
                MainGame();
        }       

        private void Engrus_Click(object sender, EventArgs e)
        {
                ShowAll();
                reverse = true;
                MainGame();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainGame()
        {
            pts.Text = points.ToString();
            if (counter == 1)
            { pictureBox1.Image = new Bitmap(Properties.Resources._1); }
            if (!reverse)
            {
                now = rnd.Next(rus.Length);
                word.Text = rus[now];
            }
            else
            {   
                now = rnd.Next(eng.Length);
                word.Text = eng[now]; 
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (!reverse)
            {
                if (transword.Text == eng[now])
                {
                    points++;
                }
                else
                {
                    counter++;
                    NewImg();
                }                
            }
            else
            {
                if (transword.Text == rus[now])
                {
                    points++;
                }
                else
                {
                    counter++;
                    NewImg();
                }
            }
            transword.Text = "";
            MainGame();

        }

        private void NewImg()
        {
            switch (counter)
            {
                case 2: { pictureBox1.Image = new Bitmap(Properties.Resources._2); } break;
                case 3: { pictureBox1.Image = new Bitmap(Properties.Resources._3); } break;
                case 4: { pictureBox1.Image = new Bitmap(Properties.Resources._4); } break;
                case 5: { pictureBox1.Image = new Bitmap(Properties.Resources._5); } break;
                case 6: { pictureBox1.Image = new Bitmap(Properties.Resources._6); } break;
                case 7: { pictureBox1.Image = new Bitmap(Properties.Resources._7); Lose(); } break;
            }
        }

        private void Lose()
        {         
            HideAll();
            MessageBox.Show("You have "+points.ToString()+ " points!", "Сообщение");
            pictureBox1.Image = new Bitmap(Properties.Resources._1);
            counter = 0;
            points = 0;

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Properties.Resources._1);
            counter = 0;
            points = 0;
            HideAll();
        }
    }
}

