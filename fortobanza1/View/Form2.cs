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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Product1 form2 = new Product1();
            this.Visible = false; //Esconder tela de login
            form2.ShowDialog(); //Abre a tela principal
            this.Visible = true;  //Voltar a mostrar a tela de login
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Product2 form2 = new Product2();
            this.Visible = false; //Esconder tela de login
            form2.ShowDialog(); //Abre a tela principal
            this.Visible = true;  //Voltar a mostrar a tela de login
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Product3 form2 = new Product3();
            this.Visible = false; //Esconder tela de login
            form2.ShowDialog(); //Abre a tela principal
            this.Visible = true;  //Voltar a mostrar a tela de login
        }
    }
}
