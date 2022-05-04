using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
using XML_SQL.Entities;

namespace XML_SQL.Entities
{
    static public class ConexaoSQL
    {
        public static string? Server { get; set; }
        public static string? Port { get; set; }
        public static string? Username { get; set; }
        public static string? Password { get; set; }
        public static string? Database { get; set; }

        //public string connectionString = "Server="+Server+",myPortNumber;Database=myDataBase;User Id=myUsername;Password=myPassword;'



        static public void ConnectSQL(string server,string port,string database,string username, string password, bool caixas,string txtcaixas)
        {
            //teste de conexao com o sql so pra ver msm
            string connectionString = "Data Source="+server+","+port+";Initial Catalog="+database+";User Id="+username+";Password="+password+";";

            try //vai tentar conexao com o banco SQL, se der erro vai exibir mensagem do catch
            {
               SqlConnection  cnn = new SqlConnection(connectionString); 
                cnn.Open();
                //MessageBox.Show("CONEXAO OK");
                Gravar_Arquivos(ExtrairXML(cnn, caixas, txtcaixas)); //aqui ja roda a funcao de extrair os xmls
                cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de conexão, dados inválidos ou tabela não existe");
                MessageBox.Show(e.Message);
                //throw; comentado so pra nao mostrar a janela feia
            }
        }
    
        static public List<Arquivo_XML> ExtrairXML(SqlConnection sqlConnection, bool caixas, string txtcaixas)
        {
            List<Arquivo_XML> xmls = new List<Arquivo_XML>(); //cria uma lista do tipo Entities.Arquivo_XML
            
            string consulta_xml = "select arquivo,conteudo from dbo.repositorio_de_xml where 1=1"; //string de consulta sql
            if (caixas)
            {
                consulta_xml = consulta_xml + " and caixa in ('"+txtcaixas+"')";
            }
            SqlCommand sqlCommand = new SqlCommand(consulta_xml,sqlConnection); 
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read()) //enquanto tiver resultado no select, vai jogar dentro da lista
            {
                Arquivo_XML arquivo = new Arquivo_XML(); //cria novo objeto
                arquivo.Arquivo = (string)reader["arquivo"]; //nome do arquivo que vai criar
                arquivo.Conteudo = (string)reader["conteudo"]; //informacoes do xml
                xmls.Add(arquivo);
            }

            return xmls;
        }

        static public void Gravar_Arquivos(List<Arquivo_XML> arquivo_XMLs)
        {
            string pasta = "";

            using (var fbd = new FolderBrowserDialog()) //abre janela pra escolher a pasta que vai salvar
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    pasta = fbd.SelectedPath;

                    //System.Windows.Forms.MessageBox.Show(pasta);
                }
            }
            foreach (var item in arquivo_XMLs)
            {
                string chave = item.Arquivo.ToString();
                string conteudo = item.Conteudo.ToString();
                XmlDocument nota = new XmlDocument(); //cria novo objeto xml
                nota.LoadXml(conteudo); //escreve informacoes dentro do xml usando a variavel conteudo
                nota.Save(pasta.ToString() + "\\" + chave + ""); //salva o arquivo no computador
                //MessageBox.Show("CHEGOU AQUI");
            }
            MessageBox.Show("Finalizado");
        }
    }
}
