using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerInterfazGrafica
{
    public partial class frmMiCalculadora : Form
    {
        double numero1, numero2;
        char operador;
        public frmMiCalculadora()
        {
            InitializeComponent();
        }
        private void frmMiCalculadora_Load(object sender, EventArgs e)
        {
            tbxCalculo.Text = "0";
        }
        public void cargarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (tbxCalculo.Text == "0")
            {
                tbxCalculo.Text = "";
                tbxCalculo.Text += boton.Text;
            }
            else
                tbxCalculo.Text += boton.Text;

        }
        public void cargarOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            numero1 = Convert.ToDouble(tbxCalculo.Text);
            operador = Convert.ToChar(boton.Tag);

            if(operador == '²')
            {
                numero1 = Math.Pow(numero1, 2);
                tbxCalculo.Text = numero1.ToString();
            }else if(operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                tbxCalculo.Text = numero1.ToString();
            }
            else
                tbxCalculo.Text = "0";
        }
        private void btnBorrarCaracter_Click(object sender, EventArgs e)
        {
            if (tbxCalculo.Text.Length > 1)
                tbxCalculo.Text = tbxCalculo.Text.Substring(0, tbxCalculo.Text.Length - 1);
            else
                tbxCalculo.Text = "0";
        }
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador = '\0';
            tbxCalculo.Text = "0";
        }
        private void btnBorarr_Click(object sender, EventArgs e)
        {
            tbxCalculo.Text = "0";
        }
        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!tbxCalculo.Text.Contains(','))
                tbxCalculo.Text += ',';
        }
        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(tbxCalculo.Text);
            numero1 *= -1;
            tbxCalculo.Text = numero1.ToString();
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(tbxCalculo.Text);

            if (operador == '+')
                tbxCalculo.Text = (numero1 + numero2).ToString();
            else if (operador == '-')
                tbxCalculo.Text = (numero1 - numero2).ToString();
            else if (operador == 'x')
                tbxCalculo.Text = (numero1 * numero2).ToString();
            else if (operador == '/')
            {
                if (numero2 != 0)
                    tbxCalculo.Text = (numero1 / numero2).ToString();
                else
                {
                    MessageBox.Show("No es posible dividir por 0");
                    numero1 = 0;
                    numero2 = 0;
                    operador = '\0';
                    tbxCalculo.Text = "0";
                    return;
                }
            }
            numero1 = Convert.ToDouble(tbxCalculo.Text);
        }


    }
}