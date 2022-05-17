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
