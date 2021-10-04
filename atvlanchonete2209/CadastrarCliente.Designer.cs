
namespace atvlanchonete2209
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonExcluir = new FontAwesome.Sharp.IconButton();
            this.iconButtonEditar = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdicionar = new FontAwesome.Sharp.IconButton();
            this.labelTelefoneCliente = new System.Windows.Forms.Label();
            this.textBoxTelefoneCliente = new System.Windows.Forms.TextBox();
            this.labelCodigoCliente = new System.Windows.Forms.Label();
            this.textBoxCodigoCliente = new System.Windows.Forms.TextBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textNomeCliente = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.iconLogin = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconCadastrar = new FontAwesome.Sharp.IconButton();
            this.iconCardapio = new FontAwesome.Sharp.IconButton();
            this.iconPedido = new FontAwesome.Sharp.IconButton();
            this.iconCadastrarCliente = new FontAwesome.Sharp.IconButton();
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
            this.panel3.Controls.Add(this.labelTelefoneCliente);
            this.panel3.Controls.Add(this.textBoxTelefoneCliente);
            this.panel3.Controls.Add(this.labelCodigoCliente);
            this.panel3.Controls.Add(this.textBoxCodigoCliente);
            this.panel3.Controls.Add(this.labelNomeCliente);
            this.panel3.Controls.Add(this.labelTitulo);
            this.panel3.Controls.Add(this.textNomeCliente);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(221, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 600);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 467);
            this.panel5.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaID,
            this.ColunaNome,
            this.ColunaTelefone});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(319, 467);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColunaID
            // 
            this.ColunaID.DataPropertyName = "IDCliente";
            this.ColunaID.HeaderText = "ID";
            this.ColunaID.MinimumWidth = 70;
            this.ColunaID.Name = "ColunaID";
            this.ColunaID.Width = 70;
            // 
            // ColunaNome
            // 
            this.ColunaNome.DataPropertyName = "NomeCliente";
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.MinimumWidth = 70;
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.Width = 125;
            // 
            // ColunaTelefone
            // 
            this.ColunaTelefone.DataPropertyName = "TelefoneCliente";
            this.ColunaTelefone.HeaderText = "Telefone";
            this.ColunaTelefone.MinimumWidth = 6;
            this.ColunaTelefone.Name = "ColunaTelefone";
            this.ColunaTelefone.Width = 125;
            // 
            // iconButtonExcluir
            // 
            this.iconButtonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExcluir.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonExcluir.IconColor = System.Drawing.Color.White;
            this.iconButtonExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExcluir.IconSize = 30;
            this.iconButtonExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExcluir.Location = new System.Drawing.Point(474, 483);
            this.iconButtonExcluir.Name = "iconButtonExcluir";
            this.iconButtonExcluir.Size = new System.Drawing.Size(131, 47);
            this.iconButtonExcluir.TabIndex = 16;
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
            this.iconButtonEditar.Location = new System.Drawing.Point(474, 424);
            this.iconButtonEditar.Name = "iconButtonEditar";
            this.iconButtonEditar.Size = new System.Drawing.Size(131, 47);
            this.iconButtonEditar.TabIndex = 15;
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
            this.iconButtonAdicionar.Location = new System.Drawing.Point(474, 371);
            this.iconButtonAdicionar.Name = "iconButtonAdicionar";
            this.iconButtonAdicionar.Size = new System.Drawing.Size(131, 47);
            this.iconButtonAdicionar.TabIndex = 14;
            this.iconButtonAdicionar.Text = "Adicionar";
            this.iconButtonAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdicionar.UseVisualStyleBackColor = true;
            this.iconButtonAdicionar.Click += new System.EventHandler(this.iconButtonAdicionar_Click);
            // 
            // labelTelefoneCliente
            // 
            this.labelTelefoneCliente.AutoSize = true;
            this.labelTelefoneCliente.ForeColor = System.Drawing.Color.White;
            this.labelTelefoneCliente.Location = new System.Drawing.Point(385, 319);
            this.labelTelefoneCliente.Name = "labelTelefoneCliente";
            this.labelTelefoneCliente.Size = new System.Drawing.Size(136, 20);
            this.labelTelefoneCliente.TabIndex = 13;
            this.labelTelefoneCliente.Text = "Telefone do cliente";
            // 
            // textBoxTelefoneCliente
            // 
            this.textBoxTelefoneCliente.Location = new System.Drawing.Point(527, 316);
            this.textBoxTelefoneCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTelefoneCliente.Name = "textBoxTelefoneCliente";
            this.textBoxTelefoneCliente.Size = new System.Drawing.Size(114, 27);
            this.textBoxTelefoneCliente.TabIndex = 12;
            // 
            // labelCodigoCliente
            // 
            this.labelCodigoCliente.AutoSize = true;
            this.labelCodigoCliente.ForeColor = System.Drawing.Color.White;
            this.labelCodigoCliente.Location = new System.Drawing.Point(393, 249);
            this.labelCodigoCliente.Name = "labelCodigoCliente";
            this.labelCodigoCliente.Size = new System.Drawing.Size(128, 20);
            this.labelCodigoCliente.TabIndex = 11;
            this.labelCodigoCliente.Text = "Código do cliente";
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(527, 246);
            this.textBoxCodigoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(114, 27);
            this.textBoxCodigoCliente.TabIndex = 10;
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.ForeColor = System.Drawing.Color.White;
            this.labelNomeCliente.Location = new System.Drawing.Point(401, 284);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(120, 20);
            this.labelNomeCliente.TabIndex = 9;
            this.labelNomeCliente.Text = "Nome do cliente";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(401, 164);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(251, 35);
            this.labelTitulo.TabIndex = 8;
            this.labelTitulo.Text = "Insira as informações";
            // 
            // textNomeCliente
            // 
            this.textNomeCliente.Location = new System.Drawing.Point(527, 281);
            this.textNomeCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNomeCliente.Name = "textNomeCliente";
            this.textNomeCliente.Size = new System.Drawing.Size(114, 27);
            this.textNomeCliente.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.labelLogin);
            this.panel4.Controls.Add(this.iconLogin);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(693, 133);
            this.panel4.TabIndex = 0;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(103, 52);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(197, 35);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "cadastrar cliente";
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconLogin.IconColor = System.Drawing.Color.White;
            this.iconLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogin.IconSize = 61;
            this.iconLogin.Location = new System.Drawing.Point(47, 40);
            this.iconLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(61, 71);
            this.iconLogin.TabIndex = 2;
            this.iconLogin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.iconCadastrar);
            this.panel1.Controls.Add(this.iconCardapio);
            this.panel1.Controls.Add(this.iconPedido);
            this.panel1.Controls.Add(this.iconCadastrarCliente);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 600);
            this.panel1.TabIndex = 2;
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
            this.iconCadastrar.Location = new System.Drawing.Point(0, 432);
            this.iconCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconCadastrar.Name = "iconCadastrar";
            this.iconCadastrar.Size = new System.Drawing.Size(221, 65);
            this.iconCadastrar.TabIndex = 6;
            this.iconCadastrar.Text = "novo login";
            this.iconCadastrar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconCadastrar.UseVisualStyleBackColor = true;
            this.iconCadastrar.Click += new System.EventHandler(this.iconCadastrar_Click);
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
            this.iconCardapio.Location = new System.Drawing.Point(0, 367);
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
            this.iconPedido.Location = new System.Drawing.Point(0, 302);
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
            this.iconCadastrarCliente.Location = new System.Drawing.Point(0, 237);
            this.iconCadastrarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconCadastrarCliente.Name = "iconCadastrarCliente";
            this.iconCadastrarCliente.Size = new System.Drawing.Size(221, 65);
            this.iconCadastrarCliente.TabIndex = 2;
            this.iconCadastrarCliente.Text = "cadastrar cliente";
            this.iconCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconCadastrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconCadastrarCliente.UseVisualStyleBackColor = true;
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
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarCliente";
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconCardapio;
        private FontAwesome.Sharp.IconButton iconPedido;
        private FontAwesome.Sharp.IconButton iconCadastrarCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogin;
        private FontAwesome.Sharp.IconPictureBox iconLogin;
        private System.Windows.Forms.Button buttonLogar;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.TextBox textNomeCliente;
        private FontAwesome.Sharp.IconButton iconCadastrar;
        private System.Windows.Forms.Label labelTelefoneCliente;
        private System.Windows.Forms.TextBox textBoxTelefoneCliente;
        private System.Windows.Forms.Label labelCodigoCliente;
        private System.Windows.Forms.TextBox textBoxCodigoCliente;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButtonExcluir;
        private FontAwesome.Sharp.IconButton iconButtonEditar;
        private FontAwesome.Sharp.IconButton iconButtonAdicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaTelefone;
    }
}