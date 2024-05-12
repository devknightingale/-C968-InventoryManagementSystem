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
    
    // Attempt at method for text validation, one for numeric and one for decimal 

    




    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            /********************************/
            /*****  FOR PARTS DATA GRID *****/
            /********************************/

            // Sets data source to the data grid

            dgvParts.DataSource = Inventory.Parts;

            // selects full row - this can also be set in the properties on the form designer 
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // make the grid read-only - can also be set in properties 
            dgvParts.ReadOnly = true;

            // disallows multi-select
            dgvParts.MultiSelect = false;

            
            // remove bottom line, keeps users from adding rows that way
            dgvParts.AllowUserToAddRows = false;
            dgvParts.Columns["Price"].DefaultCellStyle.Format = "c";


            /********************************/
            /**** FOR PRODUCTS DATA GRID ****/
            /********************************/
            // Products data grid for updating after UpdateProduct() 
            var productsTableMain = new BindingSource();
            productsTableMain.DataSource = Inventory.Products;
            dgvProducts.DataSource = productsTableMain;

            //dgvProducts.DataSource = Inventory.Products;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.Columns["Price"].DefaultCellStyle.Format = "c";
            

            
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // clears selection once binding is complete
            dgvParts.ClearSelection(); 
            dgvProducts.ClearSelection();
        }

        

       
        // ADD BUTTONS
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            
            var addPartForm = new AddPartForm();
            addPartForm.ShowDialog(); 
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProduct();
            addProductForm.ShowDialog();
        }



        // MODIFY BUTTONS
        private void btnModifyPart_Click(object sender, EventArgs e)
        {


            if (!dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a Part to modify.");
            }
            else
            {
                // do an if/else for inhouse vs outsourced part type to grab. otherwise will throw exception for grabbing wrong type
                // how to determine what type of part is being grabbed? 

                if (dgvParts.CurrentRow.DataBoundItem.GetType() == typeof(InHousePart))
                {
                    InHousePart inHousePart = dgvParts.CurrentRow.DataBoundItem as InHousePart;
                    new ModifyPart(inHousePart).ShowDialog();
                }
                else
                {
                    OutsourcedPart outsourcedPart = dgvParts.CurrentRow.DataBoundItem as OutsourcedPart;
                    new ModifyPart(outsourcedPart).ShowDialog();
                }

            }
        }



        // DELETE BUTTONS
        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (!dgvParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }
            else
            {
                Part selectedPart = dgvParts.CurrentRow.DataBoundItem as Part;
                DialogResult = MessageBox.Show("Are you sure you want to delete this item? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo);
                // debugstuff 
                
                if (DialogResult == DialogResult.Yes)
                {
                    // implement check to make sure it is not associated with a product 
                    Inventory.DeletePart(selectedPart.PartID);
                    
                }

            }
        }


        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = dgvProducts.CurrentRow.DataBoundItem as Product;
            DialogResult DelProduct = MessageBox.Show("Are you sure you want to delete this item? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (DelProduct == DialogResult.Yes) 
            {
                Inventory.RemoveProduct(selectedProduct.ProductID);
            }
        }




        // MAIN FORM EXIT BUTTON
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
        

                if (!dgvProducts.CurrentRow.Selected)
                {
                    MessageBox.Show("Please select a Product to modify.");
                }
                else
                {
                    // do an if/else for inhouse vs outsourced part type to grab. otherwise will throw exception for grabbing wrong type
                    Product prodToModify = dgvProducts.CurrentRow.DataBoundItem as Product;

                    new ModifyProduct(prodToModify).ShowDialog();

                }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            // searches by ID value, highlights found item 
            try
            {
                int searchID = int.Parse(searchboxProduct.Text);
                Product searchedProduct = Inventory.LookupProduct(int.Parse(searchboxProduct.Text));
                bool found = true;
                foreach (DataGridViewRow searchRow in dgvProducts.Rows)
                {
                    // search each rows for a match? 
                    Product resultProduct = searchRow.DataBoundItem as Product;
                    if (searchedProduct.ProductID == resultProduct.ProductID)
                    {
                        searchRow.Selected = true;
                        found = true;
                        break;
                    }
                    else
                    {
                        searchRow.Selected = false;
                        found = false; 

                    }

                }
                if (!found)
                {
                    MessageBox.Show($"Product ID {searchID} could not be found.");
                }
            }
            
            catch
            {
                MessageBox.Show("Please search by ID.");
            }

            
        }

        private void btnSearchPart_Click(object sender, EventArgs e)
        {
            // maybe use try/catch on search? search fails if it is not an int value 

            try
            {
                int searchPartID = int.Parse(searchboxPart.Text);
                Part searchedPart = Inventory.LookUpPart(int.Parse(searchboxPart.Text));
                bool found = true; 
                foreach (DataGridViewRow searchPartRow in dgvParts.Rows)
                {
                    // highlights found item 
                    Part resultPart = searchPartRow.DataBoundItem as Part;
                    if (searchedPart.PartID == resultPart.PartID)
                    {
                        //is there any way to change this to a filtering function where it only shows the result?
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

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            // This is the easiest way I found to make the products table refresh with new data when the modify product form is closed
            dgvProducts.Update();
            dgvProducts.Refresh();


        }
    }
}
