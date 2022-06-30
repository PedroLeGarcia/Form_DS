using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClienteDES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fotos_Click(object sender, EventArgs e)
        {
            
        }

        private void carregarfoto_Click(object sender, EventArgs e)
        {
            fotos.Image = Properties.Resources.Minions_Download_PNG_Image;
        }

        private void limparfoto_Click(object sender, EventArgs e)
        {
            fotos.Image = null;
        }

        private void limpartudo_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            nome.Clear();
            rg.Clear();
            cpf.Clear();
            telres.Clear();
            tel.Clear();
            radioButton6.Checked = false;
            radioButton5.Checked = false;
            cep.Clear();
            logradouro.Clear();
            textBox9.Clear();
            bairro.Clear();
            cidade.Clear();
            textBox12.Clear();
            textBox13.Clear();
            checkBox1.Checked = false;
            checkBox3.Checked = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox12.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox13.Focus();
        }

        private void incluir_Click(object sender, EventArgs e)
        {
            textBox1.Text = "112233";
            nome.Text = "Pedro";
            rg.Text = "2233445";
            cpf.Text = "123456767";
            telres.Text = "99 123454565";
            tel.Text = "22234";
            radioButton6.Checked = true;
            radioButton5.Checked = true;
            cep.Text = "11111";
            logradouro.Text = "Rua Goiaba";
            textBox9.Text = "2222222222222222";
            bairro.Text = "Bairro Geise Arruda";
            cidade.Text = "Itariri - SP";
            textBox12.Text = "facebook@gmail.com";
            textBox13.Text = "tuiter@gmail.com";
            checkBox1.Checked = true;
            checkBox3.Checked = true;
            fotos.Image = Properties.Resources.Minions_Download_PNG_Image;


        }

        private void consultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Códigas:" + textBox1 + "\n Nome:" + nome +"\n RG:" + rg +"\n cpf:" + cpf +"\n Tel Res:" + telres+"\n Tel:" + tel+"\n CEP:" + cep+"\n Logradouro:" + logradouro +"\n número:" + textBox9+"\n bairro:" + bairro+"\n cidade:" + cidade+"\n email:" + textBox12 +"\n outro:" + textBox13);
        }
    }
}
