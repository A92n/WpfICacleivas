using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfICacleivas.Interfaces
{
    public interface XmlFile<T>
    {
        void ToXml(string Path);
        T FromXml(string Path);


    }
}
