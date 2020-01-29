using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_imc
{
    public partial class FrmImc : Form
    {
        public FrmImc()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            /*declaracao de variaveis
             * variavel recebe o conteudo do textbox*/
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            /* textbox recebe o conteudo da variavel imc = 
             * resultado do calculo
             * definicao de utilizacao de 2 casas decimais*/
            txtImc.Text = imc.ToString("0.00");
            /*Condições de acordo com o resultado dos calculos
             * serão exibidas mensagens
             * configuração das messabox, (mensagens, botens, icones)
             * como sao varias condiçoes temos um encadeamento de ifs*/
            if (imc < 18.49)
                MessageBox.Show("SITUAÇÃO: Você esta abaixo do peso", "calculo de imc ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("SITUAÇÃO:Você esta com Peso dentro da normalidade",
                    "calculo de imc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("SITUAÇÃO: Você esta acima do peso", "calculo de imc",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("Atenção! Você esta com obesidade de grau I", "calculo de imc",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("SITUAÇÃO: Você esta com obesidade de grau II", "calculo de imc",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("Atenção! Você esta com obesidade de grau III (Morbida)", "calculo de imc",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

            
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtImc.Text = "";
        }
    }
}
