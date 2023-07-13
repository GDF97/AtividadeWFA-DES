namespace atividadeWFA
{
    partial class FormCarro
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.cbPortaMalas = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbTrac = new System.Windows.Forms.GroupBox();
            this.rdbTracDia = new System.Windows.Forms.RadioButton();
            this.rdbTracTras = new System.Windows.Forms.RadioButton();
            this.rdbTrac4 = new System.Windows.Forms.RadioButton();
            this.gbBag = new System.Windows.Forms.GroupBox();
            this.rdbBagNao = new System.Windows.Forms.RadioButton();
            this.rdbBagSim = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDadosCarros = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbTrac.SuspendLayout();
            this.gbBag.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.txtAno);
            this.tabPage1.Controls.Add(this.cbPortaMalas);
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.btnCadastrar);
            this.tabPage1.Controls.Add(this.gbTrac);
            this.tabPage1.Controls.Add(this.gbBag);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCor);
            this.tabPage1.Controls.Add(this.txtPlaca);
            this.tabPage1.Controls.Add(this.cbModelo);
            this.tabPage1.Controls.Add(this.txtFabricante);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtAno.Location = new System.Drawing.Point(43, 161);
            this.txtAno.MaxLength = 4;
            this.txtAno.Multiline = true;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(153, 33);
            this.txtAno.TabIndex = 22;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // cbPortaMalas
            // 
            this.cbPortaMalas.BackColor = System.Drawing.SystemColors.Window;
            this.cbPortaMalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortaMalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbPortaMalas.FormattingEnabled = true;
            this.cbPortaMalas.Items.AddRange(new object[] {
            "100-500litros",
            "500-1000litros",
            "1000-2000litros",
            "2000litros+"});
            this.cbPortaMalas.Location = new System.Drawing.Point(532, 161);
            this.cbPortaMalas.Name = "cbPortaMalas";
            this.cbPortaMalas.Size = new System.Drawing.Size(191, 33);
            this.cbPortaMalas.TabIndex = 21;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(573, 323);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 48);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(376, 323);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(150, 48);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gbTrac
            // 
            this.gbTrac.Controls.Add(this.rdbTracDia);
            this.gbTrac.Controls.Add(this.rdbTracTras);
            this.gbTrac.Controls.Add(this.rdbTrac4);
            this.gbTrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrac.Location = new System.Drawing.Point(523, 229);
            this.gbTrac.Name = "gbTrac";
            this.gbTrac.Size = new System.Drawing.Size(200, 62);
            this.gbTrac.TabIndex = 18;
            this.gbTrac.TabStop = false;
            this.gbTrac.Text = "Tração";
            // 
            // rdbTracDia
            // 
            this.rdbTracDia.AutoSize = true;
            this.rdbTracDia.Location = new System.Drawing.Point(54, 30);
            this.rdbTracDia.Name = "rdbTracDia";
            this.rdbTracDia.Size = new System.Drawing.Size(67, 17);
            this.rdbTracDia.TabIndex = 2;
            this.rdbTracDia.Text = "Dianteira";
            this.rdbTracDia.UseVisualStyleBackColor = true;
            // 
            // rdbTracTras
            // 
            this.rdbTracTras.AutoSize = true;
            this.rdbTracTras.Location = new System.Drawing.Point(127, 30);
            this.rdbTracTras.Name = "rdbTracTras";
            this.rdbTracTras.Size = new System.Drawing.Size(63, 17);
            this.rdbTracTras.TabIndex = 1;
            this.rdbTracTras.Text = "Traseira";
            this.rdbTracTras.UseVisualStyleBackColor = true;
            // 
            // rdbTrac4
            // 
            this.rdbTrac4.AutoSize = true;
            this.rdbTrac4.Location = new System.Drawing.Point(6, 30);
            this.rdbTrac4.Name = "rdbTrac4";
            this.rdbTrac4.Size = new System.Drawing.Size(42, 17);
            this.rdbTrac4.TabIndex = 0;
            this.rdbTrac4.Text = "4x4";
            this.rdbTrac4.UseVisualStyleBackColor = true;
            // 
            // gbBag
            // 
            this.gbBag.Controls.Add(this.rdbBagNao);
            this.gbBag.Controls.Add(this.rdbBagSim);
            this.gbBag.Controls.Add(this.label9);
            this.gbBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBag.Location = new System.Drawing.Point(44, 229);
            this.gbBag.Name = "gbBag";
            this.gbBag.Size = new System.Drawing.Size(200, 62);
            this.gbBag.TabIndex = 15;
            this.gbBag.TabStop = false;
            this.gbBag.Text = "Bagageiro";
            // 
            // rdbBagNao
            // 
            this.rdbBagNao.AutoSize = true;
            this.rdbBagNao.Location = new System.Drawing.Point(149, 39);
            this.rdbBagNao.Name = "rdbBagNao";
            this.rdbBagNao.Size = new System.Drawing.Size(45, 17);
            this.rdbBagNao.TabIndex = 17;
            this.rdbBagNao.TabStop = true;
            this.rdbBagNao.Text = "Não";
            this.rdbBagNao.UseVisualStyleBackColor = true;
            // 
            // rdbBagSim
            // 
            this.rdbBagSim.AutoSize = true;
            this.rdbBagSim.Location = new System.Drawing.Point(6, 39);
            this.rdbBagSim.Name = "rdbBagSim";
            this.rdbBagSim.Size = new System.Drawing.Size(42, 17);
            this.rdbBagSim.TabIndex = 16;
            this.rdbBagSim.TabStop = true;
            this.rdbBagSim.Text = "Sim";
            this.rdbBagSim.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tem Bagageiro?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(528, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cap. Porta Malas";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(232, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cor";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ano";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Placa";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fabricante";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modelo";
            // 
            // txtCor
            // 
            this.txtCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCor.Location = new System.Drawing.Point(236, 161);
            this.txtCor.Multiline = true;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(268, 33);
            this.txtCor.TabIndex = 7;
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPlaca.Location = new System.Drawing.Point(532, 91);
            this.txtPlaca.Multiline = true;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(191, 33);
            this.txtPlaca.TabIndex = 3;
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "Hatch",
            "Sedan",
            "Picape",
            "SUV",
            "Esportivo",
            "Conversivel",
            "Jipe"});
            this.cbModelo.Location = new System.Drawing.Point(44, 91);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(152, 33);
            this.cbModelo.TabIndex = 2;
            // 
            // txtFabricante
            // 
            this.txtFabricante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFabricante.Location = new System.Drawing.Point(236, 91);
            this.txtFabricante.Multiline = true;
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(268, 33);
            this.txtFabricante.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Carro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.btnLimparTudo);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.dgvDadosCarros);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            // 
            // dgvDadosCarros
            // 
            this.dgvDadosCarros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDadosCarros.BackgroundColor = System.Drawing.Color.White;
            this.dgvDadosCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvDadosCarros.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDadosCarros.Location = new System.Drawing.Point(8, 61);
            this.dgvDadosCarros.Name = "dgvDadosCarros";
            this.dgvDadosCarros.Size = new System.Drawing.Size(783, 246);
            this.dgvDadosCarros.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Modelo";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fabricante";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Placa";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ano";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cor";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 70;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Cap. PortaMalas";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Bagageiro";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Width = 70;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tração";
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(787, 38);
            this.label10.TabIndex = 0;
            this.label10.Text = "Consulta de Carro";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Location = new System.Drawing.Point(449, 345);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 48);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLimparTudo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimparTudo.Location = new System.Drawing.Point(641, 345);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(150, 48);
            this.btnLimparTudo.TabIndex = 23;
            this.btnLimparTudo.Text = "Limpar Tudo";
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // FormCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCarro";
            this.Text = "FormCarro";
            this.Load += new System.EventHandler(this.FormCarro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbTrac.ResumeLayout(false);
            this.gbTrac.PerformLayout();
            this.gbBag.ResumeLayout(false);
            this.gbBag.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCarros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gbTrac;
        private System.Windows.Forms.RadioButton rdbTracDia;
        private System.Windows.Forms.RadioButton rdbTracTras;
        private System.Windows.Forms.RadioButton rdbTrac4;
        private System.Windows.Forms.GroupBox gbBag;
        private System.Windows.Forms.RadioButton rdbBagNao;
        private System.Windows.Forms.RadioButton rdbBagSim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDadosCarros;
        private System.Windows.Forms.ComboBox cbPortaMalas;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimparTudo;
    }
}