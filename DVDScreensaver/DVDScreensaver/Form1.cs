using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDScreensaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int speedX = 2;
        int speedY = 2;

        Random ran = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {

            button1.Left += speedX;
            button1.Top += speedY;

            

            if (button1.Right >= ClientRectangle.Right ||
                button1.Left <= 0)
            {
                speedX *= -1;
                Task.Run(() => Console.Beep());
                button1.BackColor = Color.FromArgb(ran.Next(255), ran.Next(255),ran.Next(255));
                BackColor = Color.FromArgb(ran.Next(255), ran.Next(255), ran.Next(255));
            }

            if (button1.Bottom >= ClientRectangle.Bottom ||
                button1.Top <= 0)
            {
                speedY *= -1;
                Task.Run(() => Console.Beep());
                button1.BackColor = Color.FromArgb(ran.Next(255), ran.Next(255), ran.Next(255));
                BackColor = Color.FromArgb(ran.Next(255), ran.Next(255), ran.Next(255));

            }
        }
    }
}
