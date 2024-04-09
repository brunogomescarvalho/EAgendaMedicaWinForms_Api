namespace EAgendaMedicaWinForms.Views.Medicos
{
    partial class TelaCadastrarMedico
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
            radioDr = new RadioButton();
            radioDra = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtCrm = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioDr
            // 
            radioDr.AutoSize = true;
            radioDr.Location = new Point(17, 37);
            radioDr.Name = "radioDr";
            radioDr.Size = new Size(52, 24);
            radioDr.TabIndex = 0;
            radioDr.TabStop = true;
            radioDr.Text = "Drº";
            radioDr.UseVisualStyleBackColor = true;
            // 
            // radioDra
            // 
            radioDra.AutoSize = true;
            radioDra.Location = new Point(91, 37);
            radioDra.Name = "radioDra";
            radioDra.Size = new Size(60, 24);
            radioDra.TabIndex = 1;
            radioDra.TabStop = true;
            radioDra.Text = "Draª";
            radioDra.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioDra);
            groupBox1.Controls.Add(radioDr);
            groupBox1.Location = new Point(84, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 81);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prefixo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 142);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 180);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 4;
            label2.Text = "CRM:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(84, 139);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(241, 27);
            txtNome.TabIndex = 5;
            // 
            // txtCrm
            // 
            txtCrm.Location = new Point(84, 178);
            txtCrm.Name = "txtCrm";
            txtCrm.Size = new Size(241, 27);
            txtCrm.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(123, 233);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 40);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(231, 233);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastrarMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 309);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtCrm);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "TelaCadastrarMedico";
            Text = "TelaCadastrarMedico";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioDr;
        private RadioButton radioDra;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtCrm;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}