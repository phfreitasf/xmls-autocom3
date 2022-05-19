using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XML_SQL.Entities
{
    public class Ler_xml
    {
        public String Numero { get; set; }



        static public void AddToGrid(DataGridView grid)
        {
            string[] files;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    files = Directory.GetFiles(fbd.SelectedPath);


                    foreach (var item in files)
                    {
                        string paths = Path.GetFileName(item);
                        if (paths.Length >= 43 && (paths.Contains("-PROCNFE.xml") || paths.Contains("-procnfe.xml")))
                        {

                            string modelo = paths.Substring(20, 2); //Numero do modelo
                            string serie = paths.Substring(22, 3);  //Numero de serie
                            string nota = paths.Substring(37, 6);   //Numero da nota
                            if (modelo == "65") modelo = "NFCE";
                            if (modelo == "55") modelo = "NFE";

                            DataGridViewRow row = (DataGridViewRow)grid.Rows[0].Clone();
                            row.Cells[0].Value =  modelo;
                            row.Cells[1].Value = serie;
                            row.Cells[2].Value = nota;
                            grid.Rows.Add(row);

                        }
                    }
                }
            }
        }



        static public List<Ler_xml> ContarNumeros(string[] xmls)
        {
            List<Ler_xml> list = new List<Ler_xml>();

            foreach (var xml in xmls)
            {
                Ler_xml arquivo = new Ler_xml();
                //xml.ToString().Split()
                arquivo.Numero = xml.ToString();

                list.Add(arquivo);
            }

            return list;
        }

    }
}
