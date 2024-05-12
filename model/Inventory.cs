using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.model
{

    // NOTES: 

     class Inventory
    {
        // create binding list for the Products and Parts 
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        


        // PART METHODS

        public static void AddPart(Part part)
        {
            Parts.Add(part);

        }

        public static void UpdatePart(int partID, Part part)
        {
            DeletePart(partID);
            AddPart(part);

        }

        public static Part LookUpPart(int partID)
        {
            foreach (Part part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            // need to set up a part with nothing to return from this?
            Part blankPart = new InHousePart();
            return blankPart;
        }
        public static bool DeletePart(int partID)
        {
            
            Part partToBeDeleted = Inventory.LookUpPart(partID);


            bool found = false; 

            // check to make sure not associated with a product 
            foreach (Product product in Products)
            {
                
                foreach (Part part in product.AssociatedParts)
                {
                    if (product.AssociatedParts.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        
                        if (part.PartID == partToBeDeleted.PartID)
                        {
                            MessageBox.Show($"Part {partToBeDeleted.PartID}: {partToBeDeleted.Name} is currently associated with Product {product.ProductID}: {product.Name}! Please dissassociate the part and try again.");
                            found = true;
                            return false; 
                            
                        }
                    }
                    
                }
                
                
            }
            if (found == false)
            {
                Inventory.Parts.Remove(partToBeDeleted);
                return true;
            }
            else
            {
                return false; 
            }
            
        }

        // PRODUCT METHODS 


        public static void AddProduct(Product product)
        {
            Products.Add(product);

        }
        public static Product LookupProduct(int productID)
        {
            foreach (Product product in Inventory.Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            Product blankProduct = new Product();
            return blankProduct;

        }

        public static void UpdateProduct(int productID, Product modProduct)
        {

            foreach (Product originalProduct in Products)
            {
                if (originalProduct.ProductID == productID)
                {

                    originalProduct.Name = modProduct.Name;
                    originalProduct.InStock = modProduct.InStock;
                    originalProduct.Price = modProduct.Price;
                    originalProduct.Max = modProduct.Max;
                    originalProduct.Min = modProduct.Min;
                    originalProduct.AssociatedParts = modProduct.AssociatedParts;
                    
                }

            }

        }


        public static bool RemoveProduct(int productID)
        {
            Product productToBeDeleted = Inventory.LookupProduct(productID);
            if (productToBeDeleted.AssociatedParts.Count != 0)
            {
                MessageBox.Show("Product still has parts assigned to it. Please remove the associated parts and try again.");
                return false;
            }
            else
            {
                if (Inventory.Products.Remove(productToBeDeleted))
                {
                    return true;
                }
            }
            return false;
        }

       



        /* 
        -----------------------------------
        ||||||||||   TEST DATA   ||||||||||
        -----------------------------------
         */
        static Inventory()
        {
            // Test data for Parts side
            Part testInHousePart = new InHousePart(1,"Coffee", 10, 8.99m, 10, 1, 1001); 
            Parts.Add(testInHousePart);

            Part testOutsourcedPart = new OutsourcedPart(2, "Creamer", 10, 7.99m, 10, 1, "Nestle");
            Parts.Add(testOutsourcedPart);

            Part testInHousePart2 = new InHousePart(3, "Sugar", 10, 0.99m, 10, 1, 1001);
            Parts.Add(testInHousePart2);

            Part testOutsourcedPart2 = new OutsourcedPart(4, "Cups", 10, 3.99m, 10, 1, "Xpedx");
            Parts.Add(testOutsourcedPart2);

            // Test data for Products side 
            Product newTestProduct = new Product(1, "Starbucks", 5.99m, 10, 1, 100); 
            Products.Add(newTestProduct);
            
            Product newTestProduct2 = new Product(2, "Dunkin", 2.99m, 10, 1, 100);
            Products.Add(newTestProduct2);

            Product newTestProduct3 = new Product(3, "Tim Horton's", 3.99m, 20, 1, 100);
            Products.Add(newTestProduct3);
            newTestProduct3.addAssociatedPart(testOutsourcedPart); // Adds creamer to TIm's 
            newTestProduct3.addAssociatedPart(testInHousePart); //adds Coffee to Tim's

        }

    }








}
