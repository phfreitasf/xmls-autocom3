using MaterialSkin.Controls;
using XML_SQL.Entities;

namespace XML_SQL
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Funcao_Click(object sender, EventArgs e)
        {
            // Ler os campos de texto e definir variaveis
            ConexaoSQL.Server = textServidor.Text.ToString();
            ConexaoSQL.Port = textPorta.Text.ToString();
            ConexaoSQL.Database = textDatabase.Text.ToString();
            ConexaoSQL.Username = textLogin.Text.ToString();  
            ConexaoSQL.Password = textSenha.Text.ToString();


            


            ConexaoSQL.ConnectSQL(ConexaoSQL.Server,
                                  ConexaoSQL.Port,
                                  ConexaoSQL.Database,
                                  ConexaoSQL.Username,
                                  ConexaoSQL.Password,
                                  CaixaCheckbox1.Checked,
                                  textCaixas.Text.ToString());
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CaixaCheckbox1.Checked) textCaixas.Enabled = true;
            else textCaixas.Enabled = false;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string[] files;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    files = Directory.GetFiles(fbd.SelectedPath);
                    MessageBox.Show(files[);
                    listXmls.Items.Add(Ler_xml.ContarNumeros(files).ToString());
                }
            }

            
        }
    }
}