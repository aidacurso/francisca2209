
namespace atvlanchonete2209
{
    partial class Entrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrar));
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogar = new System.Windows.Forms.Button();
            this.linkLabelCadastrar = new System.Windows.Forms.LinkLabel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.iconLogin = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconCardapio = new FontAwesome.Sharp.IconButton();
            this.iconPedido = new FontAwesome.Sharp.IconButton();
            this.iconCadastrarCliente = new FontAwesome.Sharp.IconButton();
            this.iconEntrar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.Controls.Add(this.buttonLogar);
            this.panel3.Controls.Add(this.linkLabelCadastrar);
            this.panel3.Controls.Add(this.labelUsuario);
            this.panel3.Controls.Add(this.labelTitulo);
            this.panel3.Controls.Add(this.textUsuario);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(193, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 450);
            this.panel3.TabIndex = 3;
            // 
            // buttonLogar
            // 
            this.buttonLogar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogar.Location = new System.Drawing.Point(213, 228);
            this.buttonLogar.Name = "buttonLogar";
            this.buttonLogar.Size = new System.Drawing.Size(72, 27);
            this.buttonLogar.TabIndex = 6;
            this.buttonLogar.Text = "Logar";
            this.buttonLogar.UseVisualStyleBackColor = false;
            this.buttonLogar.Click += new System.EventHandler(this.buttonLogar_Click);
            // 
            // linkLabelCadastrar
            // 
            this.linkLabelCadastrar.AutoSize = true;
            this.linkLabelCadastrar.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabelCadastrar.Location = new System.Drawing.Point(409, 103);
            this.linkLabelCadastrar.Name = "linkLabelCadastrar";
            this.linkLabelCadastrar.Size = new System.Drawing.Size(186, 15);
            this.linkLabelCadastrar.TabIndex = 4;
            this.linkLabelCadastrar.TabStop = true;
            this.linkLabelCadastrar.Text = "Não tem cadastro? Cadastre-se já.";
            this.linkLabelCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCadastrar_LinkClicked);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(96, 202);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(98, 15);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Nome de usuário";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(153, 150);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(171, 28);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Entre na sua conta";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(198, 199);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(100, 23);
            this.textUsuario.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.labelLogin);
            this.panel4.Controls.Add(this.iconLogin);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 100);
            this.panel4.TabIndex = 0;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(86, 39);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(64, 28);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "entrar";
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconLogin.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogin.IconSize = 53;
            this.iconLogin.Location = new System.Drawing.Point(37, 30);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(53, 53);
            this.iconLogin.TabIndex = 0;
            this.iconLogin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.iconCardapio);
            this.panel1.Controls.Add(this.iconPedido);
            this.panel1.Controls.Add(this.iconCadastrarCliente);
            this.panel1.Controls.Add(this.iconEntrar);
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
            this.iconCardapio.Enabled = false;
            this.iconCardapio.FlatAppearance.BorderSize = 0;
            this.iconCardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCardapio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconCardapio.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconCardapio.IconColor = System.Drawing.Color.Black;
            this.iconCardapio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCardapio.IconSize = 35;
            this.iconCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCardapio.Location = new System.Drawing.Point(0, 323);
            this.iconCardapio.Name = "iconCardapio";
            this.iconCardapio.Size = new System.Drawing.Size(193, 49);
            this.iconCardapio.TabIndex = 4;
            this.iconCardapio.Text = "ver cardápio";
            this.iconCardapio.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconCardapio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconCardapio.UseVisualStyleBackColor = true;
            this.iconCardapio.Visible = false;
            // 
            // iconPedido
            // 
            this.iconPedido.AutoSize = true;
            this.iconPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPedido.Enabled = false;
            this.iconPedido.FlatAppearance.BorderSize = 0;
            this.iconPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPedido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconPedido.IconChar = FontAwesome.Sharp.IconChar.PollH;
            this.iconPedido.IconColor = System.Drawing.Color.Black;
            this.iconPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPedido.IconSize = 35;
            this.iconPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconPedido.Location = new System.Drawing.Point(0, 274);
            this.iconPedido.Name = "iconPedido";
            this.iconPedido.Size = new System.Drawing.Size(193, 49);
            this.iconPedido.TabIndex = 3;
            this.iconPedido.Text = "fazer pedido";
            this.iconPedido.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPedido.UseVisualStyleBackColor = true;
            this.iconPedido.Visible = false;
            // 
            // iconCadastrarCliente
            // 
            this.iconCadastrarCliente.AutoSize = true;
            this.iconCadastrarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconCadastrarCliente.Enabled = false;
            this.iconCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.iconCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCadastrarCliente.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconCadastrarCliente.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconCadastrarCliente.IconColor = System.Drawing.Color.Black;
            this.iconCadastrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCadastrarCliente.IconSize = 35;
            this.iconCadastrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCadastrarCliente.Location = new System.Drawing.Point(0, 225);
            this.iconCadastrarCliente.Name = "iconCadastrarCliente";
            this.iconCadastrarCliente.Size = new System.Drawing.Size(193, 49);
            this.iconCadastrarCliente.TabIndex = 2;
            this.iconCadastrarCliente.Text = "cadastrar cliente";
            this.iconCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconCadastrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconCadastrarCliente.UseVisualStyleBackColor = true;
            this.iconCadastrarCliente.Visible = false;
            // 
            // iconEntrar
            // 
            this.iconEntrar.AutoSize = true;
            this.iconEntrar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconEntrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconEntrar.FlatAppearance.BorderSize = 0;
            this.iconEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEntrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconEntrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconEntrar.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconEntrar.IconColor = System.Drawing.Color.Black;
            this.iconEntrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEntrar.IconSize = 35;
            this.iconEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEntrar.Location = new System.Drawing.Point(0, 178);
            this.iconEntrar.Name = "iconEntrar";
            this.iconEntrar.Size = new System.Drawing.Size(193, 47);
            this.iconEntrar.TabIndex = 1;
            this.iconEntrar.Text = "entrar";
            this.iconEntrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconEntrar.UseVisualStyleBackColor = false;
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
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Entrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabelCadastrar;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelLogin;
        private FontAwesome.Sharp.IconPictureBox iconLogin;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconCardapio;
        private FontAwesome.Sharp.IconButton iconPedido;
        private FontAwesome.Sharp.IconButton iconCadastrarCliente;
        private FontAwesome.Sharp.IconButton iconEntrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLogar;
    }
}