namespace EAgendaMedicaWinForms.Views.Autenticacao
{
    partial class TelaCadastrarUsuarioForm
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
            groupBox1 = new GroupBox();
            TxtNome = new TextBox();
            LabelNome = new Label();
            TxtSenha = new TextBox();
            TxtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtLoginCarregando = new Label();
            label3 = new Label();
            btnEntrar = new Button();
            BtnCancelar = new Button();
            LabelProcessarRequisicao = new Label();
            TxtConfirmaSenha = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtConfirmaSenha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(LabelNome);
            groupBox1.Controls.Add(TxtSenha);
            groupBox1.Controls.Add(TxtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(44, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 263);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(186, 44);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(284, 27);
            TxtNome.TabIndex = 9;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Font = new Font("Segoe UI", 12F);
            LabelNome.Location = new Point(100, 42);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(70, 28);
            LabelNome.TabIndex = 8;
            LabelNome.Text = "Nome:";
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(186, 148);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(284, 27);
            TxtSenha.TabIndex = 7;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(186, 96);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(284, 27);
            TxtEmail.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(101, 148);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 5;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(99, 95);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 4;
            label1.Text = "E-mail:";
            // 
            // txtLoginCarregando
            // 
            txtLoginCarregando.AutoSize = true;
            txtLoginCarregando.Location = new Point(44, 252);
            txtLoginCarregando.Name = "txtLoginCarregando";
            txtLoginCarregando.Size = new Size(0, 20);
            txtLoginCarregando.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F);
            label3.Location = new Point(109, 32);
            label3.Name = "label3";
            label3.Size = new Size(295, 47);
            label3.TabIndex = 10;
            label3.Text = "E-Agenda Médica";
            // 
            // btnEntrar
            // 
            btnEntrar.DialogResult = DialogResult.OK;
            btnEntrar.Location = new Point(330, 400);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(111, 44);
            btnEntrar.TabIndex = 9;
            btnEntrar.Text = "Cadastrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += BtnCadastrar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.DialogResult = DialogResult.Cancel;
            BtnCancelar.Location = new Point(460, 400);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 44);
            BtnCancelar.TabIndex = 13;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // LabelProcessarRequisicao
            // 
            LabelProcessarRequisicao.AutoSize = true;
            LabelProcessarRequisicao.Location = new Point(46, 325);
            LabelProcessarRequisicao.Name = "LabelProcessarRequisicao";
            LabelProcessarRequisicao.Size = new Size(0, 20);
            LabelProcessarRequisicao.TabIndex = 14;
            // 
            // TxtConfirmaSenha
            // 
            TxtConfirmaSenha.Location = new Point(186, 200);
            TxtConfirmaSenha.Name = "TxtConfirmaSenha";
            TxtConfirmaSenha.Size = new Size(284, 27);
            TxtConfirmaSenha.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(9, 201);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 10;
            label4.Text = "Confirmar Senha:";
            // 
            // TelaCadastrarUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 497);
            Controls.Add(LabelProcessarRequisicao);
            Controls.Add(BtnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(txtLoginCarregando);
            Controls.Add(label3);
            Controls.Add(btnEntrar);
            Name = "TelaCadastrarUsuarioForm";
            Text = "CadastrarUsuarioForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtNome;
        private Label LabelNome;
        private TextBox TxtSenha;
        private TextBox TxtEmail;
        private Label label2;
        private Label label1;
        private Label txtLoginCarregando;
        private Label label3;
        private Button btnEntrar;
        private Button BtnCancelar;
        private Label LabelProcessarRequisicao;
        private TextBox TxtConfirmaSenha;
        private Label label4;
    }
}