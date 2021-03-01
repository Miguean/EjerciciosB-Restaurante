using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Cuenta_de_restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int h = 0;
        int hq = 0;
        int hd = 0;
        int papas = 0;
        int malteada = 0;
        int refresco = 0;
        int cafe = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbxCant.Text != "")
            {
                switch (lstProductos.SelectedIndex)
                {
                    case 0:
                        h = Convert.ToInt32(tbxCant.Text);
                        lblResumen.Text += h + " " + lstProductos.SelectedItem.ToString() + "\n";
                        tbxCant.Clear();
                        lstProductos.Focus();
                        break;
                    case 1:
                        hq = Convert.ToInt32(tbxCant.Text);
                        lblResumen.Text += hq + " " + lstProductos.SelectedItem.ToString() + "\n";
                        tbxCant.Clear();
                        lstProductos.Focus();
                        break;
                    case 2:
                        hd = Convert.ToInt32(tbxCant.Text);
                        lblResumen.Text += hd + " " + lstProductos.SelectedItem.ToString() + "\n";
                        tbxCant.Clear();
                        lstProductos.Focus();
                        break;
                    case 3:
                        papas = Convert.ToInt32(tbxCant.Text);
                        lblResumen.Text += papas + " " + lstProductos.SelectedItem.ToString() + "\n";
                        tbxCant.Clear();
                        lstProductos.Focus();
                        break;
                    case 4:
                        malteada = Convert.ToInt32(tbxCant.Text);
                        lblResumen.Text += malteada + " " + lstProductos.SelectedItem.ToString() + "\n";
                        tbxCant.Clear();
                        lstProductos.Focus();
                        break;
                    case 5:
                        refresco = Convert.ToInt32(tbxCant.Text);
                        lblResumen.Text += refresco + " " + lstProductos.SelectedItem.ToString() + "\n";
                        tbxCant.Clear();
                        lstProductos.Focus();
                        break;
                    case 6:
                        cafe = Convert.ToInt32(tbxCant.Text);
                        lblResumen.Text += cafe + " " + lstProductos.SelectedItem.ToString() + "\n";
                        tbxCant.Clear();
                        lstProductos.Focus();
                        break;
                }

            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            tbxTotal.Text = (h * 12 + hq * 15 + hd * 17 + papas * 5 + malteada * 6 + refresco * 5 + cafe * 6).ToString();
            tbxTotal.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResumen.Text = "";
            tbxTotal.Clear();
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;

        }
    }
}
