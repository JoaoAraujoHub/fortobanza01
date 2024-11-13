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
    public partial class Product3 : Form
    {
        public Product3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Visible = false; //Esconder tela de login
            form2.ShowDialog(); //Abre a tela principal
            this.Visible = true;  //Voltar a mostrar a tela de login
        }
    }
}
