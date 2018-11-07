using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalloKlassen;

namespace ZugGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Zug> liste = new List<Zug>();
            Random ran = new Random();

            for (int i = 0; i < 100; i++)
            {
                Zug zug = new Zug()
                {
                    Nummer = $"ICE {i:0000}",
                    Laenge = ran.NextDouble() * 400,
                    AnzahlWagen = ran.Next(1, 13),
                    Hoechstgeschwindingkeit = ran.Next(150, 300),
                    Wlan = ran.Next() > int.MaxValue / 2,
                    Baujahr = DateTime.Now.AddYears(-30).AddDays(i * 94)
                };

                liste.Add(zug);
            }

            dataGridView1.DataSource = liste;
        }
    }
}
