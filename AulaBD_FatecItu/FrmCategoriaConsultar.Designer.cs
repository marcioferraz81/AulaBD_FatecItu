namespace AulaBD_FatecItu
{
    partial class FrmCategoriaConsultar
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
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnproximo = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(34, 86);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(75, 23);
            this.btnanterior.TabIndex = 0;
            this.btnanterior.Text = "<< =";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnproximo
            // 
            this.btnproximo.Location = new System.Drawing.Point(115, 86);
            this.btnproximo.Name = "btnproximo";
            this.btnproximo.Size = new System.Drawing.Size(75, 23);
            this.btnproximo.TabIndex = 1;
            this.btnproximo.Text = "= >>";
            this.btnproximo.UseVisualStyleBackColor = true;
            this.btnproximo.Click += new System.EventHandler(this.btnproximo_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(34, 48);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(167, 20);
            this.txtnome.TabIndex = 2;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(31, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 3;
            this.lblid.Text = "ID";
            // 
            // FrmCategoriaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 259);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btnproximo);
            this.Controls.Add(this.btnanterior);
            this.Name = "FrmCategoriaConsultar";
            this.Text = "FrmCategoriaConsultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnproximo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblid;
    }
}