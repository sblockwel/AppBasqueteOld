namespace AppBasquete.Forms
{
    partial class FormJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogo));
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
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
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
            this.txtNumero.TabIndex = 100;
            // 
            // txtPlacar
            // 
            this.txtPlacar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacar.Location = new System.Drawing.Point(89, 34);
            this.txtPlacar.Name = "txtPlacar";
            this.txtPlacar.Size = new System.Drawing.Size(107, 23);
            this.txtPlacar.TabIndex = 0;
            // 
            // lblPlacar
            // 
            this.lblPlacar.AutoSize = true;
            this.lblPlacar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar.Location = new System.Drawing.Point(86, 13);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(52, 18);
            this.lblPlacar.TabIndex = 2;
            this.lblPlacar.Text = "Placar";
            // 
            // txtMaxPontos
            // 
            this.txtMaxPontos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxPontos.Location = new System.Drawing.Point(202, 95);
            this.txtMaxPontos.Name = "txtMaxPontos";
            this.txtMaxPontos.Size = new System.Drawing.Size(95, 23);
            this.txtMaxPontos.TabIndex = 2;
            // 
            // lblMinPontos
            // 
            this.lblMinPontos.AutoSize = true;
            this.lblMinPontos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinPontos.Location = new System.Drawing.Point(12, 67);
            this.lblMinPontos.Name = "lblMinPontos";
            this.lblMinPontos.Size = new System.Drawing.Size(182, 18);
            this.lblMinPontos.TabIndex = 4;
            this.lblMinPontos.Text = "Mín. pontos temporada";
            // 
            // txtMinPontos
            // 
            this.txtMinPontos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinPontos.Location = new System.Drawing.Point(202, 66);
            this.txtMinPontos.Name = "txtMinPontos";
            this.txtMinPontos.Size = new System.Drawing.Size(95, 23);
            this.txtMinPontos.TabIndex = 1;
            // 
            // lblMaxPontos
            // 
            this.lblMaxPontos.AutoSize = true;
            this.lblMaxPontos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPontos.Location = new System.Drawing.Point(12, 96);
            this.lblMaxPontos.Name = "lblMaxPontos";
            this.lblMaxPontos.Size = new System.Drawing.Size(188, 18);
            this.lblMaxPontos.TabIndex = 6;
            this.lblMaxPontos.Text = "Máx. pontos temporada";
            // 
            // txtQuebraMin
            // 
            this.txtQuebraMin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuebraMin.Location = new System.Drawing.Point(202, 124);
            this.txtQuebraMin.Name = "txtQuebraMin";
            this.txtQuebraMin.Size = new System.Drawing.Size(95, 23);
            this.txtQuebraMin.TabIndex = 3;
            // 
            // lblQuebraMin
            // 
            this.lblQuebraMin.AutoSize = true;
            this.lblQuebraMin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuebraMin.Location = new System.Drawing.Point(12, 125);
            this.lblQuebraMin.Name = "lblQuebraMin";
            this.lblQuebraMin.Size = new System.Drawing.Size(184, 18);
            this.lblQuebraMin.TabIndex = 10;
            this.lblQuebraMin.Text = "Quebra de recorde mín.";
            // 
            // txtQuebraMax
            // 
            this.txtQuebraMax.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuebraMax.Location = new System.Drawing.Point(202, 153);
            this.txtQuebraMax.Name = "txtQuebraMax";
            this.txtQuebraMax.Size = new System.Drawing.Size(95, 23);
            this.txtQuebraMax.TabIndex = 4;
            // 
            // lblQuebraMax
            // 
            this.lblQuebraMax.AutoSize = true;
            this.lblQuebraMax.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuebraMax.Location = new System.Drawing.Point(12, 154);
            this.lblQuebraMax.Name = "lblQuebraMax";
            this.lblQuebraMax.Size = new System.Drawing.Size(190, 18);
            this.lblQuebraMax.TabIndex = 8;
            this.lblQuebraMax.Text = "Quebra de recorde máx.";
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.Location = new System.Drawing.Point(202, 19);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(95, 38);
            this.btnVerTodos.TabIndex = 13;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(111, 191);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 38);
            this.btnNovo.TabIndex = 101;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseMnemonic = false;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(15, 191);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(90, 38);
            this.btnApagar.TabIndex = 102;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseMnemonic = false;
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(207, 191);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 38);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 242);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.btnSalvar);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJogo";
            this.Text = "Cadastro jogo";
            this.Load += new System.EventHandler(this.FormJogo_Load);
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
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSalvar;
    }
}

