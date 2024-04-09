namespace EAgendaMedicaWinForms.Views.Autenticaco
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEntrar = new Button();
            label3 = new Label();
            txtLoginCarregando = new Label();
            groupBox1 = new GroupBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            LinkCadastrarUsuario = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(325, 265);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(111, 41);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += BtnEntrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F);
            label3.Location = new Point(91, 9);
            label3.Name = "label3";
            label3.Size = new Size(295, 47);
            label3.TabIndex = 5;
            label3.Text = "E-Agenda Médica";
            // 
            // txtLoginCarregando
            // 
            txtLoginCarregando.AutoSize = true;
            txtLoginCarregando.Location = new Point(26, 229);
            txtLoginCarregando.Name = "txtLoginCarregando";
            txtLoginCarregando.Size = new Size(0, 20);
            txtLoginCarregando.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 138);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(101, 92);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(284, 27);
            txtSenha.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(101, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 27);
            txtEmail.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(26, 92);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 5;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 4;
            label1.Text = "E-mail:";
            // 
            // LinkCadastrarUsuario
            // 
            LinkCadastrarUsuario.AutoSize = true;
            LinkCadastrarUsuario.LinkColor = Color.Black;
            LinkCadastrarUsuario.Location = new Point(26, 286);
            LinkCadastrarUsuario.Name = "LinkCadastrarUsuario";
            LinkCadastrarUsuario.Size = new Size(218, 20);
            LinkCadastrarUsuario.TabIndex = 8;
            LinkCadastrarUsuario.TabStop = true;
            LinkCadastrarUsuario.Text = "Não tem cadastro? Clique aqui!";
            LinkCadastrarUsuario.LinkClicked += LinkCadastrarUsuario_LinkClicked;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 341);
            Controls.Add(LinkCadastrarUsuario);
            Controls.Add(groupBox1);
            Controls.Add(txtLoginCarregando);
            Controls.Add(label3);
            Controls.Add(btnEntrar);
            Name = "TelaLogin";
            Text = "EAgenda Médica - Login";
            FormClosing += TelaLogin_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEntrar;
        private Label label3;
        private Label txtLoginCarregando;
        private GroupBox groupBox1;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private LinkLabel LinkCadastrarUsuario;
    }
}
