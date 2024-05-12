using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.model
{
    // properties needed in the class:
    // AssociatedParts: BindingList<Part> 
    // int ProductID
    // string Name
    // decimal Price
    // int InStock
    // int Min
    // int Max 

    
    public class Product
    {
        // remember the empty class constructor, should be able to have products with no parts. 
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        //private properties...
        //private int productID;
        //private string productName;
        private decimal productPrice { get; set; }
        private int productInStock { get; set; }
        private int productMin { get; set; }
        private int productMax { get; set; }

        //public properties
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }





        // empty/default Constructor 
        public Product() { }

        // regular constructor, does not include parts.. 
        public Product(int productID, string productName, decimal productPrice, int productInStock, int productMin, int productMax)
        {
            ProductID = productID;
            Name = productName;
            Price = productPrice;
            InStock = productInStock;
            Min = productMin;
            Max = productMax;
            
        }


        // METHODS NEEDED: 
        // public void addAssociatedPart(Part)
        // public bool removeAssociatedPart(int PartID)
        // public Part lookUpAssociatedPart(int PartID)

        // addAssociatedPart method here... 
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        //lookupAssociatedPart here 
        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            InHousePart blankAssociatedPart = new InHousePart();
            return blankAssociatedPart;

        }

        // removeAssociatedPart here 
        public bool RemoveAssociatedPart(int partID)
        {
            Part associatedPartToDelete = LookupAssociatedPart(partID);
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(associatedPartToDelete);
                    return true;
                }
            }
            return false;
        }

        


    }



}
