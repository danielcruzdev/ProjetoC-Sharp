﻿namespace ProjetoAstor.Formulários
{
    partial class frmCadastroTransportadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroTransportadora));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.tstSalvar = new System.Windows.Forms.ToolStripButton();
            this.tstExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.traDados = new System.Windows.Forms.TabPage();
            this.grpTransportadora = new System.Windows.Forms.GroupBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.traPesquisar = new System.Windows.Forms.TabPage();
            this.dgvTransportadoras = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.traDados.SuspendLayout();
            this.grpTransportadora.SuspendLayout();
            this.traPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportadoras)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.tstSalvar,
            this.tstExcluir,
            this.toolStripSeparator1,
            this.tstSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(852, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 22);
            this.btnNovo.Text = "&Novo";
            this.btnNovo.ToolTipText = "Clique para Salvar";
            // 
            // tstSalvar
            // 
            this.tstSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tstSalvar.Image")));
            this.tstSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSalvar.Name = "tstSalvar";
            this.tstSalvar.Size = new System.Drawing.Size(45, 22);
            this.tstSalvar.Text = "&Salvar ";
            this.tstSalvar.ToolTipText = "Salvar Cliente";
            // 
            // tstExcluir
            // 
            this.tstExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tstExcluir.Image")));
            this.tstExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstExcluir.Name = "tstExcluir";
            this.tstExcluir.Size = new System.Drawing.Size(45, 22);
            this.tstExcluir.Text = "&Excluir";
            this.tstExcluir.ToolTipText = "Excluir Cliente";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tstSair
            // 
            this.tstSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstSair.Image = ((System.Drawing.Image)(resources.GetObject("tstSair.Image")));
            this.tstSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstSair.Name = "tstSair";
            this.tstSair.Size = new System.Drawing.Size(30, 22);
            this.tstSair.Text = "S&air";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.traDados);
            this.tabControl1.Controls.Add(this.traPesquisar);
            this.tabControl1.Location = new System.Drawing.Point(8, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 306);
            this.tabControl1.TabIndex = 4;
            // 
            // traDados
            // 
            this.traDados.Controls.Add(this.grpTransportadora);
            this.traDados.Location = new System.Drawing.Point(4, 22);
            this.traDados.Name = "traDados";
            this.traDados.Padding = new System.Windows.Forms.Padding(3);
            this.traDados.Size = new System.Drawing.Size(830, 280);
            this.traDados.TabIndex = 0;
            this.traDados.Text = "Dados da Transportadora";
            this.traDados.UseVisualStyleBackColor = true;
            // 
            // grpTransportadora
            // 
            this.grpTransportadora.Controls.Add(this.lblNomeFantasia);
            this.grpTransportadora.Controls.Add(this.txtNomeFantasia);
            this.grpTransportadora.Controls.Add(this.btnPesquisar);
            this.grpTransportadora.Controls.Add(this.lblObservacao);
            this.grpTransportadora.Controls.Add(this.txtObservacao);
            this.grpTransportadora.Controls.Add(this.lblEmail);
            this.grpTransportadora.Controls.Add(this.txtEmail);
            this.grpTransportadora.Controls.Add(this.mskCelular);
            this.grpTransportadora.Controls.Add(this.lblCelular);
            this.grpTransportadora.Controls.Add(this.mskTelefone);
            this.grpTransportadora.Controls.Add(this.lblTelefone);
            this.grpTransportadora.Controls.Add(this.cmbEstado);
            this.grpTransportadora.Controls.Add(this.lblEstado);
            this.grpTransportadora.Controls.Add(this.lblCidade);
            this.grpTransportadora.Controls.Add(this.txtCidade);
            this.grpTransportadora.Controls.Add(this.lblBairro);
            this.grpTransportadora.Controls.Add(this.txtBairro);
            this.grpTransportadora.Controls.Add(this.label3);
            this.grpTransportadora.Controls.Add(this.txtNumero);
            this.grpTransportadora.Controls.Add(this.lblEndereco);
            this.grpTransportadora.Controls.Add(this.txtEndereco);
            this.grpTransportadora.Controls.Add(this.mskCEP);
            this.grpTransportadora.Controls.Add(this.lblCEP);
            this.grpTransportadora.Controls.Add(this.mskCNPJ);
            this.grpTransportadora.Controls.Add(this.lblCNPJ);
            this.grpTransportadora.Controls.Add(this.lblRazaoSocial);
            this.grpTransportadora.Controls.Add(this.txtRazaoSocial);
            this.grpTransportadora.Controls.Add(this.txtCodigo);
            this.grpTransportadora.Controls.Add(this.label1);
            this.grpTransportadora.Location = new System.Drawing.Point(7, 0);
            this.grpTransportadora.Name = "grpTransportadora";
            this.grpTransportadora.Size = new System.Drawing.Size(816, 270);
            this.grpTransportadora.TabIndex = 0;
            this.grpTransportadora.TabStop = false;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(482, 16);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(100, 16);
            this.lblNomeFantasia.TabIndex = 43;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Location = new System.Drawing.Point(485, 33);
            this.txtNomeFantasia.MaxLength = 100;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(317, 20);
            this.txtNomeFantasia.TabIndex = 42;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(86, 124);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(24, 24);
            this.btnPesquisar.TabIndex = 41;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(14, 151);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(83, 16);
            this.lblObservacao.TabIndex = 37;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(17, 168);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(790, 86);
            this.txtObservacao.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(140, 58);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(439, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(716, 75);
            this.mskCelular.Mask = "(00)00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(86, 20);
            this.mskCelular.TabIndex = 14;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(713, 56);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 16);
            this.lblCelular.TabIndex = 30;
            this.lblCelular.Text = "Celular";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(596, 77);
            this.mskTelefone.Mask = "(00)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(78, 20);
            this.mskTelefone.TabIndex = 13;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(593, 58);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(62, 16);
            this.lblTelefone.TabIndex = 28;
            this.lblTelefone.Text = "Telefone";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC\t ",
            "AL\t ",
            "AP\t ",
            "AM\t ",
            "BA\t ",
            "CE\t ",
            "DF\t ",
            "ES\t ",
            "GO\t ",
            "MA\t ",
            "MT\t ",
            "MS\t ",
            "MG\t ",
            "PA\t ",
            "PB\t ",
            "PR\t ",
            "PE\t ",
            "PI\t ",
            "RJ\t ",
            "RN\t ",
            "RS\t ",
            "RO\t ",
            "RR\t ",
            "SC\t ",
            "SP\t ",
            "SE\t ",
            "TO"});
            this.cmbEstado.Location = new System.Drawing.Point(739, 124);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(63, 21);
            this.cmbEstado.TabIndex = 12;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(738, 105);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 16);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(593, 108);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 16);
            this.lblCidade.TabIndex = 25;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(596, 125);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(128, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(456, 108);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 16);
            this.lblBairro.TabIndex = 23;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(459, 125);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(128, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(358, 125);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(83, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(121, 108);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(67, 16);
            this.lblEndereco.TabIndex = 19;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(124, 125);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(219, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(17, 127);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(63, 20);
            this.mskCEP.TabIndex = 7;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(14, 108);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 16);
            this.lblCEP.TabIndex = 16;
            this.lblCEP.Text = "CEP";
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(14, 77);
            this.mskCNPJ.Mask = "00.000.000/0000-00";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(108, 20);
            this.mskCNPJ.TabIndex = 3;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(11, 58);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(43, 16);
            this.lblCNPJ.TabIndex = 6;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(140, 16);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(89, 16);
            this.lblRazaoSocial.TabIndex = 3;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Location = new System.Drawing.Point(143, 33);
            this.txtRazaoSocial.MaxLength = 100;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(317, 20);
            this.txtRazaoSocial.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(14, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // traPesquisar
            // 
            this.traPesquisar.Controls.Add(this.dgvTransportadoras);
            this.traPesquisar.Controls.Add(this.txtFiltro);
            this.traPesquisar.Controls.Add(this.lblFiltro);
            this.traPesquisar.Controls.Add(this.cboOpcao);
            this.traPesquisar.Controls.Add(this.lblOpcao);
            this.traPesquisar.Location = new System.Drawing.Point(4, 22);
            this.traPesquisar.Name = "traPesquisar";
            this.traPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.traPesquisar.Size = new System.Drawing.Size(830, 280);
            this.traPesquisar.TabIndex = 1;
            this.traPesquisar.Text = "Pesquisar";
            this.traPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvTransportadoras
            // 
            this.dgvTransportadoras.AllowUserToAddRows = false;
            this.dgvTransportadoras.AllowUserToDeleteRows = false;
            this.dgvTransportadoras.AllowUserToOrderColumns = true;
            this.dgvTransportadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportadoras.Location = new System.Drawing.Point(6, 59);
            this.dgvTransportadoras.Name = "dgvTransportadoras";
            this.dgvTransportadoras.ReadOnly = true;
            this.dgvTransportadoras.Size = new System.Drawing.Size(750, 242);
            this.dgvTransportadoras.TabIndex = 4;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(206, 32);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(550, 20);
            this.txtFiltro.TabIndex = 3;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(203, 13);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(37, 16);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtro";
            // 
            // cboOpcao
            // 
            this.cboOpcao.FormattingEnabled = true;
            this.cboOpcao.Items.AddRange(new object[] {
            "CÓDIGO",
            "RAZÃO SOCIAL",
            "NOME FANTASIA",
            "ENDEREÇO",
            "CIDADE",
            "ESTADO"});
            this.cboOpcao.Location = new System.Drawing.Point(10, 32);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(156, 21);
            this.cboOpcao.TabIndex = 1;
            this.cboOpcao.Text = "RAZÃO SOCIAL";
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcao.Location = new System.Drawing.Point(7, 13);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(128, 16);
            this.lblOpcao.TabIndex = 0;
            this.lblOpcao.Text = "Opção de Pesquisa";
            // 
            // frmCadastroTransportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 339);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCadastroTransportadora";
            this.Text = ".:::CADASTRO DE TRANSPORTADORA:::.";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.traDados.ResumeLayout(false);
            this.grpTransportadora.ResumeLayout(false);
            this.grpTransportadora.PerformLayout();
            this.traPesquisar.ResumeLayout(false);
            this.traPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportadoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton tstSalvar;
        private System.Windows.Forms.ToolStripButton tstExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tstSair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage traDados;
        private System.Windows.Forms.GroupBox grpTransportadora;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage traPesquisar;
        private System.Windows.Forms.DataGridView dgvTransportadoras;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.TextBox txtNomeFantasia;
    }
}