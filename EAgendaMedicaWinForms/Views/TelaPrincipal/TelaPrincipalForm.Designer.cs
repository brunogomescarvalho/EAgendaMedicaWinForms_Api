

namespace EAgendaMedicaWinForms.Views.TelaPrincipal
{
    partial class TelaPrincipalForm
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
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            BtnMedicos = new ToolStripMenuItem();
            BtnCoirurgias = new ToolStripMenuItem();
            BtnConsultas = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            BtnInserir = new ToolStripButton();
            BtnEditar = new ToolStripButton();
            BtnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            barraStatus = new ToolStripStatusLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            LabelTipoCadastro = new ToolStripLabel();
            painelRegistros = new Panel();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(0, 16);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BtnMedicos, BtnCoirurgias, BtnConsultas });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // BtnMedicos
            // 
            BtnMedicos.Name = "BtnMedicos";
            BtnMedicos.Size = new Size(79, 24);
            BtnMedicos.Text = "Médicos";
            BtnMedicos.Click += ClicarNaAbaMedico_Click;
            // 
            // BtnCoirurgias
            // 
            BtnCoirurgias.Name = "BtnCoirurgias";
            BtnCoirurgias.Size = new Size(81, 24);
            BtnCoirurgias.Text = "Cirurgias";
            // 
            // BtnConsultas
            // 
            BtnConsultas.Name = "BtnConsultas";
            BtnConsultas.Size = new Size(86, 24);
            BtnConsultas.Text = "Consultas";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ActiveCaption;
            toolStrip1.ImageScalingSize = new Size(30, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { BtnInserir, BtnEditar, BtnExcluir, toolStripSeparator1, barraStatus, toolStripSeparator2, LabelTipoCadastro });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 47);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // BtnInserir
            // 
            BtnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnInserir.Enabled = false;
            BtnInserir.Image = Properties.Resources.add_circle_FILL0_wght200_GRAD0_opsz40__1_;
            BtnInserir.ImageScaling = ToolStripItemImageScaling.None;
            BtnInserir.ImageTransparentColor = Color.Magenta;
            BtnInserir.Name = "BtnInserir";
            BtnInserir.Size = new Size(44, 44);
            BtnInserir.Text = "Cadastrar";
            BtnInserir.Click += BtnCadastrar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnEditar.Enabled = false;
            BtnEditar.Image = Properties.Resources.edit_FILL0_wght200_GRAD0_opsz40__1_;
            BtnEditar.ImageScaling = ToolStripItemImageScaling.None;
            BtnEditar.ImageTransparentColor = Color.Magenta;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(44, 44);
            BtnEditar.Text = "Editar";
            // 
            // BtnExcluir
            // 
            BtnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnExcluir.Enabled = false;
            BtnExcluir.Image = Properties.Resources.delete_FILL0_wght200_GRAD0_opsz40__1_;
            BtnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            BtnExcluir.ImageTransparentColor = Color.Magenta;
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(44, 44);
            BtnExcluir.Text = "Excluir";
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 47);
            // 
            // barraStatus
            // 
            barraStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            barraStatus.Name = "barraStatus";
            barraStatus.Size = new Size(0, 41);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 47);
            // 
            // LabelTipoCadastro
            // 
            LabelTipoCadastro.Name = "LabelTipoCadastro";
            LabelTipoCadastro.Size = new Size(0, 44);
            // 
            // painelRegistros
            // 
            painelRegistros.Dock = DockStyle.Fill;
            painelRegistros.Location = new Point(0, 75);
            painelRegistros.Name = "painelRegistros";
            painelRegistros.Size = new Size(800, 353);
            painelRegistros.TabIndex = 5;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(painelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipal";
            Text = "E-Agenda Médica";
            FormClosing += TelaPrincipal_FormClosing;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem BtnCoirurgias;
        private ToolStrip toolStrip1;
        private ToolStripButton BtnInserir;
        private ToolStripButton BtnEditar;
        private ToolStripStatusLabel barraStatus;
        private ToolStripButton BtnExcluir;
        private ToolStripMenuItem BtnConsultas;
        private DataGridView dataGridView1;
        private ToolStripMenuItem BtnMedicos;
        private ToolStripStatusLabel labelRodape;
        private ToolStripSeparator toolStripSeparator1;
        private Panel painelRegistros;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel LabelTipoCadastro;
    }
}