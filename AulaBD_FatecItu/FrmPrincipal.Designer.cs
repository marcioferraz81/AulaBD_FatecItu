namespace AulaBD_FatecItu
{
    partial class FrmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCategoriaCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCategoriaListar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCategoriaConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProdutoCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProdutoListar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCategoria,
            this.menuProduto});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 3;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuCategoria
            // 
            this.menuCategoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCategoriaCadastrar,
            this.itemCategoriaListar,
            this.itemCategoriaConsultar});
            this.menuCategoria.Name = "menuCategoria";
            this.menuCategoria.Size = new System.Drawing.Size(70, 20);
            this.menuCategoria.Text = "Categoria";
            // 
            // itemCategoriaCadastrar
            // 
            this.itemCategoriaCadastrar.Name = "itemCategoriaCadastrar";
            this.itemCategoriaCadastrar.Size = new System.Drawing.Size(180, 22);
            this.itemCategoriaCadastrar.Text = "Cadastrar";
            this.itemCategoriaCadastrar.Click += new System.EventHandler(this.itemCategoriaCadastrar_Click);
            // 
            // itemCategoriaListar
            // 
            this.itemCategoriaListar.Name = "itemCategoriaListar";
            this.itemCategoriaListar.Size = new System.Drawing.Size(180, 22);
            this.itemCategoriaListar.Text = "Listar";
            this.itemCategoriaListar.Click += new System.EventHandler(this.itemCategoriaListar_Click);
            // 
            // itemCategoriaConsultar
            // 
            this.itemCategoriaConsultar.Name = "itemCategoriaConsultar";
            this.itemCategoriaConsultar.Size = new System.Drawing.Size(180, 22);
            this.itemCategoriaConsultar.Text = "Consultar";
            this.itemCategoriaConsultar.Click += new System.EventHandler(this.itemCategoriaConsultar_Click);
            // 
            // menuProduto
            // 
            this.menuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemProdutoCadastrar,
            this.itemProdutoListar});
            this.menuProduto.Name = "menuProduto";
            this.menuProduto.Size = new System.Drawing.Size(62, 20);
            this.menuProduto.Text = "Produto";
            // 
            // itemProdutoCadastrar
            // 
            this.itemProdutoCadastrar.Name = "itemProdutoCadastrar";
            this.itemProdutoCadastrar.Size = new System.Drawing.Size(180, 22);
            this.itemProdutoCadastrar.Text = "Cadastrar";
            this.itemProdutoCadastrar.Click += new System.EventHandler(this.itemProdutoCadastrar_Click);
            // 
            // itemProdutoListar
            // 
            this.itemProdutoListar.Name = "itemProdutoListar";
            this.itemProdutoListar.Size = new System.Drawing.Size(180, 22);
            this.itemProdutoListar.Text = "Listar";
            this.itemProdutoListar.Click += new System.EventHandler(this.itemProdutoListar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.Name = "FrmPrincipal";
            this.Text = "Aulas de CRUD C# e MySQL";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCategoria;
        private System.Windows.Forms.ToolStripMenuItem itemCategoriaCadastrar;
        private System.Windows.Forms.ToolStripMenuItem itemCategoriaListar;
        private System.Windows.Forms.ToolStripMenuItem itemCategoriaConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuProduto;
        private System.Windows.Forms.ToolStripMenuItem itemProdutoCadastrar;
        private System.Windows.Forms.ToolStripMenuItem itemProdutoListar;
    }
}

