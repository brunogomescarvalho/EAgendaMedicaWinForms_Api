namespace EAgendaMedicaWinForms.Views.TelaPrincipal
{
    partial class TabelaMedicos
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridMedicos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridMedicos).BeginInit();
            SuspendLayout();
            // 
            // dataGridMedicos
            // 
            dataGridMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMedicos.Dock = DockStyle.Fill;
            dataGridMedicos.Location = new Point(0, 0);
            dataGridMedicos.Name = "dataGridMedicos";
            dataGridMedicos.RowHeadersWidth = 51;
            dataGridMedicos.Size = new Size(150, 150);
            dataGridMedicos.TabIndex = 0;
            // 
            // TelaPrincipalUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridMedicos);
            Name = "TelaPrincipalUserControl";
            ((System.ComponentModel.ISupportInitialize)dataGridMedicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridMedicos;
    }
}
