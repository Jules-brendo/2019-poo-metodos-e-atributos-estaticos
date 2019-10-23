using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }
        
    private void BotaoCadastro_Click(object sender, EventArgs e)
        {

            //questao 2
            if (comboTipoConta.Text == "Poupança")
                {
                    ContaPoupanca novaConta = new ContaPoupanca();
                    novaConta.Titular = new Cliente(textoTitular.Text);

                    //novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                    //MessageBox.Show("numero: " + novaConta.Numero);

                    //int numero = novaConta.ProximoNumero();
                    //textoNumero.Text = numero.ToString();

            }
            else {
                   ContaCorrente novaConta = new ContaCorrente();
                    novaConta.Titular = new Cliente(textoTitular.Text);

                    //novaConta.Numero;
                    //novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                    //MessageBox.Show("numero: " + novaConta.Numero);

            }
        }


        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            comboTipoConta.Items.Add("Poupança");
            comboTipoConta.Items.Add("Corrente");
    
            //questão 4
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());

        }
    }
    }

