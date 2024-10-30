using fortobanza1.Model;
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
    public partial class Plano : Form
    {
        private object cmbsenha;
        private object txbemail;

        public Plano()
        {
            InitializeComponent();
        }

        private void adivButton_Click(object sender, EventArgs e)
        {
            if (txbUser.Text == "jao" && txbPass.Text == "123")
            {
                txbUser.Text = string.Empty; //Limpa o campo de usuario 
                txbPass.Text = string.Empty; //Limpa o campo de senha
                txbUser.Focus(); //Coloca o foco no campo de usuario
                Product1 form2 = new Product1();
                this.Visible = false; //Esconder tela de login
                form2.ShowDialog(); //Abre a tela principal
                this.Visible = true;  //Voltar a mostrar a tela de login
            }
            else
            {
                MessageBox.Show("Usuario e/ou senha incorretos",
                    "ERRO NO LOGIN",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void txbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Plano_Load(object sender, EventArgs e)
        {
            string senha = txbPass.Text;
            string email = txbUser.Text;

            //Criar objeto do tipo de entidade manipulada.
            Usuario property = new Usuario(senha, email);

            //Criar objeto para interação com o banco de daddos.
            propertyDAO propertyDAO = new propertyDAO();

            //Chama o insert
            propertyDAO.Insert(property);   
        }
    }   
}