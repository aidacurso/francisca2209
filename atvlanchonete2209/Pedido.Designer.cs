
namespace atvlanchonete2209
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textLanche = new System.Windows.Forms.TextBox();
            this.textBebida = new System.Windows.Forms.TextBox();
            this.labelLanche = new System.Windows.Forms.Label();
            this.labelBebida = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelPedido = new System.Windows.Forms.Label();
            this.iconePedido = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconCardapio = new FontAwesome.Sharp.IconButton();
            this.iconPedido = new FontAwesome.Sharp.IconButton();
            this.iconCadastrarCliente = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconePedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.Controls.Add(this.buttonSalvar);
            this.panel3.Controls.Add(this.textLanche);
            this.panel3.Controls.Add(this.textBebida);
            this.panel3.Controls.Add(this.labelLanche);
            this.panel3.Controls.Add(this.labelBebida);
            this.panel3.Controls.Add(this.labelTitulo);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(193, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 450);
            this.panel3.TabIndex = 3;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Location = new System.Drawing.Point(236, 276);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar pedido";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // textLanche
            // 
            this.textLanche.Location = new System.Drawing.Point(223, 224);
            this.textLanche.Name = "textLanche";
            this.textLanche.Size = new System.Drawing.Size(100, 23);
            this.textLanche.TabIndex = 5;
            // 
            // textBebida
            // 
            this.textBebida.Location = new System.Drawing.Point(223, 170);
            this.textBebida.Name = "textBebida";
            this.textBebida.Size = new System.Drawing.Size(100, 23);
            this.textBebida.TabIndex = 4;
            // 
            // labelLanche
            // 
            this.labelLanche.AutoSize = true;
            this.labelLanche.ForeColor = System.Drawing.Color.White;
            this.labelLanche.Location = new System.Drawing.Point(131, 227);
            this.labelLanche.Name = "labelLanche";
            this.labelLanche.Size = new System.Drawing.Size(86, 15);
            this.labelLanche.TabIndex = 3;
            this.labelLanche.Text = "Digite o lanche";
            // 
            // labelBebida
            // 
            this.labelBebida.AutoSize = true;
            this.labelBebida.ForeColor = System.Drawing.Color.White;
            this.labelBebida.Location = new System.Drawing.Point(131, 173);
            this.labelBebida.Name = "labelBebida";
            this.labelBebida.Size = new System.Drawing.Size(86, 15);
            this.labelBebida.TabIndex = 2;
            this.labelBebida.Text = "Digite a bebida";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(196, 121);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(152, 28);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Faça seu pedido";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.labelPedido);
            this.panel4.Controls.Add(this.iconePedido);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 100);
            this.panel4.TabIndex = 0;
            // 
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPedido.ForeColor = System.Drawing.Color.White;
            this.labelPedido.Location = new System.Drawing.Point(85, 39);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(122, 28);
            this.labelPedido.TabIndex = 3;
            this.labelPedido.Text = "fazer pedido";
            // 
            // iconePedido
            // 
            this.iconePedido.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconePedido.IconChar = FontAwesome.Sharp.IconChar.PollH;
            this.iconePedido.IconColor = System.Drawing.Color.White;
            this.iconePedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconePedido.IconSize = 53;
            this.iconePedido.Location = new System.Drawing.Point(36, 30);
            this.iconePedido.Name = "iconePedido";
            this.iconePedido.Size = new System.Drawing.Size(53, 53);
            this.iconePedido.TabIndex = 2;
            this.iconePedido.TabStop = false;
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
            this.iconCardapio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.iconPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconPedido.UseVisualStyleBackColor = true;
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
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconePedido)).EndInit();
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
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textLanche;
        private System.Windows.Forms.TextBox textBebida;
        private System.Windows.Forms.Label labelLanche;
        private System.Windows.Forms.Label labelBebida;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelPedido;
        private FontAwesome.Sharp.IconPictureBox iconePedido;
    }
}