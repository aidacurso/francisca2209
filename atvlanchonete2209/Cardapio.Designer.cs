
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
            this.iconButtonExcluir = new FontAwesome.Sharp.IconButton();
            this.iconButtonEditar = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdicionar = new FontAwesome.Sharp.IconButton();
            this.textBoxPrecoProduto = new System.Windows.Forms.TextBox();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.textBoxIDProduto = new System.Windows.Forms.TextBox();
            this.labelPrecoProduto = new System.Windows.Forms.Label();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.labelIDProduto = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelCardapio = new System.Windows.Forms.Label();
            this.iconcardap = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconCadastrar = new FontAwesome.Sharp.IconButton();
            this.iconCardapio = new FontAwesome.Sharp.IconButton();
            this.iconPedido = new FontAwesome.Sharp.IconButton();
            this.iconCadastrarCliente = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel3.Controls.Add(this.labelTitulo);
            this.panel3.Controls.Add(this.iconButtonExcluir);
            this.panel3.Controls.Add(this.iconButtonEditar);
            this.panel3.Controls.Add(this.iconButtonAdicionar);
            this.panel3.Controls.Add(this.textBoxPrecoProduto);
            this.panel3.Controls.Add(this.textBoxNomeProduto);
            this.panel3.Controls.Add(this.textBoxIDProduto);
            this.panel3.Controls.Add(this.labelPrecoProduto);
            this.panel3.Controls.Add(this.labelNomeProduto);
            this.panel3.Controls.Add(this.labelIDProduto);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(221, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 600);
            this.panel3.TabIndex = 3;
            // 
            // iconButtonExcluir
            // 
            this.iconButtonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExcluir.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonExcluir.IconColor = System.Drawing.Color.White;
            this.iconButtonExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExcluir.IconSize = 30;
            this.iconButtonExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExcluir.Location = new System.Drawing.Point(402, 491);
            this.iconButtonExcluir.Name = "iconButtonExcluir";
            this.iconButtonExcluir.Size = new System.Drawing.Size(131, 47);
            this.iconButtonExcluir.TabIndex = 11;
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
            this.iconButtonEditar.Location = new System.Drawing.Point(402, 432);
            this.iconButtonEditar.Name = "iconButtonEditar";
            this.iconButtonEditar.Size = new System.Drawing.Size(131, 47);
            this.iconButtonEditar.TabIndex = 10;
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
            this.iconButtonAdicionar.Location = new System.Drawing.Point(402, 379);
            this.iconButtonAdicionar.Name = "iconButtonAdicionar";
            this.iconButtonAdicionar.Size = new System.Drawing.Size(131, 47);
            this.iconButtonAdicionar.TabIndex = 9;
            this.iconButtonAdicionar.Text = "Adicionar";
            this.iconButtonAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdicionar.UseVisualStyleBackColor = true;
            this.iconButtonAdicionar.Click += new System.EventHandler(this.iconButtonAdicionar_Click);
            // 
            // textBoxPrecoProduto
            // 
            this.textBoxPrecoProduto.Location = new System.Drawing.Point(483, 316);
            this.textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            this.textBoxPrecoProduto.Size = new System.Drawing.Size(125, 27);
            this.textBoxPrecoProduto.TabIndex = 8;
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(483, 264);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(125, 27);
            this.textBoxNomeProduto.TabIndex = 7;
            // 
            // textBoxIDProduto
            // 
            this.textBoxIDProduto.Location = new System.Drawing.Point(483, 215);
            this.textBoxIDProduto.Name = "textBoxIDProduto";
            this.textBoxIDProduto.Size = new System.Drawing.Size(125, 27);
            this.textBoxIDProduto.TabIndex = 6;
            // 
            // labelPrecoProduto
            // 
            this.labelPrecoProduto.AutoSize = true;
            this.labelPrecoProduto.Location = new System.Drawing.Point(351, 319);
            this.labelPrecoProduto.Name = "labelPrecoProduto";
            this.labelPrecoProduto.Size = new System.Drawing.Size(126, 20);
            this.labelPrecoProduto.TabIndex = 5;
            this.labelPrecoProduto.Text = "Preço do produto";
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Location = new System.Drawing.Point(347, 267);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(130, 20);
            this.labelNomeProduto.TabIndex = 4;
            this.labelNomeProduto.Text = "Nome do produto";
            // 
            // labelIDProduto
            // 
            this.labelIDProduto.AutoSize = true;
            this.labelIDProduto.Location = new System.Drawing.Point(339, 218);
            this.labelIDProduto.Name = "labelIDProduto";
            this.labelIDProduto.Size = new System.Drawing.Size(138, 20);
            this.labelIDProduto.TabIndex = 3;
            this.labelIDProduto.Text = "Código do produto";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(316, 467);
            this.panel5.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaID,
            this.ColunaNome,
            this.ColunaPreco});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(316, 467);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Editar);
            // 
            // ColunaID
            // 
            this.ColunaID.DataPropertyName = "IDProduto";
            this.ColunaID.HeaderText = "ID";
            this.ColunaID.MinimumWidth = 70;
            this.ColunaID.Name = "ColunaID";
            this.ColunaID.Width = 70;
            // 
            // ColunaNome
            // 
            this.ColunaNome.DataPropertyName = "NomeProdutos";
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.MinimumWidth = 70;
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.Width = 125;
            // 
            // ColunaPreco
            // 
            this.ColunaPreco.DataPropertyName = "PrecoProdutos";
            this.ColunaPreco.HeaderText = "Preço";
            this.ColunaPreco.MinimumWidth = 6;
            this.ColunaPreco.Name = "ColunaPreco";
            this.ColunaPreco.Width = 125;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Controls.Add(this.labelCardapio);
            this.panel4.Controls.Add(this.iconcardap);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(693, 133);
            this.panel4.TabIndex = 0;
            // 
            // labelCardapio
            // 
            this.labelCardapio.AutoSize = true;
            this.labelCardapio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCardapio.ForeColor = System.Drawing.Color.White;
            this.labelCardapio.Location = new System.Drawing.Point(117, 52);
            this.labelCardapio.Name = "labelCardapio";
            this.labelCardapio.Size = new System.Drawing.Size(154, 35);
            this.labelCardapio.TabIndex = 3;
            this.labelCardapio.Text = "ver cardápio";
            // 
            // iconcardap
            // 
            this.iconcardap.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconcardap.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconcardap.IconColor = System.Drawing.Color.White;
            this.iconcardap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcardap.IconSize = 61;
            this.iconcardap.Location = new System.Drawing.Point(61, 40);
            this.iconcardap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconcardap.Name = "iconcardap";
            this.iconcardap.Size = new System.Drawing.Size(61, 71);
            this.iconcardap.TabIndex = 2;
            this.iconcardap.TabStop = false;
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
            this.iconCardapio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
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
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(372, 151);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(251, 35);
            this.labelTitulo.TabIndex = 12;
            this.labelTitulo.Text = "Insira as informações";
            // 
            // Cardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cardapio";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private FontAwesome.Sharp.IconButton iconCadastrar;
        private System.Windows.Forms.TextBox textBoxPrecoProduto;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.TextBox textBoxIDProduto;
        private System.Windows.Forms.Label labelPrecoProduto;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.Label labelIDProduto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButtonExcluir;
        private FontAwesome.Sharp.IconButton iconButtonEditar;
        private FontAwesome.Sharp.IconButton iconButtonAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaPreco;
        private System.Windows.Forms.Label labelTitulo;
    }
}