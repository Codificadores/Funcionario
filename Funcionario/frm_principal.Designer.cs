namespace Funcionario
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            this.mns_principal = new System.Windows.Forms.MenuStrip();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_cadastramento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsr_consultas = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pct_deslogar = new System.Windows.Forms.PictureBox();
            this.mns_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_deslogar)).BeginInit();
            this.SuspendLayout();
            // 
            // mns_principal
            // 
            this.mns_principal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mns_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem});
            this.mns_principal.Location = new System.Drawing.Point(0, 0);
            this.mns_principal.Name = "mns_principal";
            this.mns_principal.Size = new System.Drawing.Size(383, 29);
            this.mns_principal.TabIndex = 0;
            this.mns_principal.Text = "menuStrip1";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsr_cadastramento,
            this.tsr_consultas});
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // tsr_cadastramento
            // 
            this.tsr_cadastramento.Name = "tsr_cadastramento";
            this.tsr_cadastramento.Size = new System.Drawing.Size(219, 26);
            this.tsr_cadastramento.Text = "Cadastramento";
            this.tsr_cadastramento.Click += new System.EventHandler(this.Tsr_cadastramento_Click);
            // 
            // tsr_consultas
            // 
            this.tsr_consultas.Name = "tsr_consultas";
            this.tsr_consultas.Size = new System.Drawing.Size(219, 26);
            this.tsr_consultas.Text = "Consultas/Alteração";
            this.tsr_consultas.Click += new System.EventHandler(this.Tsr_consultas_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // pct_deslogar
            // 
            this.pct_deslogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_deslogar.Image = global::Funcionario.Properties.Resources.cadastro_sair;
            this.pct_deslogar.Location = new System.Drawing.Point(12, 157);
            this.pct_deslogar.Name = "pct_deslogar";
            this.pct_deslogar.Size = new System.Drawing.Size(70, 64);
            this.pct_deslogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_deslogar.TabIndex = 3;
            this.pct_deslogar.TabStop = false;
            this.pct_deslogar.Click += new System.EventHandler(this.Pct_deslogar_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 233);
            this.Controls.Add(this.pct_deslogar);
            this.Controls.Add(this.mns_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mns_principal;
            this.MaximizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_principal_FormClosed);
            this.mns_principal.ResumeLayout(false);
            this.mns_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_deslogar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_principal;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsr_cadastramento;
        private System.Windows.Forms.ToolStripMenuItem tsr_consultas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.PictureBox pct_deslogar;
    }
}