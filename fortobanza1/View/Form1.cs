using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fortobanza1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var result = MessageBox.Show("E-mail: " + txbUser.Text + "\n" + "Senha: " + txbPass.Text, "Informações digitadas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (txbUser.Text == "joão" && txbPass.Text == "123")
            {
                txbUser.Text = string.Empty; //Limpa o campo de usuario 
                txbPass.Text = string.Empty; //Limpa o campo de senha
                txbUser.Focus(); //Coloca o foco no campo de usuario
                Form2 Form2 = new Form2();
                this.Visible = false; //Esconder tela de login
                Form2.ShowDialog();
                this.Visible = true;  //Voltar a mostrar a tela de login
            }
            else
            {
                MessageBox.Show("Usuario e/ou senha incorretos",
                         "ERRO NO LOGIN",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                txbUser.Text = string.Empty; //Limpa o campo de usuario 
                txbPass.Text = string.Empty; //Limpa o campo de senha
                txbUser.Focus(); //Coloca o foco no campo de usuario
            }
        }

        private void btmAvançar_Click(object sender, EventArgs e)
        {
        }
    }   
}