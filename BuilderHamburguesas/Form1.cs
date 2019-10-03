using BuilderHamburguesas.Builder;
using BuilderHamburguesas.Director;
using BuilderHamburguesas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderHamburguesas
{
    public partial class Form1 : Form
    {
        private Chef chef = new Chef();
        private Hamburguesa hamburguesa = null;
        private bool[] pedido = new bool[8];
        private List<Hamburguesa> lista = new List<Hamburguesa>();
        private double total;
        public Form1()
        {
            InitializeComponent();

            richTextBox1.Enabled = true;
            richTextBox1.ReadOnly = true;

            pictureBox1.Image = BuilderHamburguesas.Properties.Resources.H1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = BuilderHamburguesas.Properties.Resources.H2;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = BuilderHamburguesas.Properties.Resources.H3;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.Image = BuilderHamburguesas.Properties.Resources.H4;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.Image = BuilderHamburguesas.Properties.Resources.H5;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox6.Image = BuilderHamburguesas.Properties.Resources.H6;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox7.Image = BuilderHamburguesas.Properties.Resources.H7;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox8.Image = BuilderHamburguesas.Properties.Resources.H8;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Favor de pagar: $" + total.ToString() + "\nDisfrute su comida.");
            Process.Start("https://www.youtube.com/watch?v=Ko7izIn3riA");

            lista.Clear();
            total = 0;

            label2.Text = "$" + total.ToString();
            richTextBox1.Text = "";
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox1, "BurgerBurger");
            tt.InitialDelay = 500;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox2, "MexBurger");
            tt.InitialDelay = 500;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox3, "Quesos Burger");
            tt.InitialDelay = 500;
        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox4, "Hawaii Burger");
            tt.InitialDelay = 500;
        }
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox5, "Squid Burger");
            tt.InitialDelay = 500;
        }
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox6, "White Burger");
            tt.InitialDelay = 500;
        }
        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox7, "Egg Burger");
            tt.InitialDelay = 500;
        }
        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox8, "Fancy Burger");
            tt.InitialDelay = 500;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pedido[0] = !pedido[0];

            if (pedido[0])
            {
                hamburguesa = chef.PrepararHamburguesa(new BurgerBurger(CarneEnum.Pollo, PanEnum.Centeno));
                lista.Add(hamburguesa);
                total += hamburguesa.Costo;
            }
            else
            {
                int i = 0;
                foreach(Hamburguesa h in lista)
                {
                    if (h.Nombre == "BurgerBurger")
                    {
                        lista.RemoveAt(i);
                        total -= h.Costo;
                        break;
                    }
                    i++;
                }
            }

            if (lista.Count > 0)
            {
                richTextBox1.Text = "";
                foreach (Hamburguesa h in lista)
                {
                    richTextBox1.Text += h.ToString() + "\n";
                }
            }
            else
                richTextBox1.Text = "";

            label2.Text = "$" + total.ToString();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            pedido[1] = !pedido[1];
            if (pedido[1])
            {
                hamburguesa = chef.PrepararHamburguesa(new MexBurger(CarneEnum.Res, PanEnum.Maíz));
                lista.Add(hamburguesa);
                total += hamburguesa.Costo;
            }
            else
            {
                int i = 0;
                foreach (Hamburguesa h in lista)
                {
                    if (h.Nombre == "MexBurger")
                    {
                        lista.RemoveAt(i);
                        total -= h.Costo;
                        break;
                    }
                    i++;
                }
            }

            if (lista.Count > 0)
            {
                richTextBox1.Text = "";
                foreach (Hamburguesa h in lista)
                {
                    richTextBox1.Text += h.ToString() + "\n";
                }
            }
            else
                richTextBox1.Text = "";

            label2.Text = "$" + total.ToString();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            pedido[2] = !pedido[2];
            if (pedido[2])
            {
                hamburguesa = chef.PrepararHamburguesa(new QuesosBurger(CarneEnum.Ternera, PanEnum.Crujiente));
                lista.Add(hamburguesa);
                total += hamburguesa.Costo;
            }
            else
            {
                int i = 0;
                foreach (Hamburguesa h in lista)
                {
                    if (h.Nombre == "QuesosBurger")
                    {
                        total -= h.Costo;
                        lista.RemoveAt(i);
                        break;
                    }
                    i++;
                }
            }

            if (lista.Count > 0)
            {
                richTextBox1.Text = "";
                foreach (Hamburguesa h in lista)
                {
                    richTextBox1.Text += h.ToString() + "\n";
                }
            }
            else
                richTextBox1.Text = "";

            label2.Text = "$" + total.ToString();

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            pedido[7] = !pedido[7];
            if (pedido[7])
            {
                hamburguesa = chef.PrepararHamburguesa(new FancyBurger(CarneEnum.Pavo, PanEnum.Trigo));
                lista.Add(hamburguesa);
                total += hamburguesa.Costo;
            }
            else
            {
                int i = 0;
                foreach (Hamburguesa h in lista)
                {
                    if (h.Nombre == "FancyBurger")
                    {
                        total -= h.Costo;
                        lista.RemoveAt(i);
                        break;
                    }
                    i++;
                }
            }

            if (lista.Count > 0)
            {
                richTextBox1.Text = "";
                foreach (Hamburguesa h in lista)
                {
                    richTextBox1.Text += h.ToString() + "\n";
                }
            }
            else
                richTextBox1.Text = "";

            label2.Text = "$" + total.ToString();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            pedido[3] = !pedido[3];
            if (pedido[3])
            {
                hamburguesa = chef.PrepararHamburguesa(new HawaiiBurger(CarneEnum.Puerco, PanEnum.Espalta));
                lista.Add(hamburguesa);
                total += hamburguesa.Costo;
            }
            else
            {
                int i = 0;
                foreach (Hamburguesa h in lista)
                {
                    if (h.Nombre == "HawaiiBurger")
                    {
                        total -= h.Costo;
                        lista.RemoveAt(i);
                        break;
                    }
                    i++;
                }
            }

            if (lista.Count > 0)
            {
                richTextBox1.Text = "";
                foreach (Hamburguesa h in lista)
                {
                    richTextBox1.Text += h.ToString() + "\n";
                }
            }
            else
                richTextBox1.Text = "";

            label2.Text = "$" + total.ToString();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            pedido[6] = !pedido[6];
            if (pedido[6])
            {
                hamburguesa = chef.PrepararHamburguesa(new EggBurger(CarneEnum.Puerco, PanEnum.Espalta));
                lista.Add(hamburguesa);
                total += hamburguesa.Costo;
            }
            else
            {
                int i = 0;
                foreach (Hamburguesa h in lista)
                {
                    if (h.Nombre == "EggBurger")
                    {
                        total -= h.Costo;
                        lista.RemoveAt(i);
                        break;
                    }
                    i++;
                }
            }

            if (lista.Count > 0)
            {
                richTextBox1.Text = "";
                foreach (Hamburguesa h in lista)
                {
                    richTextBox1.Text += h.ToString() + "\n";
                }
            }
            else
                richTextBox1.Text = "";

            label2.Text = "$" + total.ToString();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            pedido[5] = !pedido[5];
            if (pedido[5])
            {
                hamburguesa = chef.PrepararHamburguesa(new WhiteBurger(CarneEnum.Pollo, PanEnum.Germinado));
                lista.Add(hamburguesa);
                total += hamburguesa.Costo;
            }
            else
            {
                int i = 0;
                foreach (Hamburguesa h in lista)
                {
                    if (h.Nombre == "WhiteBurger")
                    {
                        total -= h.Costo;
                        lista.RemoveAt(i);
                        break;
                    }
                    i++;
                }
            }

            if (lista.Count > 0)
            {
                richTextBox1.Text = "";
                foreach (Hamburguesa h in lista)
                {
                    richTextBox1.Text += h.ToString() + "\n";
                }
            }
            else
                richTextBox1.Text = "";

            label2.Text = "$" + total.ToString();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            pedido[4] = !pedido[4];
            if (pedido[4])
            {
                hamburguesa = chef.PrepararHamburguesa(new SquidBurger(CarneEnum.Pulpo, PanEnum.Crujiente));
                lista.Add(hamburguesa);
                total += hamburguesa.Costo;
            }
            else
            {
                int i = 0;
                foreach (Hamburguesa h in lista)
                {
                    if (h.Nombre == "SquidBurger")
                    {
                        total -= h.Costo;
                        lista.RemoveAt(i);
                        break;
                    }
                    i++;
                }
            }

            if (lista.Count > 0)
            {
                richTextBox1.Text = "";
                foreach (Hamburguesa h in lista)
                {
                    richTextBox1.Text += h.ToString() + "\n";
                }
            }
            else
                richTextBox1.Text = "";

            label2.Text = "$" + total.ToString();

        }

        void RTBGotFocus(object sender, System.EventArgs e)
        {
            System.Windows.Forms.SendKeys.Send("{tab}");
        }
    }
}
