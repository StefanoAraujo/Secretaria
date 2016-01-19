namespace Secretaria.Formularios
{
    partial class PrimeiroAcesso
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
            this.lbl1Passo = new System.Windows.Forms.Label();
            this.group1Cadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.MaskCelular = new System.Windows.Forms.MaskedTextBox();
            this.maskRg = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNImovel = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl2Passo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.group3UsuarioSenha = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.comboNomes = new System.Windows.Forms.ComboBox();
            this.btnCadastrarFuncionarioNome = new System.Windows.Forms.Button();
            this.group2Nome = new System.Windows.Forms.GroupBox();
            this.group1Cadastro.SuspendLayout();
            this.group3UsuarioSenha.SuspendLayout();
            this.group2Nome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1Passo
            // 
            this.lbl1Passo.AutoSize = true;
            this.lbl1Passo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Passo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl1Passo.Location = new System.Drawing.Point(33, 36);
            this.lbl1Passo.Name = "lbl1Passo";
            this.lbl1Passo.Size = new System.Drawing.Size(249, 21);
            this.lbl1Passo.TabIndex = 0;
            this.lbl1Passo.Text = "1º Passo - Cadastro Funcionario";
            // 
            // group1Cadastro
            // 
            this.group1Cadastro.Controls.Add(this.group2Nome);
            this.group1Cadastro.Controls.Add(this.btnCadastrarFuncionario);
            this.group1Cadastro.Controls.Add(this.dateNascimento);
            this.group1Cadastro.Controls.Add(this.MaskCelular);
            this.group1Cadastro.Controls.Add(this.maskRg);
            this.group1Cadastro.Controls.Add(this.maskTelefone);
            this.group1Cadastro.Controls.Add(this.label12);
            this.group1Cadastro.Controls.Add(this.label11);
            this.group1Cadastro.Controls.Add(this.label10);
            this.group1Cadastro.Controls.Add(this.maskCpf);
            this.group1Cadastro.Controls.Add(this.label9);
            this.group1Cadastro.Controls.Add(this.label8);
            this.group1Cadastro.Controls.Add(this.label6);
            this.group1Cadastro.Controls.Add(this.label7);
            this.group1Cadastro.Controls.Add(this.label5);
            this.group1Cadastro.Controls.Add(this.label4);
            this.group1Cadastro.Controls.Add(this.txtNImovel);
            this.group1Cadastro.Controls.Add(this.txtCidade);
            this.group1Cadastro.Controls.Add(this.txtBairro);
            this.group1Cadastro.Controls.Add(this.txtEndereco);
            this.group1Cadastro.Controls.Add(this.txtDepartamento);
            this.group1Cadastro.Controls.Add(this.label3);
            this.group1Cadastro.Controls.Add(this.txtNome);
            this.group1Cadastro.Controls.Add(this.label2);
            this.group1Cadastro.Location = new System.Drawing.Point(10, 80);
            this.group1Cadastro.Name = "group1Cadastro";
            this.group1Cadastro.Size = new System.Drawing.Size(571, 510);
            this.group1Cadastro.TabIndex = 1;
            this.group1Cadastro.TabStop = false;
            this.group1Cadastro.Text = "1º Cadastro - Funcionario";
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(65, 454);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(455, 38);
            this.btnCadastrarFuncionario.TabIndex = 4;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btn_Click);
            // 
            // dateNascimento
            // 
            this.dateNascimento.Location = new System.Drawing.Point(187, 123);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(302, 29);
            this.dateNascimento.TabIndex = 3;
            this.dateNascimento.Value = new System.DateTime(2016, 1, 5, 0, 0, 0, 0);
            // 
            // MaskCelular
            // 
            this.MaskCelular.Location = new System.Drawing.Point(187, 263);
            this.MaskCelular.Mask = "(99) \\90000-0000";
            this.MaskCelular.Name = "MaskCelular";
            this.MaskCelular.Size = new System.Drawing.Size(131, 29);
            this.MaskCelular.TabIndex = 2;
            // 
            // maskRg
            // 
            this.maskRg.Location = new System.Drawing.Point(187, 193);
            this.maskRg.Mask = "00\\.000\\.000-A";
            this.maskRg.Name = "maskRg";
            this.maskRg.Size = new System.Drawing.Size(131, 29);
            this.maskRg.TabIndex = 2;
            // 
            // maskTelefone
            // 
            this.maskTelefone.Location = new System.Drawing.Point(187, 228);
            this.maskTelefone.Mask = "(99) 0000-0000";
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(131, 29);
            this.maskTelefone.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Numero do Imovel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bairro";
            // 
            // maskCpf
            // 
            this.maskCpf.Location = new System.Drawing.Point(187, 158);
            this.maskCpf.Mask = "000\\.000\\.000\\-00";
            this.maskCpf.Name = "maskCpf";
            this.maskCpf.Size = new System.Drawing.Size(131, 29);
            this.maskCpf.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "RG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data de Nascimento";
            // 
            // txtNImovel
            // 
            this.txtNImovel.Location = new System.Drawing.Point(187, 403);
            this.txtNImovel.Name = "txtNImovel";
            this.txtNImovel.Size = new System.Drawing.Size(83, 29);
            this.txtNImovel.TabIndex = 1;
            this.txtNImovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNImovel_KeyPress);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(187, 368);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(208, 29);
            this.txtCidade.TabIndex = 1;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(187, 333);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(208, 29);
            this.txtBairro.TabIndex = 1;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(187, 298);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(208, 29);
            this.txtEndereco.TabIndex = 1;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(187, 88);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(208, 29);
            this.txtDepartamento.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Departamento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(187, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(208, 29);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // lbl2Passo
            // 
            this.lbl2Passo.AutoSize = true;
            this.lbl2Passo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Passo.Location = new System.Drawing.Point(313, 36);
            this.lbl2Passo.Name = "lbl2Passo";
            this.lbl2Passo.Size = new System.Drawing.Size(188, 21);
            this.lbl2Passo.TabIndex = 0;
            this.lbl2Passo.Text = "2º Passo - Usuario Senha";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(283, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "->";
            // 
            // group3UsuarioSenha
            // 
            this.group3UsuarioSenha.Controls.Add(this.btnCadastrar);
            this.group3UsuarioSenha.Controls.Add(this.label13);
            this.group3UsuarioSenha.Controls.Add(this.label1);
            this.group3UsuarioSenha.Controls.Add(this.txtSenha);
            this.group3UsuarioSenha.Controls.Add(this.txtUsuario);
            this.group3UsuarioSenha.Location = new System.Drawing.Point(587, 80);
            this.group3UsuarioSenha.Name = "group3UsuarioSenha";
            this.group3UsuarioSenha.Size = new System.Drawing.Size(566, 510);
            this.group3UsuarioSenha.TabIndex = 3;
            this.group3UsuarioSenha.TabStop = false;
            this.group3UsuarioSenha.Text = "Usuario Senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(117, 430);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(397, 45);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar Usuario";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(117, 188);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(397, 29);
            this.txtSenha.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(117, 118);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(397, 29);
            this.txtUsuario.TabIndex = 0;
            // 
            // comboNomes
            // 
            this.comboNomes.FormattingEnabled = true;
            this.comboNomes.Location = new System.Drawing.Point(104, 94);
            this.comboNomes.Name = "comboNomes";
            this.comboNomes.Size = new System.Drawing.Size(329, 29);
            this.comboNomes.TabIndex = 0;
            // 
            // btnCadastrarFuncionarioNome
            // 
            this.btnCadastrarFuncionarioNome.Location = new System.Drawing.Point(104, 430);
            this.btnCadastrarFuncionarioNome.Name = "btnCadastrarFuncionarioNome";
            this.btnCadastrarFuncionarioNome.Size = new System.Drawing.Size(329, 45);
            this.btnCadastrarFuncionarioNome.TabIndex = 1;
            this.btnCadastrarFuncionarioNome.Text = "Cadastrar Funcionario";
            this.btnCadastrarFuncionarioNome.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionarioNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // group2Nome
            // 
            this.group2Nome.Controls.Add(this.btnCadastrarFuncionarioNome);
            this.group2Nome.Controls.Add(this.comboNomes);
            this.group2Nome.Location = new System.Drawing.Point(0, 0);
            this.group2Nome.Name = "group2Nome";
            this.group2Nome.Size = new System.Drawing.Size(571, 510);
            this.group2Nome.TabIndex = 2;
            this.group2Nome.TabStop = false;
            this.group2Nome.Text = "Nome";
            // 
            // PrimeiroAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 602);
            this.Controls.Add(this.group3UsuarioSenha);
            this.Controls.Add(this.lbl2Passo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl1Passo);
            this.Controls.Add(this.group1Cadastro);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrimeiroAcesso";
            this.Text = "Primeiro Acesso";
            this.Load += new System.EventHandler(this.PrimeiroAcesso_Load);
            this.group1Cadastro.ResumeLayout(false);
            this.group1Cadastro.PerformLayout();
            this.group3UsuarioSenha.ResumeLayout(false);
            this.group3UsuarioSenha.PerformLayout();
            this.group2Nome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1Passo;
        private System.Windows.Forms.GroupBox group1Cadastro;
        private System.Windows.Forms.MaskedTextBox maskRg;
        private System.Windows.Forms.MaskedTextBox maskCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.MaskedTextBox MaskCelular;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNImovel;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbl2Passo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox group3UsuarioSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox comboNomes;
        private System.Windows.Forms.Button btnCadastrarFuncionarioNome;
        private System.Windows.Forms.GroupBox group2Nome;

    }
}