namespace XML_SQL
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Extrair = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CaixaCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.textCaixas = new System.Windows.Forms.TextBox();
            this.BtnFuncao = new MaterialSkin.Controls.MaterialButton();
            this.textDatabase = new System.Windows.Forms.TextBox();
            this.textPorta = new System.Windows.Forms.TextBox();
            this.textServidor = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.Contar = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Extrair.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Extrair);
            this.tabControl1.Controls.Add(this.Contar);
            this.tabControl1.Location = new System.Drawing.Point(-3, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 424);
            this.tabControl1.TabIndex = 15;
            // 
            // Extrair
            // 
            this.Extrair.Controls.Add(this.label6);
            this.Extrair.Controls.Add(this.label5);
            this.Extrair.Controls.Add(this.label4);
            this.Extrair.Controls.Add(this.label3);
            this.Extrair.Controls.Add(this.label2);
            this.Extrair.Controls.Add(this.label1);
            this.Extrair.Controls.Add(this.CaixaCheckbox1);
            this.Extrair.Controls.Add(this.textCaixas);
            this.Extrair.Controls.Add(this.BtnFuncao);
            this.Extrair.Controls.Add(this.textDatabase);
            this.Extrair.Controls.Add(this.textPorta);
            this.Extrair.Controls.Add(this.textServidor);
            this.Extrair.Controls.Add(this.textSenha);
            this.Extrair.Controls.Add(this.textLogin);
            this.Extrair.Location = new System.Drawing.Point(4, 24);
            this.Extrair.Name = "Extrair";
            this.Extrair.Padding = new System.Windows.Forms.Padding(3);
            this.Extrair.Size = new System.Drawing.Size(313, 396);
            this.Extrair.TabIndex = 0;
            this.Extrair.Text = "Extrair";
            this.Extrair.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(106, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Caixas especificos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(95, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nome do banco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(120, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Porta SQL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(131, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "IP SQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Login";
            // 
            // CaixaCheckbox1
            // 
            this.CaixaCheckbox1.Depth = 0;
            this.CaixaCheckbox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CaixaCheckbox1.Location = new System.Drawing.Point(92, 253);
            this.CaixaCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.CaixaCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CaixaCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.CaixaCheckbox1.Name = "CaixaCheckbox1";
            this.CaixaCheckbox1.ReadOnly = false;
            this.CaixaCheckbox1.Ripple = true;
            this.CaixaCheckbox1.Size = new System.Drawing.Size(31, 31);
            this.CaixaCheckbox1.TabIndex = 28;
            this.CaixaCheckbox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CaixaCheckbox1.UseVisualStyleBackColor = true;
            // 
            // textCaixas
            // 
            this.textCaixas.Enabled = false;
            this.textCaixas.Location = new System.Drawing.Point(30, 284);
            this.textCaixas.Name = "textCaixas";
            this.textCaixas.Size = new System.Drawing.Size(250, 23);
            this.textCaixas.TabIndex = 26;
            this.textCaixas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnFuncao
            // 
            this.BtnFuncao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnFuncao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnFuncao.Depth = 0;
            this.BtnFuncao.HighEmphasis = true;
            this.BtnFuncao.Icon = null;
            this.BtnFuncao.Location = new System.Drawing.Point(96, 337);
            this.BtnFuncao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnFuncao.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnFuncao.Name = "BtnFuncao";
            this.BtnFuncao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnFuncao.Size = new System.Drawing.Size(110, 36);
            this.BtnFuncao.TabIndex = 20;
            this.BtnFuncao.Text = "Gerar XMLS";
            this.BtnFuncao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnFuncao.UseAccentColor = false;
            this.BtnFuncao.UseVisualStyleBackColor = true;
            // 
            // textDatabase
            // 
            this.textDatabase.Location = new System.Drawing.Point(30, 227);
            this.textDatabase.Name = "textDatabase";
            this.textDatabase.Size = new System.Drawing.Size(250, 23);
            this.textDatabase.TabIndex = 19;
            this.textDatabase.Text = "Autocom3_Filial_Movimento_Mensal_2022_01";
            this.textDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPorta
            // 
            this.textPorta.Location = new System.Drawing.Point(30, 179);
            this.textPorta.Name = "textPorta";
            this.textPorta.Size = new System.Drawing.Size(250, 23);
            this.textPorta.TabIndex = 18;
            this.textPorta.Text = "1433";
            this.textPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textServidor
            // 
            this.textServidor.Location = new System.Drawing.Point(30, 131);
            this.textServidor.Name = "textServidor";
            this.textServidor.Size = new System.Drawing.Size(250, 23);
            this.textServidor.TabIndex = 17;
            this.textServidor.Text = "127.0.0.1";
            this.textServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(30, 83);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textSenha.Size = new System.Drawing.Size(250, 23);
            this.textSenha.TabIndex = 16;
            this.textSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(30, 35);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(250, 23);
            this.textLogin.TabIndex = 15;
            this.textLogin.Text = "sa";
            this.textLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Contar
            // 
            this.Contar.Location = new System.Drawing.Point(4, 24);
            this.Contar.Name = "Contar";
            this.Contar.Padding = new System.Windows.Forms.Padding(3);
            this.Contar.Size = new System.Drawing.Size(313, 396);
            this.Contar.TabIndex = 1;
            this.Contar.Text = "Contar";
            this.Contar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(313, 489);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Extrair XMLS AUTOCOM3 V7";
            this.tabControl1.ResumeLayout(false);
            this.Extrair.ResumeLayout(false);
            this.Extrair.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage Extrair;
        private MaterialSkin.Controls.MaterialCheckbox CaixaCheckbox1;
        private TextBox textCaixas;
        private MaterialSkin.Controls.MaterialButton BtnFuncao;
        private TextBox textDatabase;
        private TextBox textPorta;
        private TextBox textServidor;
        private TextBox textSenha;
        private TextBox textLogin;
        private TabPage Contar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}