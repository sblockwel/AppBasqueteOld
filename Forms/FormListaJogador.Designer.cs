namespace AppBasquete.Forms
{
    partial class FormListaJogador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaJogador));
            this.dataListaJogadores = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblPesquisa = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.lblFiltro = new System.Windows.Forms.ToolStripLabel();
            this.comboPesquisa = new System.Windows.Forms.ToolStripComboBox();
            this.jogosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumCamisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogadorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaJogadores)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaJogadores
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataListaJogadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListaJogadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListaJogadores.AutoGenerateColumns = false;
            this.dataListaJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ColumnNome,
            this.ColumnDataNasc,
            this.ColumnIdade,
            this.ColumnSexo,
            this.ColumnTime,
            this.ColumnTecnico,
            this.ColumnNumCamisa});
            this.dataListaJogadores.DataSource = this.jogadorBindingSource1;
            this.dataListaJogadores.Location = new System.Drawing.Point(12, 28);
            this.dataListaJogadores.MultiSelect = false;
            this.dataListaJogadores.Name = "dataListaJogadores";
            this.dataListaJogadores.RowHeadersVisible = false;
            this.dataListaJogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListaJogadores.Size = new System.Drawing.Size(648, 236);
            this.dataListaJogadores.TabIndex = 0;
            this.dataListaJogadores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaJogadores_CellContentDoubleClick);
            this.dataListaJogadores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataListaJogadores_CellFormatting);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPesquisa,
            this.txtPesquisa,
            this.lblFiltro,
            this.comboPesquisa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(62, 22);
            this.lblPesquisa.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPesquisa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(116, 25);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(68, 22);
            this.lblFiltro.Text = "Filtrar por:";
            // 
            // comboPesquisa
            // 
            this.comboPesquisa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboPesquisa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPesquisa.Name = "comboPesquisa";
            this.comboPesquisa.Size = new System.Drawing.Size(140, 25);
            // 
            // jogosBindingSource
            // 
            this.jogosBindingSource.DataMember = "Jogos";
            this.jogosBindingSource.DataSource = this.jogadorBindingSource1;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.DataPropertyName = "Nome";
            this.ColumnNome.HeaderText = "Jogador";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnDataNasc
            // 
            this.ColumnDataNasc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDataNasc.DataPropertyName = "DataNasc";
            this.ColumnDataNasc.HeaderText = "Data de Nascimento";
            this.ColumnDataNasc.Name = "ColumnDataNasc";
            // 
            // ColumnIdade
            // 
            this.ColumnIdade.DataPropertyName = "Idade";
            this.ColumnIdade.HeaderText = "Idade";
            this.ColumnIdade.Name = "ColumnIdade";
            this.ColumnIdade.ReadOnly = true;
            this.ColumnIdade.Width = 50;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSexo.DataPropertyName = "Sexo";
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            // 
            // ColumnTime
            // 
            this.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTime.DataPropertyName = "Time";
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.Name = "ColumnTime";
            // 
            // ColumnTecnico
            // 
            this.ColumnTecnico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTecnico.DataPropertyName = "Tecnico";
            this.ColumnTecnico.HeaderText = "Técnico";
            this.ColumnTecnico.Name = "ColumnTecnico";
            // 
            // ColumnNumCamisa
            // 
            this.ColumnNumCamisa.DataPropertyName = "NumCamisa";
            this.ColumnNumCamisa.HeaderText = "N° Camisa";
            this.ColumnNumCamisa.Name = "ColumnNumCamisa";
            this.ColumnNumCamisa.Width = 60;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // jogadorBindingSource1
            // 
            this.jogadorBindingSource1.DataSource = typeof(AppBasquete.Models.Jogador);
            // 
            // jogadorBindingSource
            // 
            this.jogadorBindingSource.DataSource = typeof(AppBasquete.Models.Jogador);
            // 
            // FormListaJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 276);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataListaJogadores);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaJogador";
            this.Text = "Consulta de Jogodores";
            this.Load += new System.EventHandler(this.FormListaJogador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaJogadores)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaJogadores;
        private System.Windows.Forms.BindingSource jogadorBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblPesquisa;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.ToolStripComboBox comboPesquisa;
        private System.Windows.Forms.ToolStripLabel lblFiltro;
        private System.Windows.Forms.BindingSource jogadorBindingSource1;
        private System.Windows.Forms.BindingSource jogosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumCamisa;
    }
}