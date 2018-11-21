using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Puxa a Biblioteca da Serial
using System.IO.Ports;

namespace Balanca3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //O private Form1_Load faz carregadar tudo oque esta dentro dele enquanto o prgrama é aberto
        private void Form1_Load(object sender, EventArgs e)
        {
            //Pega todas as portas COMs Disponiveis
            string[] portas = SerialPort.GetPortNames();

            //Adiciona todas as portas encontradas no ComboBox das Portas
            cbPorta.Items.AddRange(portas);

            //Seleciona a Primeira porta das lista
            cbPorta.SelectedIndex = 0;

            //Enquanto ele não Conectar em alguma porta pelo botão Conectar
            //O Botão Desconectar fica Desabilitado
            btnDesconectar.Enabled = false;

            //Enquanto ele não Conectar em alguma porta pelo botão Conectar
            //O Botão Receber fica Desabilitado
            btnReceber.Enabled = false;

            //Enquanto ele não Conectar em alguma porta pelo botão Conectar
            //O Botão Parar fica Desabilitado
            btnParar.Enabled = false;

            //Desativa o txt para não ser editado
            txtRecebe.Enabled = false;



        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Se eu Conectar em alguma porta o Botão Conectar é Desabiltado 
            btnConectar.Enabled = false;

            //Assim que ocorrer uma conexão eo botão conectar for Desabiltado
            //O Desconectar é Habiltado
            btnDesconectar.Enabled = true;

            //Se for efetuada uma conexão o ComBox (cbPorta) é desabiltado
            cbPorta.Enabled = false;

            //O Botão Receber fica Habiltado
            btnReceber.Enabled = true;



            try
            {

                //A serial que for escolhida é passado para a função Serial
                serialPort1.PortName = cbPorta.Text;

                //Despois de passar a porta escolhida ela é aberta para fazer uma conexão
                serialPort1.Open();

            }
            catch (Exception ex)
            {

                //Caso ocorrer um erro é disparado um alerta na tela
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void btnReceber_Click(object sender, EventArgs e)
        {
            try
            {
                //O Botão Parar fica Habilitado
                btnParar.Enabled = true;

                //O Botão Receber fica Desabilitado
                btnReceber.Enabled = false;

                //Condição que só ocorre se a porta escolhioda estiver aberta
                if (serialPort1.IsOpen)
                {

                    //Inicia a transmissão de dados com a serial
                    timer1.Start();

                }


            }
            catch (Exception ex)
            {

                //Caso ocorrer um erro é disparado um alerta na tela
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            //Se eu Desconetar da porta o Botão Conectar é Habiltado 
            btnConectar.Enabled = true;

            //Assim que Desconectar botão é desabilitado
            btnDesconectar.Enabled = false;

            //Se for desconectado o ComBox (cbPorta) é Habiltado
            cbPorta.Enabled = true;

            //O Botão Receber fica Desabiltado
            btnReceber.Enabled = false;

            //O Botão Parar fica Desabilitado
            btnParar.Enabled = false;

            try
            {

                //Para a transmissão de dados com a serial
                timer1.Stop();

                //A porta que foi aberta para conexão é Desconectada
                serialPort1.Close();

                //Limpa a TextBox (txtRecebe)
                txtRecebe.Clear();

            }
            catch (Exception ex)
            {

                //Caso ocorrer um erro é disparado um alerta na tela
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Condição que só ocorre se a porta escolhioda estiver aberta
            if (serialPort1.IsOpen)
            {

                //A porta que foi aberta para conexão é Desconectada se caso o usuario fechar o programa
                serialPort1.Close();

                //Para a transmissão de dados com a serial
                timer1.Stop();

            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //Condição que só ocorre se a porta escolhioda estiver aberta
                if (serialPort1.IsOpen)
                {
                    if (txtRecebe.Text != "")
                    {


                        //Para a transmissão de dados com a serial
                        timer1.Stop();

                        //O Botão Parar fica Desabilitado
                        btnParar.Enabled = false;

                        btnReceber.Enabled = true;

                        //Passa os dados do TextBox(txtRecebe) para a tela salvar
                        tlSalvar salvar = new tlSalvar(txtRecebe.Text);

                        //Limpa a TextBox (txtRecebe)
                        txtRecebe.Clear();

                        //Abre a tela Salvar
                        salvar.ShowDialog();
                    }
                    else
                    {


                        //Mostra uma Mensagem
                        MessageBox.Show("Nenhum Dado Recebido Tente outra Porta!!!");

                        //O Botão Conectar fica Habilitado
                        btnConectar.Enabled = true;

                        //O Botão Desconectar fica Desabilitado
                        btnDesconectar.Enabled = false;

                        //O Combo Box (cbPorta) é Habilitado
                        cbPorta.Enabled = true;

                        //O Botão Receber fica Desabilitado
                        btnReceber.Enabled = false;

                        //O Botão Parar fica Desabilitado
                        btnParar.Enabled = false;

                        //O Combo Box (cbPorta) é focado
                        cbPorta.Focus();

                        try
                        {

                            //Para a transmissão de dados com a serial
                            timer1.Stop();

                            //A porta que foi aberta para conexão é Desconectada
                            serialPort1.Close();

                        }
                        catch (Exception ex)
                        {

                            //Caso ocorrer um erro é disparado um alerta na tela
                            MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }



                }

            }
            catch (Exception ex)
            {

                //Caso ocorrer um erro é disparado um alerta na tela
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                if (serialPort1.IsOpen)
                {
                    //Variavel que recebe todos os dados buscados na porta serial
                    string dados = serialPort1.ReadExisting();

                    //Se a variavel não estiver vazia entra nesta condição
                    if (dados != "")
                    {

                        //Adiciona oque foi buscado ao TextBox (txtRecebe)
                        txtRecebe.AppendText(dados);

                    }
                }
            }
            catch (Exception ex)
            {

                //Caso ocorrer um erro é disparado um alerta na tela
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
//Desenvolvido por Thiago.F