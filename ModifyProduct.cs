using IMS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> productParts = new BindingList<Part>();

        //method for data validation 

       





        public ModifyProduct(Product prodToModify)
        {
            InitializeComponent();

            //change this to be product.ProductID.ToString(); etc. Opening the modify form should take a Product as an argument. 
            modProdIDTextbox.Text = prodToModify.ProductID.ToString();
            modProdNameTextbox.Text = prodToModify.Name.ToString();
            modProdInvTextbox.Text = prodToModify.InStock.ToString();
            modProdPriceTextbox.Text = prodToModify.Price.ToString();
            modProdMaxTextbox.Text = prodToModify.Max.ToString();
            modProdMinTextbox.Text = prodToModify.Min.ToString();


            // Data Grid Views 

            //dataGridView sources 
            //Top table data grid = Parts form from the main window 
            dgvModAddPartsProd.DataSource = Inventory.Parts;
            dgvModAddPartsProd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModAddPartsProd.ReadOnly = true;
            dgvModAddPartsProd.MultiSelect = false;
            dgvModAddPartsProd.AllowUserToAddRows = false;


            //Bottom table = Associated Parts for that particular product 
            foreach (Part part in prodToModify.AssociatedParts)
            {
                productParts.Add(part);
            }

            dgvModAssociatedParts.DataSource = productParts;
            dgvModAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModAssociatedParts.ReadOnly = true;
            dgvModAssociatedParts.MultiSelect = false;
            dgvModAssociatedParts.AllowUserToAddRows = false;


            //sets currency formatting for both tables
            dgvModAddPartsProd.Columns["Price"].DefaultCellStyle.Format = "c";
            dgvModAssociatedParts.Columns["Price"].DefaultCellStyle.Format = "c";

            // disables the delete button unless an associated part is selected 
            if (productParts.Count == 0)
            {
                btnDelModProd.Enabled = false;
            }
            
            
        }

        private void btnModProductAdd_Click(object sender, EventArgs e)
        {
            Part partToAdd = dgvModAddPartsProd.CurrentRow.DataBoundItem as Part;
            // how to add a part to a product that doesn't exist yet? 
            productParts.Add(partToAdd);
            //enables the delete button if something is added to the productParts list 
            if (btnDelModProd.Enabled == false)
            {
                btnDelModProd.Enabled = true;
            }
        }



        private void btnSaveModProd_Click(object sender, EventArgs e)
        {
            // properties
           

            if (string.IsNullOrEmpty(modProdNameTextbox.Text) | string.IsNullOrEmpty(modProdMaxTextbox.Text) |
                string.IsNullOrEmpty(modProdMinTextbox.Text) | string.IsNullOrEmpty(modProdPriceTextbox.Text) | string.IsNullOrEmpty(modProdInvTextbox.Text))
            {
                MessageBox.Show("Fields cannot be left blank. Please input the missing values first.");
            }
            else
            {
                try
                {

                    if (int.Parse(modProdMaxTextbox.Text) < int.Parse(modProdMinTextbox.Text))
                    {
                        MessageBox.Show("Max cannot be less than Min.");
                    }
                    else if ((int.Parse(modProdInvTextbox.Text) > int.Parse(modProdMaxTextbox.Text)) | (int.Parse(modProdInvTextbox.Text) < int.Parse(modProdMinTextbox.Text)))
                    {
                        MessageBox.Show("Inventory is outside the expected range. Check the Max and Min values.");
                    }
                    else
                    {
                        string name = modProdNameTextbox.Text;
                        int minStock = int.Parse(modProdMinTextbox.Text);
                        int maxStock = int.Parse(modProdMaxTextbox.Text);
                        decimal price = decimal.Parse(modProdPriceTextbox.Text) + 0.00m;
                        int numInStock = int.Parse(modProdInvTextbox.Text);
                        int prodID = int.Parse(modProdIDTextbox.Text);
                        
                        // Adds product 
                        Product newProduct = new Product(prodID, name, price, numInStock, minStock, maxStock);
                        Inventory.UpdateProduct(prodID, newProduct);

                        foreach (Part part in productParts)
                        {
                            newProduct.addAssociatedPart(part);
                        }
                        
                        this.Close();
                    }

                    
                }
                catch
                {
                    MessageBox.Show("The values for Min, Max, Price, Machine ID, and Inventory must be numeric.");
                }
               
            }

        }

        private void btnDelModProd_Click(object sender, EventArgs e)
        {
            Part partToRemove = dgvModAssociatedParts.CurrentRow.DataBoundItem as Part;
            
            // disables the delete button again if there is nothing in the productParts list
            if (productParts.Count == 0)
            {
                btnDelModProd.Enabled = false;
            }
            else
            {
                DialogResult DelProductModScreen = MessageBox.Show("Are you sure you want to delete this part from the product?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (DelProductModScreen == DialogResult.Yes)
                {
                    productParts.Remove(partToRemove);
                }
                
            }
        }

        private void btnModProdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModProdSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int searchPartID = int.Parse(modProdSearchTextbox.Text);
                Part searchedPart = Inventory.LookUpPart(int.Parse(modProdSearchTextbox.Text));
                bool found = true; 
                foreach (DataGridViewRow searchPartRow in dgvModAddPartsProd.Rows)
                {
                    // highlights found item 
                    Part resultPart = searchPartRow.DataBoundItem as Part;
                    if (searchedPart.PartID == resultPart.PartID)
                    {
                        searchPartRow.Selected = true;
                        found = true;
                        break;
                    }
                    else
                    {
                        searchPartRow.Selected = false;
                        found = false; 
                    }
                }
                if (!found)
                {
                    MessageBox.Show($"Part ID {searchPartID} not found.");
                }
            }
            catch
            {
                MessageBox.Show("Please search by ID.");
            }
        }
    }
}
