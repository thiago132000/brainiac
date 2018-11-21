using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balanca3
{
    public partial class tlSalvar : Form
    {
        public tlSalvar()
        {
            InitializeComponent();
        }
        public tlSalvar(string Dados)
        {
            InitializeComponent();

            //Transforma todos os pesos em posições no array
            string[] dados = Dados.Split(' ');

            string penultimo = dados[dados.Length - 3];

            penultimo = Regex.Replace(penultimo, "[^0-9]", "");

            //traz a penúltimo peso da balança e coloca do TextBox(txtRecebe) e passa o TextBox (txtConteudo)
            txtConteudo.Text = penultimo;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                //Passa os dados do TextBox(txtConteudo) para a variavel (dadosTxt)
                string dadosTxt = txtConteudo.Text;

                //Passa os dados do TextBox(txtSalvar) para a variavel (nome)
                string nome = txtSalvar.Text;

                //Só salva se o usuario digitar algo no nome
                if (nome != "")
                {
                    //Cria um txt na pasta pesos com o conteudo do TextBox(txtConteudo)
                    System.IO.File.WriteAllText(@"C:\Pesos\" + nome + ".txt", dadosTxt + Environment.NewLine);

                    //Mostra uma mensagem
                    MessageBox.Show("Salvo com Sucesso!!!");

                    //Fecha a janela e volta para outra
                    this.Close();
                }
                else
                {

                    //Mostra uma Mensagem
                    MessageBox.Show("Digite o Nome do Arquivo!!!");

                    //Da um focus no TextBox(txtSalvar)
                    txtSalvar.Focus();

                }
            }
            catch (Exception ex)
            {

                //Caso ocorrer um erro é disparado um alerta na tela
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tlSalvar_Load(object sender, EventArgs e)
        {
            //Desativa o TextBox (txtConteudo)
            txtConteudo.Enabled = false;
        }
    }
}
//Desenvolvido por Thiago.F