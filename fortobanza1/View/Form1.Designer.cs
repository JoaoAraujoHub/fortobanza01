namespace fortobanza1
{
    partial class Plano
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plano));
            this.espaço1 = new System.Windows.Forms.Label();
            this.Espaço = new System.Windows.Forms.Panel();
            this.adivButton = new System.Windows.Forms.Button();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Espaço.SuspendLayout();
            this.SuspendLayout();
            // 
            // espaço1
            // 
            this.espaço1.AutoSize = true;
            this.espaço1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.espaço1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espaço1.ForeColor = System.Drawing.Color.Black;
            this.espaço1.Location = new System.Drawing.Point(241, 65);
            this.espaço1.Name = "espaço1";
            this.espaço1.Size = new System.Drawing.Size(385, 29);
            this.espaço1.TabIndex = 0;
            this.espaço1.Text = "Crie sua conta souce!";
            // 
            // Espaço
            // 
            this.Espaço.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Espaço.Controls.Add(this.adivButton);
            this.Espaço.Controls.Add(this.txbPass);
            this.Espaço.Controls.Add(this.label3);
            this.Espaço.Controls.Add(this.txbUser);
            this.Espaço.Controls.Add(this.label2);
            this.Espaço.Location = new System.Drawing.Point(262, 130);
            this.Espaço.Name = "Espaço";
            this.Espaço.Size = new System.Drawing.Size(339, 268);
            this.Espaço.TabIndex = 1;
            // 
            // adivButton
            // 
            this.adivButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adivButton.Location = new System.Drawing.Point(239, 212);
            this.adivButton.Name = "adivButton";
            this.adivButton.Size = new System.Drawing.Size(81, 39);
            this.adivButton.TabIndex = 4;
            this.adivButton.Text = "Avançar";
            this.adivButton.UseVisualStyleBackColor = true;
            this.adivButton.Click += new System.EventHandler(this.adivButton_Click);
            // 
            // txbPass
            // 
            this.txbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.Location = new System.Drawing.Point(22, 152);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(274, 24);
            this.txbPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // txbUser
            // 
            this.txbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.Location = new System.Drawing.Point(22, 76);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(274, 24);
            this.txbUser.TabIndex = 1;
            this.txbUser.TextChanged += new System.EventHandler(this.txbUser_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-mail";
            // 
            // Plano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Espaço);
            this.Controls.Add(this.espaço1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Plano";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Plano_Load);
            this.Espaço.ResumeLayout(false);
            this.Espaço.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label espaço1;
        private System.Windows.Forms.Panel Espaço;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Button adivButton;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label label3;
    }
}

