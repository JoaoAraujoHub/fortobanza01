namespace fortobanza1
{
    partial class Carrinho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrinho));
            this.LogoBox2 = new System.Windows.Forms.PictureBox();
            this.LogoBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoBox2
            // 
            this.LogoBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.LogoBox2.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox2.Image")));
            this.LogoBox2.Location = new System.Drawing.Point(21, 12);
            this.LogoBox2.Name = "LogoBox2";
            this.LogoBox2.Size = new System.Drawing.Size(45, 50);
            this.LogoBox2.TabIndex = 0;
            this.LogoBox2.TabStop = false;
            this.LogoBox2.Click += new System.EventHandler(this.LogoBox2_Click);
            // 
            // LogoBox1
            // 
            this.LogoBox1.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox1.Image")));
            this.LogoBox1.Location = new System.Drawing.Point(369, 132);
            this.LogoBox1.Name = "LogoBox1";
            this.LogoBox1.Size = new System.Drawing.Size(66, 71);
            this.LogoBox1.TabIndex = 1;
            this.LogoBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(338, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 136);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkEx BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seu carrinho está vazio";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(281, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar novos produtos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogoBox1);
            this.Controls.Add(this.LogoBox2);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carrinho";
            this.Text = "Souce";
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoBox2;
        private System.Windows.Forms.PictureBox LogoBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}