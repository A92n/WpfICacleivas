using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfICacleivas.Interfaces;

namespace WpfICacleivas.Models
{
    public class Usuario:XmlFile<Usuario>
    {
        public string Names { get; set; }
        public string Correo { get; set; }


    }
}
