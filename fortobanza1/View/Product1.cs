using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fortobanza1
{
    public partial class Product1 : Form
    {
        public Product1()
        {
            InitializeComponent();
        }

        private void Product1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O seus produto esta no carrinho");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Visible = false; //Esconder tela de login
            form2.ShowDialog(); //Abre a tela principal
            this.Visible = true;  //Voltar a mostrar a tela de login
        }

        private void btnl_Click(object sender, EventArgs e)
        {

            Admin form2 = new Admin();
            this.Visible = false; //Esconder tela de login
            form2.ShowDialog(); //Abre a tela principal
            this.Visible = true;  //Voltar a mostrar a tela de login
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
