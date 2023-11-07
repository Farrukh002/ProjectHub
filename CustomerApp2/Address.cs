using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CustomerApp2
{
    public class Address
    {
        [XmlIgnore]
        public int id;
        [XmlAttribute]
        public string name;
        [XmlElement(IsNullable = false)]
        public string street, city, state, zip;
    }

}
