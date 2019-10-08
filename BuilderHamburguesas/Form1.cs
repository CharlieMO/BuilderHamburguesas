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
        //private List<Hamburguesa> lista = new List<Hamburguesa>();
        private double total;
        Platillo _platillo;
        private List<IComida> lista = new List<IComida>();

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

            pictureBox9.Image = BuilderHamburguesas.Properties.Resources.B1;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox10.Image = BuilderHamburguesas.Properties.Resources.B2;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox11.Image = BuilderHamburguesas.Properties.Resources.B3;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox12.Image = BuilderHamburguesas.Properties.Resources.B4;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox13.Image = BuilderHamburguesas.Properties.Resources.B5;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox14.Image = BuilderHamburguesas.Properties.Resources.S1;
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox15.Image = BuilderHamburguesas.Properties.Resources.S2;
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox16.Image = BuilderHamburguesas.Properties.Resources.S3;
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox17.Image = BuilderHamburguesas.Properties.Resources.S4;
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox18.Image = BuilderHamburguesas.Properties.Resources.S5;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;

            MessageBox.Show("Click derecho: eliminar platillo. \nClick izquierdo: añadir platillo.");

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

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox9, "Baguette Albóndiga");
            tt.InitialDelay = 500;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox10, "Baguette de Pavo");
            tt.InitialDelay = 500;
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox11, "Baguette de Pulpo");
            tt.InitialDelay = 500;
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox12, "Baguette de Pollo");
            tt.InitialDelay = 500;
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox13, "Subway");
            tt.InitialDelay = 500;
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox14, "Sandwich Rata");
            tt.InitialDelay = 500;
        }

        private void pictureBox15_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox15, "Sandwich Milanesa");
            tt.InitialDelay = 500;
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox16, "Sandwich Pulpo");
            tt.InitialDelay = 500;
        }

        private void pictureBox17_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox17, "Sandwich de Miga");
            tt.InitialDelay = 500;
        }

        private void pictureBox18_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox18, "Sandwich de Ternera");
            tt.InitialDelay = 500;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            var pic = (sender as PictureBox).Name;//pic is the Name of the PictureBox that is clicked
            switch (e.Button)
            {
                case MouseButtons.Right:
                {
                    int i = 0;
                    foreach (IComida h in lista)
                    {
                        if ((sender as PictureBox).Name == "pictureBox5")
                            {
                                if(h.Nombre == "SquidBurger")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }
                        else if ((sender as PictureBox).Name == "pictureBox1")
                            {
                                if (h.Nombre == "BurgerBurger")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }
                            else if ((sender as PictureBox).Name == "pictureBox2")
                            {
                                if (h.Nombre == "MexBurger")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }
                            else if ((sender as PictureBox).Name == "pictureBox3")
                            {
                                if (h.Nombre == "QuesosBurger")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }
                            else if ((sender as PictureBox).Name == "pictureBox4")
                            {
                                if (h.Nombre == "HawaiiBurger")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }
                            else if ((sender as PictureBox).Name == "pictureBox6")
                            {
                                if (h.Nombre == "WhiteBurger")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }
                            else if ((sender as PictureBox).Name == "pictureBox7")
                            {
                                if (h.Nombre == "EggBurger")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }
                            else if ((sender as PictureBox).Name == "pictureBox8")
                            {
                                if (h.Nombre == "FancyBurger")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }
                            else if ((sender as PictureBox).Name == "pictureBox9")
                            {
                                if (h.Nombre == "BaguetteAlbondiga")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }
                            else if ((sender as PictureBox).Name == "pictureBox10")
                            {
                                if (h.Nombre == "BaguettePavo")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }

                            else if ((sender as PictureBox).Name == "pictureBox11")
                            {
                                if (h.Nombre == "BaguettePulpo")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }

                            else if ((sender as PictureBox).Name == "pictureBox12")
                            {
                                if (h.Nombre == "BaguettePollo")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }

                            else if ((sender as PictureBox).Name == "pictureBox13")
                            {
                                if (h.Nombre == "Subway")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }

                            else if ((sender as PictureBox).Name == "pictureBox14")
                            {
                                if (h.Nombre == "SandwichRata")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }

                            else if ((sender as PictureBox).Name == "pictureBox15")
                            {
                                if (h.Nombre == "SandwichMilanesa")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }

                            else if ((sender as PictureBox).Name == "pictureBox16")
                            {
                                if (h.Nombre == "SandwichPulpo")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }

                            else if ((sender as PictureBox).Name == "pictureBox17")
                            {
                                if (h.Nombre == "SandwichMiga")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }

                            else if ((sender as PictureBox).Name == "pictureBox18")
                            {
                                if (h.Nombre == "SandwichTernera")
                                {
                                    total -= h.Costo;
                                    lista.RemoveAt(i);
                                    break;
                                }
                            }

                            i++;
                        }
                        updatelista();
                        break;
                }

                case MouseButtons.Left:
                    {
                        if ((sender as PictureBox).Name == "pictureBox5")
                            _platillo = new SquidBurger(CarneEnum.Pulpo, PanEnum.Crujiente);
                            //hamburguesa = chef.PrepararHamburguesa(new SquidBurger(CarneEnum.Pulpo, PanEnum.Crujiente));
                        else if ((sender as PictureBox).Name == "pictureBox1")
                            _platillo = new BurgerBurger(CarneEnum.Pollo, PanEnum.Centeno);
                            //hamburguesa = chef.PrepararHamburguesa(new BurgerBurger(CarneEnum.Pollo, PanEnum.Centeno));
                        else if ((sender as PictureBox).Name == "pictureBox2")
                            _platillo = new MexBurger(CarneEnum.Res, PanEnum.Maíz);
                            //hamburguesa = chef.PrepararHamburguesa(new MexBurger(CarneEnum.Res, PanEnum.Maíz));
                        else if ((sender as PictureBox).Name == "pictureBox3")
                            _platillo = new QuesosBurger(CarneEnum.Ternera, PanEnum.Crujiente);
                            //hamburguesa = chef.PrepararHamburguesa(new QuesosBurger(CarneEnum.Ternera, PanEnum.Crujiente));
                        else if ((sender as PictureBox).Name == "pictureBox4")
                            _platillo = new HawaiiBurger(CarneEnum.Puerco, PanEnum.Espalta);
                            //hamburguesa = chef.PrepararHamburguesa(new HawaiiBurger(CarneEnum.Puerco, PanEnum.Espalta));
                        else if ((sender as PictureBox).Name == "pictureBox6")
                            _platillo = new WhiteBurger(CarneEnum.Pollo, PanEnum.Germinado);
                            //hamburguesa = chef.PrepararHamburguesa(new WhiteBurger(CarneEnum.Pollo, PanEnum.Germinado));
                        else if ((sender as PictureBox).Name == "pictureBox7")
                            _platillo = new EggBurger(CarneEnum.Puerco, PanEnum.Espalta);
                            //hamburguesa = chef.PrepararHamburguesa(new EggBurger(CarneEnum.Puerco, PanEnum.Espalta));
                        else if ((sender as PictureBox).Name == "pictureBox8")
                            _platillo = new FancyBurger(CarneEnum.Pavo, PanEnum.Trigo);
                        //hamburguesa = chef.PrepararHamburguesa(new FancyBurger(CarneEnum.Pavo, PanEnum.Trigo));
                        else if ((sender as PictureBox).Name == "pictureBox9")
                            _platillo = new BaguetteAlbondiga(CarneEnum.Res, PanEnum.Trigo);
                        else if ((sender as PictureBox).Name == "pictureBox10")
                            _platillo = new BaguettePavo(CarneEnum.Pavo, PanEnum.Crujiente);
                        else if ((sender as PictureBox).Name == "pictureBox11")
                            _platillo = new BaguettePulpo(CarneEnum.Pulpo, PanEnum.Germinado);
                        else if ((sender as PictureBox).Name == "pictureBox12")
                            _platillo = new BaguettePollo(CarneEnum.Pollo, PanEnum.Espalta);
                        else if ((sender as PictureBox).Name == "pictureBox13")
                            _platillo = new BaguetteSubway(CarneEnum.Ternera, PanEnum.Maíz);
                        else if ((sender as PictureBox).Name == "pictureBox14")
                            _platillo = new SandwichRata(CarneEnum.Ternera, PanEnum.Trigo);
                        else if ((sender as PictureBox).Name == "pictureBox15")
                            _platillo = new SandwichMilanesa(CarneEnum.Res, PanEnum.Espalta);
                        else if ((sender as PictureBox).Name == "pictureBox16")
                            _platillo = new SandwichPulpo(CarneEnum.Pulpo, PanEnum.Centeno);
                        else if ((sender as PictureBox).Name == "pictureBox17")
                            _platillo = new SandwichMiga(CarneEnum.Oveja, PanEnum.Centeno);
                        else if ((sender as PictureBox).Name == "pictureBox18")
                            _platillo = new SandwichTernera(CarneEnum.Ternera, PanEnum.Centeno);

                        //lista.Add(hamburguesa);
                        //total += hamburguesa.Costo;

                        IComida comida = _platillo.PrepararPlatillo();
                        lista.Add(comida);
                        total += comida.Costo;

                        updatelista();
                        break;
                    }
            }
        }

        private void updatelista()
        {
            if (lista.Count > 0)
            {
                richTextBox1.Text = "";
                foreach (IComida h in lista)
                {
                    richTextBox1.Text += h.ToString() + "\n";
                }
            }
            else
                richTextBox1.Text = "";

            label2.Text = "$" + total.ToString();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {

        }
    }
}
