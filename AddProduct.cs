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

namespace IMS.model
{
    public partial class AddProduct : Form
    {
        BindingList<Part> productParts = new BindingList<Part>();




        public AddProduct()
        {
            InitializeComponent();





            //dataGridView sources 
            //Top table data grid = Parts form from the main window 

            // TESTING: BINDING SOURCE FOR DATA GRID FILTER 
            var candidatePartsTable = new BindingSource();
            candidatePartsTable.DataSource = Inventory.Parts;
            dgvAddProductView.DataSource = candidatePartsTable;

            //dgvAddProductView.DataSource = Inventory.Parts;
            dgvAddProductView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAddProductView.ReadOnly = true;
            dgvAddProductView.MultiSelect = false;
            dgvAddProductView.AllowUserToAddRows = false;


            //Bottom table = Associated Parts for that particular product 
            dgvAssociatedPartsView.DataSource = productParts;
            dgvAssociatedPartsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociatedPartsView.ReadOnly = true;
            dgvAssociatedPartsView.MultiSelect = false;
            dgvAssociatedPartsView.AllowUserToAddRows = false;


            

            //sets currency formatting for both tables
            dgvAssociatedPartsView.Columns["Price"].DefaultCellStyle.Format = "c";
            dgvAddProductView.Columns["Price"].DefaultCellStyle.Format = "c";

            // disables the delete button unless an associated part is selected 
            btnDelAssocPart.Enabled = false;

            addProdIDTextbox.Text = (Inventory.Products.Count + 1).ToString();
        }



        // BUTTONS


        // SAVE BUTTON
        private void btnSaveAddProduct_Click(object sender, EventArgs e)
        {
            // First checks for blank fields before running other code.
            if (string.IsNullOrEmpty(addProdNameTextbox.Text) | string.IsNullOrEmpty(addProdMaxTextbox.Text) |
                string.IsNullOrEmpty(addProdMinTextbox.Text) | string.IsNullOrEmpty(addProdPriceTextbox.Text) | string.IsNullOrEmpty(addProdInvTextbox.Text))
            {
                MessageBox.Show("Fields cannot be left blank. Please input the missing values first.");
            }

            else
            {
                
                try
                {
                    

                    if (int.Parse(addProdMaxTextbox.Text) < int.Parse(addProdMinTextbox.Text))
                    {
                        MessageBox.Show("Max cannot be less than Min.");
                    }
                    else if ((int.Parse(addProdInvTextbox.Text) > int.Parse(addProdMaxTextbox.Text)) | (int.Parse(addProdInvTextbox.Text) < int.Parse(addProdMinTextbox.Text)))
                    {
                        MessageBox.Show("Inventory is outside the expected range. Check the Max and Min values.");
                    }
                    else
                    {
                        // properties
                        int prodID = int.Parse(addProdIDTextbox.Text);
                        string name = addProdNameTextbox.Text;
                        int minStock = int.Parse(addProdMinTextbox.Text);
                        int maxStock = int.Parse(addProdMaxTextbox.Text);
                        decimal price = decimal.Parse(addProdPriceTextbox.Text) + 0.00m;
                        int numInStock = int.Parse(addProdInvTextbox.Text);


                        // adds the new product 
                        Product newProduct = new Product(prodID, name, price, numInStock, minStock, maxStock);
                        Inventory.Products.Add(newProduct);

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

        // ADD CANDIDATE PART BUTTON 
        private void btnAddCandidatePart_Click(object sender, EventArgs e)
        {
            Part partToAdd = dgvAddProductView.CurrentRow.DataBoundItem as Part;
            
            productParts.Add(partToAdd);
            //enables the delete button if something is added to the productParts list 
            if (btnDelAssocPart.Enabled == false)
            {
                btnDelAssocPart.Enabled = true;
            }
            
        }

        
    // DELETE ASSOCIATED PART BUTTON
    private void btnDelAssocPart_Click(object sender, EventArgs e)
        {
            
            Part partToRemove = dgvAssociatedPartsView.CurrentRow.DataBoundItem as Part;
            productParts.Remove(partToRemove);
            // disables the delete button again if there is nothing in the productParts list
            if (productParts.Count == 0)
            {
                btnDelAssocPart.Enabled = false; 
            }

        }

       

        // CANCEL BUTTON
        private void btnCancelAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProductSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addProdSearchTextbox.Text)) {
                for (int i = 0; i < Inventory.Parts.Count; i++)
                {
                    dgvAddProductView.Rows[i].Visible = true;
                }
            }
            else
            {
                // the actual search function 
                try
                {
                    int searchPartID = int.Parse(addProdSearchTextbox.Text);
                    Part searchedPart = Inventory.LookUpPart(int.Parse(addProdSearchTextbox.Text));

                    // The below commented code is the original search function for this form. 

                    //foreach (DataGridViewRow searchPartRow in dgvAddProductView.Rows)
                    //{
                    //    // highlights found item 
                    //    Part resultPart = searchPartRow.DataBoundItem as Part;
                    //    if (searchedPart.PartID == resultPart.PartID)
                    //    {

                    //        searchPartRow.Selected = true;
                    //        break;
                    //    }
                    //    else
                    //    {

                    //        searchPartRow.Selected = false;
                    //    }
                    //}

                    // TESTING: FILTER FUNCTION 
                    bool found = false; 
                    for (int i = 0; i < Inventory.Parts.Count; i++)
                    {
                        Part matchPart = dgvAddProductView.Rows[i].DataBoundItem as Part;
                        if (matchPart.PartID == searchPartID)
                        {
                            dgvAddProductView.Rows[i].Visible = true;
                            found = true;
                            
                        }
                        else
                        {   //error on making the "currency manager position row invisible"? 
                            // Since this is not my code, I will only use this filtering on this view.
                            // Main form's views search function works with a basic highlighting instead of filtering the data table.
                            // I have also included the original search code for this form above in a comment,
                            // so this can easily be switched out for the original version if using the below code is not permitted.
                            // cited (top answer): https://stackoverflow.com/questions/18942017/unable-to-set-row-visible-false-of-a-datagridview
                    
                            CurrencyManager currencyManager1 = BindingContext[dgvAddProductView.DataSource] as CurrencyManager;
                            currencyManager1.SuspendBinding();
                            dgvAddProductView.Rows[i].Visible = false;
                            currencyManager1.ResumeBinding();

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
}
