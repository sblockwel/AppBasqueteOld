namespace AppBasquete
{
    partial class FormMain
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPlacar = new System.Windows.Forms.TextBox();
            this.lblPlacar = new System.Windows.Forms.Label();
            this.txtMaxPontos = new System.Windows.Forms.TextBox();
            this.lblMinPontos = new System.Windows.Forms.Label();
            this.txtMinPontos = new System.Windows.Forms.TextBox();
            this.lblMaxPontos = new System.Windows.Forms.Label();
            this.txtQuebraMin = new System.Windows.Forms.TextBox();
            this.lblQuebraMin = new System.Windows.Forms.Label();
            this.txtQuebraMax = new System.Windows.Forms.TextBox();
            this.lblQuebraMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(12, 13);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(68, 18);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "N° Jogo";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(15, 34);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(65, 23);
            this.txtNumero.TabIndex = 1;
            // 
            // txtPlacar
            // 
            this.txtPlacar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacar.Location = new System.Drawing.Point(101, 34);
            this.txtPlacar.Name = "txtPlacar";
            this.txtPlacar.Size = new System.Drawing.Size(107, 23);
            this.txtPlacar.TabIndex = 3;
            // 
            // lblPlacar
            // 
            this.lblPlacar.AutoSize = true;
            this.lblPlacar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar.Location = new System.Drawing.Point(98, 13);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(52, 18);
            this.lblPlacar.TabIndex = 2;
            this.lblPlacar.Text = "Placar";
            // 
            // txtMaxPontos
            // 
            this.txtMaxPontos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxPontos.Location = new System.Drawing.Point(15, 171);
            this.txtMaxPontos.Name = "txtMaxPontos";
            this.txtMaxPontos.Size = new System.Drawing.Size(95, 23);
            this.txtMaxPontos.TabIndex = 5;
            // 
            // lblMinPontos
            // 
            this.lblMinPontos.AutoSize = true;
            this.lblMinPontos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPontos.Location = new System.Drawing.Point(12, 81);
            this.lblMinPontos.Name = "lblMinPontos";
            this.lblMinPontos.Size = new System.Drawing.Size(251, 18);
            this.lblMinPontos.TabIndex = 4;
            this.lblMinPontos.Text = "Mínimo de pontos na temporada";
            // 
            // txtMinPontos
            // 
            this.txtMinPontos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinPontos.Location = new System.Drawing.Point(15, 102);
            this.txtMinPontos.Name = "txtMinPontos";
            this.txtMinPontos.Size = new System.Drawing.Size(95, 23);
            this.txtMinPontos.TabIndex = 7;
            // 
            // lblMaxPontos
            // 
            this.lblMaxPontos.AutoSize = true;
            this.lblMaxPontos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPontos.Location = new System.Drawing.Point(12, 150);
            this.lblMaxPontos.Name = "lblMaxPontos";
            this.lblMaxPontos.Size = new System.Drawing.Size(257, 18);
            this.lblMaxPontos.TabIndex = 6;
            this.lblMaxPontos.Text = "Máximo de pontos na temporada";
            // 
            // txtQuebraMin
            // 
            this.txtQuebraMin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuebraMin.Location = new System.Drawing.Point(15, 237);
            this.txtQuebraMin.Name = "txtQuebraMin";
            this.txtQuebraMin.Size = new System.Drawing.Size(95, 23);
            this.txtQuebraMin.TabIndex = 11;
            // 
            // lblQuebraMin
            // 
            this.lblQuebraMin.AutoSize = true;
            this.lblQuebraMin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuebraMin.Location = new System.Drawing.Point(12, 216);
            this.lblQuebraMin.Name = "lblQuebraMin";
            this.lblQuebraMin.Size = new System.Drawing.Size(207, 18);
            this.lblQuebraMin.TabIndex = 10;
            this.lblQuebraMin.Text = "Quebra de recorde mínimo";
            // 
            // txtQuebraMax
            // 
            this.txtQuebraMax.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuebraMax.Location = new System.Drawing.Point(15, 306);
            this.txtQuebraMax.Name = "txtQuebraMax";
            this.txtQuebraMax.Size = new System.Drawing.Size(95, 23);
            this.txtQuebraMax.TabIndex = 9;
            // 
            // lblQuebraMax
            // 
            this.lblQuebraMax.AutoSize = true;
            this.lblQuebraMax.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuebraMax.Location = new System.Drawing.Point(12, 276);
            this.lblQuebraMax.Name = "lblQuebraMax";
            this.lblQuebraMax.Size = new System.Drawing.Size(213, 18);
            this.lblQuebraMax.TabIndex = 8;
            this.lblQuebraMax.Text = "Quebra de recorde máximo";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 356);
            this.Controls.Add(this.txtQuebraMin);
            this.Controls.Add(this.lblQuebraMin);
            this.Controls.Add(this.txtQuebraMax);
            this.Controls.Add(this.lblQuebraMax);
            this.Controls.Add(this.txtMinPontos);
            this.Controls.Add(this.lblMaxPontos);
            this.Controls.Add(this.txtMaxPontos);
            this.Controls.Add(this.lblMinPontos);
            this.Controls.Add(this.txtPlacar);
            this.Controls.Add(this.lblPlacar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "FormMain";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPlacar;
        private System.Windows.Forms.Label lblPlacar;
        private System.Windows.Forms.TextBox txtMaxPontos;
        private System.Windows.Forms.Label lblMinPontos;
        private System.Windows.Forms.TextBox txtMinPontos;
        private System.Windows.Forms.Label lblMaxPontos;
        private System.Windows.Forms.TextBox txtQuebraMin;
        private System.Windows.Forms.Label lblQuebraMin;
        private System.Windows.Forms.TextBox txtQuebraMax;
        private System.Windows.Forms.Label lblQuebraMax;
    }
}

