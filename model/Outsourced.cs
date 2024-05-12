﻿using IMS.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.model
{// should inherit from Part
    public class OutsourcedPart : Part
    {

        
        public string CompanyName { get; set; }
        public OutsourcedPart() { }
        public OutsourcedPart(int partID, string name, int instock, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            InStock = instock; 
            Price = price;
            Max = max;
            Min = min; 
        }

        //overloaded constructor 
        public OutsourcedPart(int partID, string name, int instock, decimal price, int max, int min, string companyName)
        {
            PartID = partID;
            Name = name;
            InStock = instock;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = companyName;
        }

      

    }
}
