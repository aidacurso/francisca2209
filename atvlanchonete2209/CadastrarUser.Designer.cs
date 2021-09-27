
namespace atvlanchonete2209
{
    partial class CadastrarUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarUser));
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelNovaConta = new System.Windows.Forms.Label();
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
            this.panel3.Controls.Add(this.buttonCadastrar);
            this.panel3.Controls.Add(this.labelUsuario);
            this.panel3.Controls.Add(this.labelTitulo);
            this.panel3.Controls.Add(this.textUsuario);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(193, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 450);
            this.panel3.TabIndex = 5;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.ForeColor = System.Drawing.Color.White;
            this.buttonCadastrar.Location = new System.Drawing.Point(213, 251);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 5;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
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
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(153, 150);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(191, 28);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Crie uma nova conta";
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
            this.panel4.Controls.Add(this.labelNovaConta);
            this.panel4.Controls.Add(this.iconLogin);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 100);
            this.panel4.TabIndex = 0;
            // 
            // labelNovaConta
            // 
            this.labelNovaConta.AutoSize = true;
            this.labelNovaConta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNovaConta.ForeColor = System.Drawing.Color.White;
            this.labelNovaConta.Location = new System.Drawing.Point(86, 40);
            this.labelNovaConta.Name = "labelNovaConta";
            this.labelNovaConta.Size = new System.Drawing.Size(152, 28);
            this.labelNovaConta.TabIndex = 1;
            this.labelNovaConta.Text = "criar nova conta";
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconLogin.IconColor = System.Drawing.Color.White;
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
            this.panel1.TabIndex = 4;
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
            this.iconCardapio.Location = new System.Drawing.Point(0, 323);
            this.iconCardapio.Name = "iconCardapio";
            this.iconCardapio.Size = new System.Drawing.Size(193, 49);
            this.iconCardapio.TabIndex = 4;
            this.iconCardapio.Text = "ver cardápio";
            this.iconCardapio.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconCardapio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconCardapio.UseVisualStyleBackColor = true;
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
            this.iconPedido.Location = new System.Drawing.Point(0, 274);
            this.iconPedido.Name = "iconPedido";
            this.iconPedido.Size = new System.Drawing.Size(193, 49);
            this.iconPedido.TabIndex = 3;
            this.iconPedido.Text = "fazer pedido";
            this.iconPedido.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.iconCadastrarCliente.Location = new System.Drawing.Point(0, 225);
            this.iconCadastrarCliente.Name = "iconCadastrarCliente";
            this.iconCadastrarCliente.Size = new System.Drawing.Size(193, 49);
            this.iconCadastrarCliente.TabIndex = 2;
            this.iconCadastrarCliente.Text = "cadastrar cliente";
            this.iconCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconCadastrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // iconEntrar
            // 
            this.iconEntrar.AutoSize = true;
            this.iconEntrar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconEntrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconEntrar.FlatAppearance.BorderSize = 0;
            this.iconEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEntrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconEntrar.ForeColor = System.Drawing.Color.White;
            this.iconEntrar.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconEntrar.IconColor = System.Drawing.Color.White;
            this.iconEntrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEntrar.IconSize = 35;
            this.iconEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEntrar.Location = new System.Drawing.Point(0, 178);
            this.iconEntrar.Name = "iconEntrar";
            this.iconEntrar.Size = new System.Drawing.Size(193, 47);
            this.iconEntrar.TabIndex = 1;
            this.iconEntrar.Text = "entrar";
            this.iconEntrar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEntrar.UseVisualStyleBackColor = false;
            this.iconEntrar.Click += new System.EventHandler(this.iconEntrar_Click);
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
            // 
            // CadastrarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CadastrarUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar conta";
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
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label labelNovaConta;
    }
}