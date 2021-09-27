
namespace atvlanchonete2209
{
    partial class Cardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cardapio));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelCardapio = new System.Windows.Forms.Label();
            this.iconcardap = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconCardapio = new FontAwesome.Sharp.IconButton();
            this.iconPedido = new FontAwesome.Sharp.IconButton();
            this.iconCadastrarCliente = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcardap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(193, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 450);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.labelCardapio);
            this.panel4.Controls.Add(this.iconcardap);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 100);
            this.panel4.TabIndex = 0;
            // 
            // labelCardapio
            // 
            this.labelCardapio.AutoSize = true;
            this.labelCardapio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCardapio.ForeColor = System.Drawing.Color.White;
            this.labelCardapio.Location = new System.Drawing.Point(102, 39);
            this.labelCardapio.Name = "labelCardapio";
            this.labelCardapio.Size = new System.Drawing.Size(121, 28);
            this.labelCardapio.TabIndex = 3;
            this.labelCardapio.Text = "ver cardápio";
            this.labelCardapio.Click += new System.EventHandler(this.labelCardapio_Click);
            // 
            // iconcardap
            // 
            this.iconcardap.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconcardap.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconcardap.IconColor = System.Drawing.Color.White;
            this.iconcardap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcardap.IconSize = 53;
            this.iconcardap.Location = new System.Drawing.Point(53, 30);
            this.iconcardap.Name = "iconcardap";
            this.iconcardap.Size = new System.Drawing.Size(53, 53);
            this.iconcardap.TabIndex = 2;
            this.iconcardap.TabStop = false;
            this.iconcardap.Click += new System.EventHandler(this.iconcardap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.iconCardapio);
            this.panel1.Controls.Add(this.iconPedido);
            this.panel1.Controls.Add(this.iconCadastrarCliente);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 450);
            this.panel1.TabIndex = 2;
            // 
            // iconCardapio
            // 
            this.iconCardapio.AutoSize = true;
            this.iconCardapio.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconCardapio.FlatAppearance.BorderSize = 0;
            this.iconCardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCardapio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconCardapio.ForeColor = System.Drawing.Color.White;
            this.iconCardapio.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconCardapio.IconColor = System.Drawing.Color.White;
            this.iconCardapio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCardapio.IconSize = 35;
            this.iconCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCardapio.Location = new System.Drawing.Point(0, 276);
            this.iconCardapio.Name = "iconCardapio";
            this.iconCardapio.Size = new System.Drawing.Size(193, 49);
            this.iconCardapio.TabIndex = 4;
            this.iconCardapio.Text = "ver cardápio";
            this.iconCardapio.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconCardapio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconCardapio.UseVisualStyleBackColor = true;
            this.iconCardapio.Click += new System.EventHandler(this.iconCardapio_Click);
            // 
            // iconPedido
            // 
            this.iconPedido.AutoSize = true;
            this.iconPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPedido.FlatAppearance.BorderSize = 0;
            this.iconPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPedido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconPedido.ForeColor = System.Drawing.Color.White;
            this.iconPedido.IconChar = FontAwesome.Sharp.IconChar.PollH;
            this.iconPedido.IconColor = System.Drawing.Color.White;
            this.iconPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPedido.IconSize = 35;
            this.iconPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconPedido.Location = new System.Drawing.Point(0, 227);
            this.iconPedido.Name = "iconPedido";
            this.iconPedido.Size = new System.Drawing.Size(193, 49);
            this.iconPedido.TabIndex = 3;
            this.iconPedido.Text = "fazer pedido";
            this.iconPedido.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPedido.UseVisualStyleBackColor = true;
            this.iconPedido.Click += new System.EventHandler(this.iconPedido_Click);
            // 
            // iconCadastrarCliente
            // 
            this.iconCadastrarCliente.AutoSize = true;
            this.iconCadastrarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.iconCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCadastrarCliente.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.iconCadastrarCliente.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconCadastrarCliente.IconColor = System.Drawing.Color.White;
            this.iconCadastrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCadastrarCliente.IconSize = 35;
            this.iconCadastrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCadastrarCliente.Location = new System.Drawing.Point(0, 178);
            this.iconCadastrarCliente.Name = "iconCadastrarCliente";
            this.iconCadastrarCliente.Size = new System.Drawing.Size(193, 49);
            this.iconCadastrarCliente.TabIndex = 2;
            this.iconCadastrarCliente.Text = "cadastrar cliente";
            this.iconCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconCadastrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconCadastrarCliente.UseVisualStyleBackColor = true;
            this.iconCadastrarCliente.Click += new System.EventHandler(this.iconCadastrarCliente_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 178);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Cardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Cardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cardapio";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcardap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconCardapio;
        private FontAwesome.Sharp.IconButton iconPedido;
        private FontAwesome.Sharp.IconButton iconCadastrarCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCardapio;
        private FontAwesome.Sharp.IconPictureBox iconcardap;
    }
}