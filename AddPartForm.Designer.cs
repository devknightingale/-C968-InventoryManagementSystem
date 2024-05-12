namespace IMS
{
    partial class AddPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioInHouse = new System.Windows.Forms.RadioButton();
            this.radioOutsourced = new System.Windows.Forms.RadioButton();
            this.lblAddID = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddInventory = new System.Windows.Forms.Label();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.lblAddMax = new System.Windows.Forms.Label();
            this.lblAddMin = new System.Windows.Forms.Label();
            this.lblAddMachineID = new System.Windows.Forms.Label();
            this.inStockTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.machIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.btnSaveAddPart = new System.Windows.Forms.Button();
            this.btnCancelAddPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part ";
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Location = new System.Drawing.Point(155, 27);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(68, 17);
            this.radioInHouse.TabIndex = 1;
            this.radioInHouse.TabStop = true;
            this.radioInHouse.Text = "In-House";
            this.radioInHouse.UseVisualStyleBackColor = true;
            this.radioInHouse.CheckedChanged += new System.EventHandler(this.radioInHouse_CheckedChanged);
            // 
            // radioOutsourced
            // 
            this.radioOutsourced.AutoSize = true;
            this.radioOutsourced.Location = new System.Drawing.Point(278, 27);
            this.radioOutsourced.Name = "radioOutsourced";
            this.radioOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radioOutsourced.TabIndex = 2;
            this.radioOutsourced.TabStop = true;
            this.radioOutsourced.Text = "Outsourced";
            this.radioOutsourced.UseVisualStyleBackColor = true;
            this.radioOutsourced.CheckedChanged += new System.EventHandler(this.radioOutsourced_CheckedChanged);
            // 
            // lblAddID
            // 
            this.lblAddID.AutoSize = true;
            this.lblAddID.Location = new System.Drawing.Point(12, 71);
            this.lblAddID.Name = "lblAddID";
            this.lblAddID.Size = new System.Drawing.Size(18, 13);
            this.lblAddID.TabIndex = 3;
            this.lblAddID.Text = "ID";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(11, 105);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(35, 13);
            this.lblAddName.TabIndex = 4;
            this.lblAddName.Text = "Name";
            // 
            // lblAddInventory
            // 
            this.lblAddInventory.AutoSize = true;
            this.lblAddInventory.Location = new System.Drawing.Point(11, 141);
            this.lblAddInventory.Name = "lblAddInventory";
            this.lblAddInventory.Size = new System.Drawing.Size(51, 13);
            this.lblAddInventory.TabIndex = 5;
            this.lblAddInventory.Text = "Inventory";
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Location = new System.Drawing.Point(12, 178);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(63, 13);
            this.lblAddPrice.TabIndex = 6;
            this.lblAddPrice.Text = "Price / Cost";
            // 
            // lblAddMax
            // 
            this.lblAddMax.AutoSize = true;
            this.lblAddMax.Location = new System.Drawing.Point(12, 214);
            this.lblAddMax.Name = "lblAddMax";
            this.lblAddMax.Size = new System.Drawing.Size(27, 13);
            this.lblAddMax.TabIndex = 7;
            this.lblAddMax.Text = "Max";
            // 
            // lblAddMin
            // 
            this.lblAddMin.AutoSize = true;
            this.lblAddMin.Location = new System.Drawing.Point(238, 214);
            this.lblAddMin.Name = "lblAddMin";
            this.lblAddMin.Size = new System.Drawing.Size(24, 13);
            this.lblAddMin.TabIndex = 8;
            this.lblAddMin.Text = "Min";
            // 
            // lblAddMachineID
            // 
            this.lblAddMachineID.AutoSize = true;
            this.lblAddMachineID.Location = new System.Drawing.Point(11, 250);
            this.lblAddMachineID.Name = "lblAddMachineID";
            this.lblAddMachineID.Size = new System.Drawing.Size(62, 13);
            this.lblAddMachineID.TabIndex = 9;
            this.lblAddMachineID.Text = "Machine ID";
            // 
            // inStockTextBox
            // 
            this.inStockTextBox.Location = new System.Drawing.Point(106, 138);
            this.inStockTextBox.Name = "inStockTextBox";
            this.inStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.inStockTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(106, 175);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(106, 211);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTextBox.TabIndex = 6;
            // 
            // machIDTextBox
            // 
            this.machIDTextBox.Location = new System.Drawing.Point(106, 247);
            this.machIDTextBox.Name = "machIDTextBox";
            this.machIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.machIDTextBox.TabIndex = 8;
            
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(106, 102);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.Location = new System.Drawing.Point(106, 68);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.ReadOnly = true;
            this.partIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.partIDTextBox.TabIndex = 15;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(278, 211);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTextBox.TabIndex = 7;
            // 
            // btnSaveAddPart
            // 
            this.btnSaveAddPart.Location = new System.Drawing.Point(203, 347);
            this.btnSaveAddPart.Name = "btnSaveAddPart";
            this.btnSaveAddPart.Size = new System.Drawing.Size(75, 39);
            this.btnSaveAddPart.TabIndex = 17;
            this.btnSaveAddPart.Text = "Save";
            this.btnSaveAddPart.UseVisualStyleBackColor = true;
            this.btnSaveAddPart.Click += new System.EventHandler(this.btnSaveAddPart_Click);
            // 
            // btnCancelAddPart
            // 
            this.btnCancelAddPart.Location = new System.Drawing.Point(302, 347);
            this.btnCancelAddPart.Name = "btnCancelAddPart";
            this.btnCancelAddPart.Size = new System.Drawing.Size(75, 39);
            this.btnCancelAddPart.TabIndex = 18;
            this.btnCancelAddPart.Text = "Cancel";
            this.btnCancelAddPart.UseVisualStyleBackColor = true;
            this.btnCancelAddPart.Click += new System.EventHandler(this.btnCancelAddPart_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 418);
            this.Controls.Add(this.btnCancelAddPart);
            this.Controls.Add(this.btnSaveAddPart);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.partIDTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.machIDTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inStockTextBox);
            this.Controls.Add(this.lblAddMachineID);
            this.Controls.Add(this.lblAddMin);
            this.Controls.Add(this.lblAddMax);
            this.Controls.Add(this.lblAddPrice);
            this.Controls.Add(this.lblAddInventory);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.lblAddID);
            this.Controls.Add(this.radioOutsourced);
            this.Controls.Add(this.radioInHouse);
            this.Controls.Add(this.label1);
            this.Name = "AddPartForm";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioInHouse;
        private System.Windows.Forms.RadioButton radioOutsourced;
        private System.Windows.Forms.Label lblAddID;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddInventory;
        private System.Windows.Forms.Label lblAddPrice;
        private System.Windows.Forms.Label lblAddMax;
        private System.Windows.Forms.Label lblAddMin;
        private System.Windows.Forms.Label lblAddMachineID;
        private System.Windows.Forms.TextBox inStockTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox machIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Button btnSaveAddPart;
        private System.Windows.Forms.Button btnCancelAddPart;
    }
}