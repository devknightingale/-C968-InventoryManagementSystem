using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.model
{//should inherit from Part 
    public class InHousePart : Part
    {
        
        public int MachineID { get; set; }

        public InHousePart() { }
        public InHousePart(int partID, string name, int instock, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            InStock = instock;
            Price = price;
            Max = max;
            Min = min;
        }
        public InHousePart(int partID, string name, int instock, decimal price, int max, int min, int machID)
        {
            PartID = partID;
            Name = name;
            InStock = instock;
            Price = price;
            Max = max;
            Min = min;
            MachineID = machID;
        }
    }

}
