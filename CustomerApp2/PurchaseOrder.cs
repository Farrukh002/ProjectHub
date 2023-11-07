using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CustomerApp2
{
    public class PurchaseOrder
    {
        [XmlIgnore]
        public int id;
        [XmlIgnore]
        public int customerId;
        public Address shipTo;
        public string orderDate;
        // The XmlArray attribute changes the XML element name 
        // from the default of "orderedItems" to "items". 
        [XmlArray("items")]
        public OrderedItem[] orderedItems;
        public decimal subTotal, shipCost, totalCost;
    }
}
