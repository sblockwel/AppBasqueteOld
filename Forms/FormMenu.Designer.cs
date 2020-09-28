namespace AppBasquete.Forms
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuJogador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJogo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarJogador = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultarJogador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarJogo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarJogo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuJogador,
            this.menuJogo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuJogador
            // 
            this.menuJogador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarJogador,
            this.MenuConsultarJogador});
            this.menuJogador.Name = "menuJogador";
            this.menuJogador.Size = new System.Drawing.Size(61, 20);
            this.menuJogador.Text = "Jogador";
            // 
            // menuJogo
            // 
            this.menuJogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarJogo,
            this.menuConsultarJogo});
            this.menuJogo.Name = "menuJogo";
            this.menuJogo.Size = new System.Drawing.Size(44, 20);
            this.menuJogo.Text = "Jogo";
            // 
            // menuCadastrarJogador
            // 
            this.menuCadastrarJogador.Name = "menuCadastrarJogador";
            this.menuCadastrarJogador.Size = new System.Drawing.Size(180, 22);
            this.menuCadastrarJogador.Text = "Cadastrar Jogador";
            this.menuCadastrarJogador.Click += new System.EventHandler(this.menuCadastrarJogador_Click);
            // 
            // MenuConsultarJogador
            // 
            this.MenuConsultarJogador.Name = "MenuConsultarJogador";
            this.MenuConsultarJogador.Size = new System.Drawing.Size(180, 22);
            this.MenuConsultarJogador.Text = "Consultar Jogador";
            // 
            // menuCadastrarJogo
            // 
            this.menuCadastrarJogo.Name = "menuCadastrarJogo";
            this.menuCadastrarJogo.Size = new System.Drawing.Size(180, 22);
            this.menuCadastrarJogo.Text = "Cadastrar Jogo";
            this.menuCadastrarJogo.Click += new System.EventHandler(this.menuCadastrarJogo_Click);
            // 
            // menuConsultarJogo
            // 
            this.menuConsultarJogo.Name = "menuConsultarJogo";
            this.menuConsultarJogo.Size = new System.Drawing.Size(180, 22);
            this.menuConsultarJogo.Text = "Consultar Jogo";
            this.menuConsultarJogo.Click += new System.EventHandler(this.menuConsultarJogo_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 343);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuJogador;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarJogador;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultarJogador;
        private System.Windows.Forms.ToolStripMenuItem menuJogo;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarJogo;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarJogo;
    }
}