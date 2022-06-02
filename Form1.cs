using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Nome: " + tbNome.Text + " \n Email: " + tbEmail.Text + " \n Endereço: " + tbEndereco.Text + " \n Bairro: " + tbBairro.Text + " \n Telefone: " + tbTelefone.Text + " \n Cidade: " + tbCidade.Text + " \n Sexo: " + tbSexo.Text);
            MessageBox.Show("Cadastro efetuado com sucesso.");
            tbNome.Clear();     
            tbEmail.Clear();     
            tbEndereco.Clear();     
            tbBairro.Clear();     
            tbTelefone.Clear();     
            tbCidade.Clear();     
            tbSexo.Clear();
            lbMsg.Text = "CADASTRO EFETUADO COM SUCESSO!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Cancelar");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindos ao meu programa");
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
