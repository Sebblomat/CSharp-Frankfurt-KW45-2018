using HalloVererbung.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HalloVererbung.WinformsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = new List<GueterZug>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var liste = new List<GueterZug>();

            for (int i = 0; i < 10; i++)
            {
                liste.Add(new GueterZug()
                {
                    Nummer = $"#{i:000}",
                    MaxZuladung = i * 1000,
                    Baujahr = DateTime.Now.AddYears(-20).AddDays(i * 777),
                    Antriebsart = Antriebsart.Diesel
                });
            }

            dataGridView1.DataSource = liste;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                Filter = "Zugdateien|*.txt|Alles mögliche|*.*"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dataGridView1.DataSource is List<GueterZug> liste)
                {
                    try
                    {

                        var sw = new StreamWriter(dlg.FileName);
                        string trenn = "😛";
                        foreach (var item in liste)
                        {
                            sw.Write(item.Nummer);
                            sw.Write(trenn);
                            sw.Write(item.Baujahr);
                            sw.Write(trenn);
                            sw.Write(item.Spurbreite);
                            sw.Write(trenn);
                            sw.Write(item.Antriebsart);
                            sw.Write(trenn);
                            sw.Write(item.Zuladung);
                            sw.Write(trenn);
                            sw.Write(item.MaxZuladung);
                            sw.Write(trenn);
                            sw.WriteLine();
                        }
                        sw.Close();
                        Process.Start(dlg.FileName);
                    }

                    catch (PathTooLongException ex)
                    {
                        MessageBox.Show($"Fehler: {ex.Message}");
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show($"Fehler: Das stimmt was nicht mit dem Dateinamen! {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler:  {ex.Message}");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is GueterZug zug)
            {
                try
                {
                    zug.Zuladung = 5999999;
                }
                catch (ZulandungsFehlerException ex)
                {
                    MessageBox.Show($"Die maximale Zuladung von {ex.MaxZuläßigeZuladung} wurde um {ex.ÜberschrittenUm} überschritten");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                Filter = "XML-Zugdateien|*.xml"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var serial = new XmlSerializer(typeof(List<GueterZug>));
                var sw = new StreamWriter(dlg.FileName);
                serial.Serialize(sw, dataGridView1.DataSource);
                sw.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                Filter = "XML-Zugdateien|*.xml"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var serial = new XmlSerializer(typeof(List<GueterZug>));
                var sr = new StreamReader(dlg.FileName);
                dataGridView1.DataSource = serial.Deserialize(sr);
                sr.Close();
            }

        }
    }
}
