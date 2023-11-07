using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp2
{
    public class OrderedItem
    {
        public string itemName;
        public int quantity;
        public decimal unitPrice, lineTotal;
        public void calculateTotalPrice()
        {
            lineTotal = unitPrice * quantity;
        }
    }

}
