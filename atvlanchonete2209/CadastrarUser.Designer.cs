
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColunaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonExcluir = new FontAwesome.Sharp.IconButton();
            this.iconButtonEditar = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdicionar = new FontAwesome.Sharp.IconButton();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelNovaConta = new System.Windows.Forms.Label();
            this.iconLogin = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconCadastrar = new FontAwesome.Sharp.IconButton();
            this.iconCardapio = new FontAwesome.Sharp.IconButton();
            this.iconPedido = new FontAwesome.Sharp.IconButton();
            this.iconCadastrarCliente = new FontAwesome.Sharp.IconButton();
            this.iconEntrar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.iconButtonExcluir);
            this.panel3.Controls.Add(this.iconButtonEditar);
            this.panel3.Controls.Add(this.iconButtonAdicionar);
            this.panel3.Controls.Add(this.textSenha);
            this.panel3.Controls.Add(this.labelSenha);
            this.panel3.Controls.Add(this.labelUsuario);
            this.panel3.Controls.Add(this.labelTitulo);
            this.panel3.Controls.Add(this.textUsuario);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(221, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 600);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(292, 467);
            this.panel5.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaUsuario,
            this.ColunaSenha});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(292, 467);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColunaUsuario
            // 
            this.ColunaUsuario.DataPropertyName = "NomeUser";
            this.ColunaUsuario.HeaderText = "Usuário";
            this.ColunaUsuario.MinimumWidth = 70;
            this.ColunaUsuario.Name = "ColunaUsuario";
            this.ColunaUsuario.Width = 140;
            // 
            // ColunaSenha
            // 
            this.ColunaSenha.DataPropertyName = "SenhaUser";
            this.ColunaSenha.HeaderText = "Senha";
            this.ColunaSenha.MinimumWidth = 70;
            this.ColunaSenha.Name = "ColunaSenha";
            this.ColunaSenha.Width = 140;
            // 
            // iconButtonExcluir
            // 
            this.iconButtonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExcluir.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonExcluir.IconColor = System.Drawing.Color.White;
            this.iconButtonExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExcluir.IconSize = 30;
            this.iconButtonExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExcluir.Location = new System.Drawing.Point(447, 504);
            this.iconButtonExcluir.Name = "iconButtonExcluir";
            this.iconButtonExcluir.Size = new System.Drawing.Size(131, 47);
            this.iconButtonExcluir.TabIndex = 15;
            this.iconButtonExcluir.Text = "Excluir";
            this.iconButtonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExcluir.UseVisualStyleBackColor = true;
            this.iconButtonExcluir.Click += new System.EventHandler(this.iconButtonExcluir_Click);
            // 
            // iconButtonEditar
            // 
            this.iconButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEditar.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButtonEditar.IconColor = System.Drawing.Color.White;
            this.iconButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEditar.IconSize = 30;
            this.iconButtonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEditar.Location = new System.Drawing.Point(447, 445);
            this.iconButtonEditar.Name = "iconButtonEditar";
            this.iconButtonEditar.Size = new System.Drawing.Size(131, 47);
            this.iconButtonEditar.TabIndex = 14;
            this.iconButtonEditar.Text = "Editar";
            this.iconButtonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEditar.UseVisualStyleBackColor = true;
            this.iconButtonEditar.Click += new System.EventHandler(this.iconButtonEditar_Click);
            // 
            // iconButtonAdicionar
            // 
            this.iconButtonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdicionar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAdicionar.IconColor = System.Drawing.Color.White;
            this.iconButtonAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdicionar.IconSize = 30;
            this.iconButtonAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdicionar.Location = new System.Drawing.Point(447, 392);
            this.iconButtonAdicionar.Name = "iconButtonAdicionar";
            this.iconButtonAdicionar.Size = new System.Drawing.Size(131, 47);
            this.iconButtonAdicionar.TabIndex = 13;
            this.iconButtonAdicionar.Text = "Adicionar";
            this.iconButtonAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdicionar.UseVisualStyleBackColor = true;
            this.iconButtonAdicionar.Click += new System.EventHandler(this.iconButtonAdicionar_Click);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(498, 294);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(125, 27);
            this.textSenha.TabIndex = 11;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(443, 300);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(49, 20);
            this.labelSenha.TabIndex = 9;
            this.labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(369, 251);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(123, 20);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Nome de usuário";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(368, 179);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(244, 35);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Crie uma nova conta";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(498, 248);
            this.textUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(125, 27);
            this.textUsuario.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.labelNovaConta);
            this.panel4.Controls.Add(this.iconLogin);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(693, 133);
            this.panel4.TabIndex = 0;
            // 
            // labelNovaConta
            // 
            this.labelNovaConta.AutoSize = true;
            this.labelNovaConta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNovaConta.ForeColor = System.Drawing.Color.White;
            this.labelNovaConta.Location = new System.Drawing.Point(98, 53);
            this.labelNovaConta.Name = "labelNovaConta";
            this.labelNovaConta.Size = new System.Drawing.Size(194, 35);
            this.labelNovaConta.TabIndex = 1;
            this.labelNovaConta.Text = "criar nova conta";
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconLogin.IconColor = System.Drawing.Color.White;
            this.iconLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogin.IconSize = 61;
            this.iconLogin.Location = new System.Drawing.Point(42, 40);
            this.iconLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(61, 71);
            this.iconLogin.TabIndex = 0;
            this.iconLogin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.iconCadastrar);
            this.panel1.Controls.Add(this.iconCardapio);
            this.panel1.Controls.Add(this.iconPedido);
            this.panel1.Controls.Add(this.iconCadastrarCliente);
            this.panel1.Controls.Add(this.iconEntrar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 600);
            this.panel1.TabIndex = 4;
            // 
            // iconCadastrar
            // 
            this.iconCadastrar.AutoSize = true;
            this.iconCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconCadastrar.FlatAppearance.BorderSize = 0;
            this.iconCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCadastrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconCadastrar.ForeColor = System.Drawing.Color.White;
            this.iconCadastrar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconCadastrar.IconColor = System.Drawing.Color.White;
            this.iconCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCadastrar.IconSize = 35;
            this.iconCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCadastrar.Location = new System.Drawing.Point(0, 495);
            this.iconCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconCadastrar.Name = "iconCadastrar";
            this.iconCadastrar.Size = new System.Drawing.Size(221, 80);
            this.iconCadastrar.TabIndex = 5;
            this.iconCadastrar.Text = "novo login";
            this.iconCadastrar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconCadastrar.UseVisualStyleBackColor = true;
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
            this.iconCardapio.Location = new System.Drawing.Point(0, 430);
            this.iconCardapio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconCardapio.Name = "iconCardapio";
            this.iconCardapio.Size = new System.Drawing.Size(221, 65);
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
            this.iconPedido.Location = new System.Drawing.Point(0, 365);
            this.iconPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconPedido.Name = "iconPedido";
            this.iconPedido.Size = new System.Drawing.Size(221, 65);
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
            this.iconCadastrarCliente.Location = new System.Drawing.Point(0, 300);
            this.iconCadastrarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconCadastrarCliente.Name = "iconCadastrarCliente";
            this.iconCadastrarCliente.Size = new System.Drawing.Size(221, 65);
            this.iconCadastrarCliente.TabIndex = 2;
            this.iconCadastrarCliente.Text = "cadastrar cliente";
            this.iconCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconCadastrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconCadastrarCliente.UseVisualStyleBackColor = true;
            this.iconCadastrarCliente.Click += new System.EventHandler(this.iconCadastrarCliente_Click);
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
            this.iconEntrar.Location = new System.Drawing.Point(0, 237);
            this.iconEntrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconEntrar.Name = "iconEntrar";
            this.iconEntrar.Size = new System.Drawing.Size(221, 63);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 237);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CadastrarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CadastrarUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar conta";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label labelNovaConta;
        private FontAwesome.Sharp.IconButton iconCadastrar;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButtonExcluir;
        private FontAwesome.Sharp.IconButton iconButtonEditar;
        private FontAwesome.Sharp.IconButton iconButtonAdicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaSenha;
    }
}