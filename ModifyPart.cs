using IMS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IMS
{

    public partial class ModifyPart : Form
    {

        public ModifyPart(InHousePart inPart)
        {
            InitializeComponent();
            modPartIDTextBox.Text = inPart.PartID.ToString();
            nameModTextBox.Text = inPart.Name.ToString();
            inStockModTextBox.Text = inPart.InStock.ToString();
            priceModTextBox.Text = inPart.Price.ToString();
            maxModTextBox.Text = inPart.Max.ToString();
            minModTextBox.Text = inPart.Min.ToString();
            machIDModTextBox.Text = inPart.MachineID.ToString();
        }

        public ModifyPart(OutsourcedPart outsourcedPart)
        {
            InitializeComponent();
            modPartIDTextBox.Text = outsourcedPart.PartID.ToString();
            nameModTextBox.Text = outsourcedPart.Name.ToString();
            inStockModTextBox.Text = outsourcedPart.InStock.ToString();
            priceModTextBox.Text = outsourcedPart.Price.ToString();
            maxModTextBox.Text = outsourcedPart.Max.ToString();
            minModTextBox.Text = outsourcedPart.Min.ToString();
            machIDModTextBox.Text = outsourcedPart.CompanyName.ToString();

            
            radioModInHouse.Checked = false;
            radioModOutsourced.Checked = true;
            lblModMachID.Text = "Company Name";

            
            
        }


        private void btnSaveModPart_Click(object sender, EventArgs e)
        {

            //General properties
            int modID = int.Parse(modPartIDTextBox.Text);
            string modName = nameModTextBox.Text;
            string modCompName;

            // implement try/catch here... 
            if (string.IsNullOrEmpty(machIDModTextBox.Text) | string.IsNullOrEmpty(nameModTextBox.Text) | string.IsNullOrEmpty(maxModTextBox.Text) |
                string.IsNullOrEmpty(minModTextBox.Text) | string.IsNullOrEmpty(priceModTextBox.Text) | string.IsNullOrEmpty(inStockModTextBox.Text))
            {
                MessageBox.Show("Fields cannot be left blank. Please input the missing values first.");
            }
            else
            {
                try
                {
                    //FIX ME: 
                    int modInStock = int.Parse(inStockModTextBox.Text);
                    decimal modPrice = decimal.Parse(priceModTextBox.Text) + 0.00m;
                    int modMax = int.Parse(maxModTextBox.Text);
                    int modMin = int.Parse(minModTextBox.Text);



                    if (int.Parse(maxModTextBox.Text) < int.Parse(minModTextBox.Text))
                    {
                        MessageBox.Show("Max cannot be less than Min.");
                    }
                    else if ((int.Parse(inStockModTextBox.Text) > int.Parse(maxModTextBox.Text)) | (int.Parse(inStockModTextBox.Text) < int.Parse(minModTextBox.Text)))
                    {
                        MessageBox.Show("Inventory is outside the expected range. Check the Max and Min values.");
                    }
                    else
                    {
                        // Put the else
                        if (radioModInHouse.Checked)
                        {
                            // Inhouse Part modify stuff here
                            try
                            {
                                int modMachID = int.Parse(machIDModTextBox.Text);

                                Part updatedPart = new InHousePart(modID, modName, modInStock, modPrice, modMax, modMin, modMachID);
                                Inventory.UpdatePart(modID, updatedPart);

                                this.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Machine ID must be an integer.");
                            }

                        }
                        else
                        {
                            //outsourced part modify stuff here 
                            modCompName = machIDModTextBox.Text;

                            // Create the UpdatedPart as a new Part, then call the UpdatePart() method. 
                            Part updatedPart = new OutsourcedPart(modID, modName, modInStock, modPrice, modMax, modMin, modCompName);
                            Inventory.UpdatePart(modID, updatedPart);


                            this.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Inventory, Max, Min, and Price must be numeric.");
                }
            }
        }


            // CANCEL BUTTON
            private void btnCancelModPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Changes the Machine ID/Company name label based on which radio button is selected 
        private void radioModOutsourced_Click(object sender, EventArgs e)
        {
            lblModMachID.Text = "Company Name";
        }

        private void radioModInHouse_Click(object sender, EventArgs e)
        {
            lblModMachID.Text = "Machine ID";
        }

       
    }
}
