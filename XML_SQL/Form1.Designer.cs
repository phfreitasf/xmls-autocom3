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
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textServidor = new System.Windows.Forms.TextBox();
            this.textPorta = new System.Windows.Forms.TextBox();
            this.textDatabase = new System.Windows.Forms.TextBox();
            this.BtnFuncao = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.textCaixas = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.CaixaCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(32, 111);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(250, 23);
            this.textLogin.TabIndex = 1;
            this.textLogin.Text = "sa";
            this.textLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(32, 159);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textSenha.Size = new System.Drawing.Size(250, 23);
            this.textSenha.TabIndex = 2;
            this.textSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textServidor
            // 
            this.textServidor.Location = new System.Drawing.Point(32, 207);
            this.textServidor.Name = "textServidor";
            this.textServidor.Size = new System.Drawing.Size(250, 23);
            this.textServidor.TabIndex = 3;
            this.textServidor.Text = "127.0.0.1";
            this.textServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPorta
            // 
            this.textPorta.Location = new System.Drawing.Point(32, 255);
            this.textPorta.Name = "textPorta";
            this.textPorta.Size = new System.Drawing.Size(250, 23);
            this.textPorta.TabIndex = 4;
            this.textPorta.Text = "1433";
            this.textPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDatabase
            // 
            this.textDatabase.Location = new System.Drawing.Point(32, 303);
            this.textDatabase.Name = "textDatabase";
            this.textDatabase.Size = new System.Drawing.Size(250, 23);
            this.textDatabase.TabIndex = 5;
            this.textDatabase.Text = "Autocom3_Filial_Movimento_Mensal_2022_01";
            this.textDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnFuncao
            // 
            this.BtnFuncao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnFuncao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnFuncao.Depth = 0;
            this.BtnFuncao.HighEmphasis = true;
            this.BtnFuncao.Icon = null;
            this.BtnFuncao.Location = new System.Drawing.Point(98, 413);
            this.BtnFuncao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnFuncao.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnFuncao.Name = "BtnFuncao";
            this.BtnFuncao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnFuncao.Size = new System.Drawing.Size(110, 36);
            this.BtnFuncao.TabIndex = 6;
            this.BtnFuncao.Text = "Gerar XMLS";
            this.BtnFuncao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnFuncao.UseAccentColor = false;
            this.BtnFuncao.UseVisualStyleBackColor = true;
            this.BtnFuncao.Click += new System.EventHandler(this.Funcao_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.Location = new System.Drawing.Point(-2, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel1.Size = new System.Drawing.Size(319, 17);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Login";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel2.Location = new System.Drawing.Point(-2, 141);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel2.Size = new System.Drawing.Size(321, 17);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Senha";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel3.Location = new System.Drawing.Point(-2, 187);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel3.Size = new System.Drawing.Size(321, 17);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Ip";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel4.Location = new System.Drawing.Point(-2, 237);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel4.Size = new System.Drawing.Size(319, 17);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Porta";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel5.Location = new System.Drawing.Point(-2, 285);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel5.Size = new System.Drawing.Size(321, 17);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Nome Banco";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textCaixas
            // 
            this.textCaixas.Enabled = false;
            this.textCaixas.Location = new System.Drawing.Point(32, 360);
            this.textCaixas.Name = "textCaixas";
            this.textCaixas.Size = new System.Drawing.Size(250, 23);
            this.textCaixas.TabIndex = 12;
            this.textCaixas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel6.Location = new System.Drawing.Point(-2, 338);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel6.Size = new System.Drawing.Size(342, 17);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Caixas especificos";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CaixaCheckbox1
            // 
            this.CaixaCheckbox1.Depth = 0;
            this.CaixaCheckbox1.Location = new System.Drawing.Point(77, 328);
            this.CaixaCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.CaixaCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CaixaCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.CaixaCheckbox1.Name = "CaixaCheckbox1";
            this.CaixaCheckbox1.ReadOnly = false;
            this.CaixaCheckbox1.Ripple = true;
            this.CaixaCheckbox1.Size = new System.Drawing.Size(31, 31);
            this.CaixaCheckbox1.TabIndex = 14;
            this.CaixaCheckbox1.UseVisualStyleBackColor = true;
            this.CaixaCheckbox1.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(313, 489);
            this.Controls.Add(this.CaixaCheckbox1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.textCaixas);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BtnFuncao);
            this.Controls.Add(this.textDatabase);
            this.Controls.Add(this.textPorta);
            this.Controls.Add(this.textServidor);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textLogin);
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Extrair XMLS AUTOCOM3 V7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textLogin;
        private TextBox textSenha;
        private TextBox textServidor;
        private TextBox textPorta;
        private TextBox textDatabase;
        private MaterialSkin.Controls.MaterialButton BtnFuncao;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private TextBox textCaixas;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCheckbox CaixaCheckbox1;
    }
}