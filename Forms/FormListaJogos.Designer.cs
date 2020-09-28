namespace AppBasquete.Forms
{
    partial class FormListaJogos
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
            this.dataJogos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColummNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimoTemporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximoTemporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quebraRecordeMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quebraRecordeMaximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.lblPesquisa = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.lblFiltro = new System.Windows.Forms.ToolStripLabel();
            this.comboPesquisa = new System.Windows.Forms.ToolStripComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataJogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).BeginInit();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataJogos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataJogos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataJogos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataJogos.AutoGenerateColumns = false;
            this.dataJogos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataJogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ColummNome,
            this.placarDataGridViewTextBoxColumn,
            this.minimoTemporadaDataGridViewTextBoxColumn,
            this.maximoTemporadaDataGridViewTextBoxColumn,
            this.quebraRecordeMinimoDataGridViewTextBoxColumn,
            this.quebraRecordeMaximoDataGridViewTextBoxColumn});
            this.dataJogos.DataSource = this.jogoBindingSource;
            this.dataJogos.Location = new System.Drawing.Point(0, 28);
            this.dataJogos.Name = "dataJogos";
            this.dataJogos.RowHeadersVisible = false;
            this.dataJogos.Size = new System.Drawing.Size(614, 263);
            this.dataJogos.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // ColummNome
            // 
            this.ColummNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColummNome.DataPropertyName = "Jogador";
            this.ColummNome.HeaderText = "Nome jogador";
            this.ColummNome.Name = "ColummNome";
            // 
            // placarDataGridViewTextBoxColumn
            // 
            this.placarDataGridViewTextBoxColumn.DataPropertyName = "Placar";
            this.placarDataGridViewTextBoxColumn.HeaderText = "Placar";
            this.placarDataGridViewTextBoxColumn.Name = "placarDataGridViewTextBoxColumn";
            this.placarDataGridViewTextBoxColumn.Width = 60;
            // 
            // minimoTemporadaDataGridViewTextBoxColumn
            // 
            this.minimoTemporadaDataGridViewTextBoxColumn.DataPropertyName = "MinimoTemporada";
            this.minimoTemporadaDataGridViewTextBoxColumn.HeaderText = "Pontos mín. ";
            this.minimoTemporadaDataGridViewTextBoxColumn.Name = "minimoTemporadaDataGridViewTextBoxColumn";
            this.minimoTemporadaDataGridViewTextBoxColumn.Width = 90;
            // 
            // maximoTemporadaDataGridViewTextBoxColumn
            // 
            this.maximoTemporadaDataGridViewTextBoxColumn.DataPropertyName = "MaximoTemporada";
            this.maximoTemporadaDataGridViewTextBoxColumn.HeaderText = "Pontos máx. ";
            this.maximoTemporadaDataGridViewTextBoxColumn.Name = "maximoTemporadaDataGridViewTextBoxColumn";
            this.maximoTemporadaDataGridViewTextBoxColumn.Width = 90;
            // 
            // quebraRecordeMinimoDataGridViewTextBoxColumn
            // 
            this.quebraRecordeMinimoDataGridViewTextBoxColumn.DataPropertyName = "QuebraRecordeMinimo";
            this.quebraRecordeMinimoDataGridViewTextBoxColumn.HeaderText = "Quebra recorde mín.";
            this.quebraRecordeMinimoDataGridViewTextBoxColumn.Name = "quebraRecordeMinimoDataGridViewTextBoxColumn";
            this.quebraRecordeMinimoDataGridViewTextBoxColumn.Width = 90;
            // 
            // quebraRecordeMaximoDataGridViewTextBoxColumn
            // 
            this.quebraRecordeMaximoDataGridViewTextBoxColumn.DataPropertyName = "QuebraRecordeMaximo";
            this.quebraRecordeMaximoDataGridViewTextBoxColumn.HeaderText = "Quebra recorde máx.";
            this.quebraRecordeMaximoDataGridViewTextBoxColumn.Name = "quebraRecordeMaximoDataGridViewTextBoxColumn";
            this.quebraRecordeMaximoDataGridViewTextBoxColumn.Width = 90;
            // 
            // jogoBindingSource
            // 
            this.jogoBindingSource.DataSource = typeof(AppBasquete.Models.Jogo);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPesquisa,
            this.txtPesquisa,
            this.lblFiltro,
            this.comboPesquisa});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(614, 25);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolStrip1";
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
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(72, 22);
            this.lblFiltro.Text = "Filtrar por: ";
            // 
            // comboPesquisa
            // 
            this.comboPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPesquisa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPesquisa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPesquisa.Items.AddRange(new object[] {
            "Nome Jogador",
            "Placar",
            "Pontos Mínimo",
            "Pontos Máximo",
            "Quebra Recorde Mín.",
            "Quebra Recorde Máx."});
            this.comboPesquisa.Name = "comboPesquisa";
            this.comboPesquisa.Size = new System.Drawing.Size(140, 25);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Jogador";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome jogador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // FormListaJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 291);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.dataJogos);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormListaJogos";
            this.Text = "Consulta Jogos";
            this.Load += new System.EventHandler(this.FormListaJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataJogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataJogos;
        private System.Windows.Forms.BindingSource jogoBindingSource;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.ToolStripLabel lblPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColummNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn placarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimoTemporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximoTemporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quebraRecordeMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quebraRecordeMaximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripComboBox comboPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripLabel lblFiltro;
    }
}