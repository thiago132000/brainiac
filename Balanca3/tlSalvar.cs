using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            try
            {
                //Transforma todos os pesos em posições no array
                string[] dados = Dados.Split(' ');

                //Pega o penultimo peso
                string penultimo = dados[dados.Length - 3];

                //Tira todos os caracteres especiais
                penultimo = Regex.Replace(penultimo, "[^0-9]", "");

                for (int i = 0; i < penultimo.Length; i++)
                {

                    //Coloca uma virgula para separar os inteiros dos decimais
                    if (i == 3)
                    {
                        penultimo = penultimo.Insert(i, ",");
                    }
                    //Da um espaço para facilitar a retirada de numeros desnecessarios
                    if (i == 7)
                    {
                        penultimo = penultimo.Insert(i, " ");
                    }

                }

                //Separa o numero formado dos numeros denesesarios
                string[] peso = penultimo.Split(' ');

                //Passa para o TextBox (txtConteudo) o numero final
                txtConteudo.Text = peso[0];

            }
            catch (Exception ex)
            {

                //Caso ocorrer um erro é disparado um alerta na tela
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {

                //nome do diretorio a ser criado
                string pasta = @"C:\Pesos";

                //Se o diretório não existir...
                if (!Directory.Exists(pasta))
                {

                    //Criamos um com o nome pasta
                    Directory.CreateDirectory(pasta);

                }

                //Passa os dados do TextBox(txtConteudo) para a variavel (dadosTxt)
                string dadosTxt = txtConteudo.Text;

                //Passa os dados do TextBox(txtSalvar) para a variavel (nome)
                string nome = txtSalvar.Text;

                //Só salva se o usuario digitar algo no nome
                if (nome != "")
                {
                    //Cria um txt na pasta pesos com o conteudo do TextBox(txtConteudo)
                    System.IO.File.WriteAllText(@"C:\Pesos\" + nome + ".txt", dadosTxt + Environment.NewLine + " ");

                    //Mostra uma mensagem
                    MessageBox.Show("Salvo com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Fecha a janela e volta para outra
                    this.Close();
                }
                else
                {

                    //Mostra uma Mensagem
                    MessageBox.Show("Digite o Nome do Arquivo", "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

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