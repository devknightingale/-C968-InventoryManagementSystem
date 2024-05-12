using IMS.model;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IMS
{
    public partial class AddPartForm : Form
    {
   


        // Changes MachID label based on which radio button is selected. 

        private void radioOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblAddMachineID.Text = "Company Name";
        }

        private void radioInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblAddMachineID.Text = "Machine ID";
        }

        public AddPartForm()
        {
            InitializeComponent();

            // FIX ME: Use this space to validate data and enable save button when appropriate?
            // Disabled during validation checking. 
            btnSaveAddPart.Enabled = true;

            // increments PartID number 
            partIDTextBox.Text = (Inventory.Parts.Count + 1).ToString(); 
        }

        private void btnCancelAddPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnSaveAddPart_Click(object sender, EventArgs e)
        {

            int partID = int.Parse(partIDTextBox.Text);
            string name = nameTextBox.Text;

            if (string.IsNullOrEmpty(machIDTextBox.Text) | string.IsNullOrEmpty(nameTextBox.Text) | string.IsNullOrEmpty(maxTextBox.Text) |
                string.IsNullOrEmpty(minTextBox.Text) | string.IsNullOrEmpty(priceTextBox.Text) | string.IsNullOrEmpty(inStockTextBox.Text))
            {
                MessageBox.Show("Fields cannot be left blank. Please input the missing values first.");
            }
            else
            {
                

                try
                {
                    int minStock = int.Parse(minTextBox.Text);
                    int maxStock = int.Parse(maxTextBox.Text);
                    decimal price = decimal.Parse(priceTextBox.Text) + 0.00m;
                    int numInStock = int.Parse(inStockTextBox.Text);
                    

                    if (int.Parse(maxTextBox.Text) < int.Parse(minTextBox.Text))
                    {
                        MessageBox.Show("Max cannot be less than Min.");
                    }
                    else if ((int.Parse(inStockTextBox.Text) > int.Parse(maxTextBox.Text)) | (int.Parse(inStockTextBox.Text) < int.Parse(minTextBox.Text)))
                    {
                        MessageBox.Show("Inventory is outside the expected range. Check the Max and Min values.");
                    }
                    else
                    {
                        //Check which radio button is selected, then uses the appropriate method to add the part based on subclass. 
                        if (radioInHouse.Checked)
                        {
                            try
                            {
                                int machineID = int.Parse(machIDTextBox.Text);
                                int currentCount = Inventory.Parts.Count;
                                InHousePart inHousePart = new InHousePart(partID, name, numInStock, price, maxStock, minStock, machineID);
                                Inventory.AddPart(inHousePart);
                                this.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Machine ID must be an integer.");
                            }
                            
                            

                        }

                        else
                        {

                            string compName = machIDTextBox.Text;
                            int currentCount = Inventory.Parts.Count;
                            OutsourcedPart outsourcedPart = new OutsourcedPart(partID, name, numInStock, price, maxStock, minStock, compName);
                            Inventory.AddPart(outsourcedPart);
                            this.Close();
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("The values for Min, Max, Price, Machine ID, and Inventory must be integers.");
                }
                
            }
            
        }

       
        

   


    }
}
