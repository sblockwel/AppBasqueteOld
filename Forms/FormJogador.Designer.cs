namespace AppBasquete.Forms
{
    partial class FormJogador
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.comboTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.dateTimeDataNasc = new System.Windows.Forms.DateTimePicker();
            this.lblTecnici = new System.Windows.Forms.Label();
            this.comboTecnico = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.txtOutro = new System.Windows.Forms.TextBox();
            this.lblOutro = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(78, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Jogador";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(82, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(334, 21);
            this.txtNome.TabIndex = 1;
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdJogador.Location = new System.Drawing.Point(17, 29);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.ReadOnly = true;
            this.txtIdJogador.Size = new System.Drawing.Size(53, 21);
            this.txtIdJogador.TabIndex = 2;
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJogador.Location = new System.Drawing.Point(14, 13);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(19, 13);
            this.lblIdJogador.TabIndex = 3;
            this.lblIdJogador.Text = "Id";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(14, 53);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(104, 13);
            this.lblDataNasc.TabIndex = 4;
            this.lblDataNasc.Text = "Data Nascimento";
            // 
            // comboTime
            // 
            this.comboTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTime.FormattingEnabled = true;
            this.comboTime.Items.AddRange(new object[] {
            "Time 1",
            "Time 2",
            "Time 3"});
            this.comboTime.Location = new System.Drawing.Point(17, 108);
            this.comboTime.Name = "comboTime";
            this.comboTime.Size = new System.Drawing.Size(158, 21);
            this.comboTime.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(14, 92);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // dateTimeDataNasc
            // 
            this.dateTimeDataNasc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataNasc.Location = new System.Drawing.Point(17, 69);
            this.dateTimeDataNasc.Name = "dateTimeDataNasc";
            this.dateTimeDataNasc.Size = new System.Drawing.Size(107, 21);
            this.dateTimeDataNasc.TabIndex = 8;
            // 
            // lblTecnici
            // 
            this.lblTecnici.AutoSize = true;
            this.lblTecnici.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnici.Location = new System.Drawing.Point(180, 92);
            this.lblTecnici.Name = "lblTecnici";
            this.lblTecnici.Size = new System.Drawing.Size(50, 13);
            this.lblTecnici.TabIndex = 10;
            this.lblTecnici.Text = "Técnico";
            // 
            // comboTecnico
            // 
            this.comboTecnico.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTecnico.FormattingEnabled = true;
            this.comboTecnico.Items.AddRange(new object[] {
            "Time 1",
            "Time 2",
            "Time 3"});
            this.comboTecnico.Location = new System.Drawing.Point(183, 108);
            this.comboTecnico.Name = "comboTecnico";
            this.comboTecnico.Size = new System.Drawing.Size(233, 21);
            this.comboTecnico.TabIndex = 9;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(185, 53);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(36, 13);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo";
            // 
            // comboSexo
            // 
            this.comboSexo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outro (Especifique)",
            "Prefiro não informar"});
            this.comboSexo.Location = new System.Drawing.Point(188, 69);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(104, 21);
            this.comboSexo.TabIndex = 12;
            this.comboSexo.SelectedIndexChanged += new System.EventHandler(this.comboSexo_SelectedIndexChanged);
            // 
            // txtOutro
            // 
            this.txtOutro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutro.Location = new System.Drawing.Point(300, 69);
            this.txtOutro.Name = "txtOutro";
            this.txtOutro.Size = new System.Drawing.Size(116, 21);
            this.txtOutro.TabIndex = 13;
            this.txtOutro.Visible = false;
            // 
            // lblOutro
            // 
            this.lblOutro.AutoSize = true;
            this.lblOutro.Location = new System.Drawing.Point(297, 53);
            this.lblOutro.Name = "lblOutro";
            this.lblOutro.Size = new System.Drawing.Size(39, 13);
            this.lblOutro.TabIndex = 14;
            this.lblOutro.Text = "Outro";
            this.lblOutro.Visible = false;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(126, 53);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(40, 13);
            this.lblIdade.TabIndex = 15;
            this.lblIdade.Text = "Idade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(45, 21);
            this.textBox1.TabIndex = 16;
            // 
            // FormJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 260);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblOutro);
            this.Controls.Add(this.txtOutro);
            this.Controls.Add(this.comboSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblTecnici);
            this.Controls.Add(this.comboTecnico);
            this.Controls.Add(this.dateTimeDataNasc);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.comboTime);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormJogador";
            this.Text = "Cadastro de Jogador";
            this.Load += new System.EventHandler(this.FormJogador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.ComboBox comboTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dateTimeDataNasc;
        private System.Windows.Forms.Label lblTecnici;
        private System.Windows.Forms.ComboBox comboTecnico;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.TextBox txtOutro;
        private System.Windows.Forms.Label lblOutro;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox textBox1;
    }
}