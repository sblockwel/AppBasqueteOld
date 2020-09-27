namespace AppBasquete
{
    partial class FormJogos
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
            this.dataJogos = new System.Windows.Forms.DataGridView();
            this.jogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimoTemporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximoTemporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quebraRecordeMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quebraRecordeMaximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataJogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataJogos
            // 
            this.dataJogos.AutoGenerateColumns = false;
            this.dataJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataJogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.placarDataGridViewTextBoxColumn,
            this.minimoTemporadaDataGridViewTextBoxColumn,
            this.maximoTemporadaDataGridViewTextBoxColumn,
            this.quebraRecordeMinimoDataGridViewTextBoxColumn,
            this.quebraRecordeMaximoDataGridViewTextBoxColumn});
            this.dataJogos.DataSource = this.jogoBindingSource;
            this.dataJogos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataJogos.Location = new System.Drawing.Point(0, 0);
            this.dataJogos.Name = "dataJogos";
            this.dataJogos.Size = new System.Drawing.Size(643, 436);
            this.dataJogos.TabIndex = 0;
            // 
            // jogoBindingSource
            // 
            this.jogoBindingSource.DataSource = typeof(AppBasquete.Models.Jogo);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // placarDataGridViewTextBoxColumn
            // 
            this.placarDataGridViewTextBoxColumn.DataPropertyName = "Placar";
            this.placarDataGridViewTextBoxColumn.HeaderText = "Placar";
            this.placarDataGridViewTextBoxColumn.Name = "placarDataGridViewTextBoxColumn";
            // 
            // minimoTemporadaDataGridViewTextBoxColumn
            // 
            this.minimoTemporadaDataGridViewTextBoxColumn.DataPropertyName = "MinimoTemporada";
            this.minimoTemporadaDataGridViewTextBoxColumn.HeaderText = "MinimoTemporada";
            this.minimoTemporadaDataGridViewTextBoxColumn.Name = "minimoTemporadaDataGridViewTextBoxColumn";
            // 
            // maximoTemporadaDataGridViewTextBoxColumn
            // 
            this.maximoTemporadaDataGridViewTextBoxColumn.DataPropertyName = "MaximoTemporada";
            this.maximoTemporadaDataGridViewTextBoxColumn.HeaderText = "MaximoTemporada";
            this.maximoTemporadaDataGridViewTextBoxColumn.Name = "maximoTemporadaDataGridViewTextBoxColumn";
            // 
            // quebraRecordeMinimoDataGridViewTextBoxColumn
            // 
            this.quebraRecordeMinimoDataGridViewTextBoxColumn.DataPropertyName = "QuebraRecordeMinimo";
            this.quebraRecordeMinimoDataGridViewTextBoxColumn.HeaderText = "QuebraRecordeMinimo";
            this.quebraRecordeMinimoDataGridViewTextBoxColumn.Name = "quebraRecordeMinimoDataGridViewTextBoxColumn";
            // 
            // quebraRecordeMaximoDataGridViewTextBoxColumn
            // 
            this.quebraRecordeMaximoDataGridViewTextBoxColumn.DataPropertyName = "QuebraRecordeMaximo";
            this.quebraRecordeMaximoDataGridViewTextBoxColumn.HeaderText = "QuebraRecordeMaximo";
            this.quebraRecordeMaximoDataGridViewTextBoxColumn.Name = "quebraRecordeMaximoDataGridViewTextBoxColumn";
            // 
            // FormJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 436);
            this.Controls.Add(this.dataJogos);
            this.Name = "FormJogos";
            this.Text = "FormJogos";
            this.Load += new System.EventHandler(this.FormJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataJogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataJogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimoTemporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximoTemporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quebraRecordeMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quebraRecordeMaximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jogoBindingSource;
    }
}