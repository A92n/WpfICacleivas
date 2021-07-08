using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfICacleivas.Interfaces;
using WpfICacleivas.Serialization;

namespace WpfICacleivas.Models
{
    public class  Pedido:XmlFile<Pedido>
    {
        public int pedido { get; set; }
        public string Ncliente { get; set; }
        public List<string> prod { get; set; }

        public Pedido FromXml(string Path)
        {
            return XmlSerialization.ReadFromXmlFile<Pedido>(Path);
        }

        public void ToXml(string Path)
        {
            XmlSerialization.WriteToXmlFile(Path, this, false);
        }
    }
}
