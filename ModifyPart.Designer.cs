namespace IMS
{
    partial class ModifyPart
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
            this.lblModifyPart = new System.Windows.Forms.Label();
            this.radioModInHouse = new System.Windows.Forms.RadioButton();
            this.radioModOutsourced = new System.Windows.Forms.RadioButton();
            this.lblModID = new System.Windows.Forms.Label();
            this.lblModName = new System.Windows.Forms.Label();
            this.lblModInv = new System.Windows.Forms.Label();
            this.lblModPrice = new System.Windows.Forms.Label();
            this.lblModMax = new System.Windows.Forms.Label();
            this.lblModMachID = new System.Windows.Forms.Label();
            this.lblModMin = new System.Windows.Forms.Label();
            this.modPartIDTextBox = new System.Windows.Forms.TextBox();
            this.nameModTextBox = new System.Windows.Forms.TextBox();
            this.inStockModTextBox = new System.Windows.Forms.TextBox();
            this.priceModTextBox = new System.Windows.Forms.TextBox();
            this.maxModTextBox = new System.Windows.Forms.TextBox();
            this.machIDModTextBox = new System.Windows.Forms.TextBox();
            this.minModTextBox = new System.Windows.Forms.TextBox();
            this.btnSaveModPart = new System.Windows.Forms.Button();
            this.btnCancelModPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModifyPart
            // 
            this.lblModifyPart.AutoSize = true;
            this.lblModifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyPart.Location = new System.Drawing.Point(12, 10);
            this.lblModifyPart.Name = "lblModifyPart";
            this.lblModifyPart.Size = new System.Drawing.Size(83, 18);
            this.lblModifyPart.TabIndex = 0;
            this.lblModifyPart.Text = "Modify Part";
            // 
            // radioModInHouse
            // 
            this.radioModInHouse.AutoSize = true;
            this.radioModInHouse.Location = new System.Drawing.Point(173, 12);
            this.radioModInHouse.Name = "radioModInHouse";
            this.radioModInHouse.Size = new System.Drawing.Size(65, 17);
            this.radioModInHouse.TabIndex = 1;
            this.radioModInHouse.TabStop = true;
            this.radioModInHouse.Text = "InHouse";
            this.radioModInHouse.UseVisualStyleBackColor = true;
            this.radioModInHouse.Click += new System.EventHandler(this.radioModInHouse_Click);
            // 
            // radioModOutsourced
            // 
            this.radioModOutsourced.AutoSize = true;
            this.radioModOutsourced.Location = new System.Drawing.Point(292, 12);
            this.radioModOutsourced.Name = "radioModOutsourced";
            this.radioModOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radioModOutsourced.TabIndex = 2;
            this.radioModOutsourced.TabStop = true;
            this.radioModOutsourced.Text = "Outsourced";
            this.radioModOutsourced.UseVisualStyleBackColor = true;
            this.radioModOutsourced.Click += new System.EventHandler(this.radioModOutsourced_Click);
            // 
            // lblModID
            // 
            this.lblModID.AutoSize = true;
            this.lblModID.Location = new System.Drawing.Point(12, 61);
            this.lblModID.Name = "lblModID";
            this.lblModID.Size = new System.Drawing.Size(18, 13);
            this.lblModID.TabIndex = 3;
            this.lblModID.Text = "ID";
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(12, 99);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(35, 13);
            this.lblModName.TabIndex = 4;
            this.lblModName.Text = "Name";
            // 
            // lblModInv
            // 
            this.lblModInv.AutoSize = true;
            this.lblModInv.Location = new System.Drawing.Point(12, 134);
            this.lblModInv.Name = "lblModInv";
            this.lblModInv.Size = new System.Drawing.Size(51, 13);
            this.lblModInv.TabIndex = 5;
            this.lblModInv.Text = "Inventory";
            // 
            // lblModPrice
            // 
            this.lblModPrice.AutoSize = true;
            this.lblModPrice.Location = new System.Drawing.Point(12, 173);
            this.lblModPrice.Name = "lblModPrice";
            this.lblModPrice.Size = new System.Drawing.Size(63, 13);
            this.lblModPrice.TabIndex = 6;
            this.lblModPrice.Text = "Price / Cost";
            // 
            // lblModMax
            // 
            this.lblModMax.AutoSize = true;
            this.lblModMax.Location = new System.Drawing.Point(12, 211);
            this.lblModMax.Name = "lblModMax";
            this.lblModMax.Size = new System.Drawing.Size(27, 13);
            this.lblModMax.TabIndex = 7;
            this.lblModMax.Text = "Max";
            // 
            // lblModMachID
            // 
            this.lblModMachID.AutoSize = true;
            this.lblModMachID.Location = new System.Drawing.Point(12, 249);
            this.lblModMachID.Name = "lblModMachID";
            this.lblModMachID.Size = new System.Drawing.Size(62, 13);
            this.lblModMachID.TabIndex = 8;
            this.lblModMachID.Text = "Machine ID";
            // 
            // lblModMin
            // 
            this.lblModMin.AutoSize = true;
            this.lblModMin.Location = new System.Drawing.Point(245, 211);
            this.lblModMin.Name = "lblModMin";
            this.lblModMin.Size = new System.Drawing.Size(24, 13);
            this.lblModMin.TabIndex = 9;
            this.lblModMin.Text = "Min";
            // 
            // modPartIDTextBox
            // 
            this.modPartIDTextBox.Location = new System.Drawing.Point(102, 58);
            this.modPartIDTextBox.Name = "modPartIDTextBox";
            this.modPartIDTextBox.ReadOnly = true;
            this.modPartIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.modPartIDTextBox.TabIndex = 10;
            // 
            // nameModTextBox
            // 
            this.nameModTextBox.Location = new System.Drawing.Point(102, 96);
            this.nameModTextBox.Name = "nameModTextBox";
            this.nameModTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameModTextBox.TabIndex = 11;
            // 
            // inStockModTextBox
            // 
            this.inStockModTextBox.Location = new System.Drawing.Point(102, 131);
            this.inStockModTextBox.Name = "inStockModTextBox";
            this.inStockModTextBox.Size = new System.Drawing.Size(100, 20);
            this.inStockModTextBox.TabIndex = 12;
            
            // 
            // priceModTextBox
            // 
            this.priceModTextBox.Location = new System.Drawing.Point(102, 170);
            this.priceModTextBox.Name = "priceModTextBox";
            this.priceModTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceModTextBox.TabIndex = 13;
            
            // 
            // maxModTextBox
            // 
            this.maxModTextBox.Location = new System.Drawing.Point(102, 208);
            this.maxModTextBox.Name = "maxModTextBox";
            this.maxModTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxModTextBox.TabIndex = 14;
            
            // 
            // machIDModTextBox
            // 
            this.machIDModTextBox.Location = new System.Drawing.Point(102, 246);
            this.machIDModTextBox.Name = "machIDModTextBox";
            this.machIDModTextBox.Size = new System.Drawing.Size(100, 20);
            this.machIDModTextBox.TabIndex = 15;
            
            // 
            // minModTextBox
            // 
            this.minModTextBox.Location = new System.Drawing.Point(292, 207);
            this.minModTextBox.Name = "minModTextBox";
            this.minModTextBox.Size = new System.Drawing.Size(100, 20);
            this.minModTextBox.TabIndex = 16;
            
            // 
            // btnSaveModPart
            // 
            this.btnSaveModPart.Location = new System.Drawing.Point(194, 398);
            this.btnSaveModPart.Name = "btnSaveModPart";
            this.btnSaveModPart.Size = new System.Drawing.Size(75, 39);
            this.btnSaveModPart.TabIndex = 17;
            this.btnSaveModPart.Text = "Save";
            this.btnSaveModPart.UseVisualStyleBackColor = true;
            this.btnSaveModPart.Click += new System.EventHandler(this.btnSaveModPart_Click);
            // 
            // btnCancelModPart
            // 
            this.btnCancelModPart.Location = new System.Drawing.Point(317, 398);
            this.btnCancelModPart.Name = "btnCancelModPart";
            this.btnCancelModPart.Size = new System.Drawing.Size(75, 39);
            this.btnCancelModPart.TabIndex = 18;
            this.btnCancelModPart.Text = "Cancel";
            this.btnCancelModPart.UseVisualStyleBackColor = true;
            this.btnCancelModPart.Click += new System.EventHandler(this.btnCancelModPart_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.btnCancelModPart);
            this.Controls.Add(this.btnSaveModPart);
            this.Controls.Add(this.minModTextBox);
            this.Controls.Add(this.machIDModTextBox);
            this.Controls.Add(this.maxModTextBox);
            this.Controls.Add(this.priceModTextBox);
            this.Controls.Add(this.inStockModTextBox);
            this.Controls.Add(this.nameModTextBox);
            this.Controls.Add(this.modPartIDTextBox);
            this.Controls.Add(this.lblModMin);
            this.Controls.Add(this.lblModMachID);
            this.Controls.Add(this.lblModMax);
            this.Controls.Add(this.lblModPrice);
            this.Controls.Add(this.lblModInv);
            this.Controls.Add(this.lblModName);
            this.Controls.Add(this.lblModID);
            this.Controls.Add(this.radioModOutsourced);
            this.Controls.Add(this.radioModInHouse);
            this.Controls.Add(this.lblModifyPart);
            this.Name = "ModifyPart";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifyPart;
        private System.Windows.Forms.RadioButton radioModInHouse;
        private System.Windows.Forms.RadioButton radioModOutsourced;
        private System.Windows.Forms.Label lblModID;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Label lblModInv;
        private System.Windows.Forms.Label lblModPrice;
        private System.Windows.Forms.Label lblModMax;
        private System.Windows.Forms.Label lblModMachID;
        private System.Windows.Forms.Label lblModMin;
        private System.Windows.Forms.TextBox modPartIDTextBox;
        private System.Windows.Forms.TextBox nameModTextBox;
        private System.Windows.Forms.TextBox inStockModTextBox;
        private System.Windows.Forms.TextBox priceModTextBox;
        private System.Windows.Forms.TextBox maxModTextBox;
        private System.Windows.Forms.TextBox machIDModTextBox;
        private System.Windows.Forms.TextBox minModTextBox;
        private System.Windows.Forms.Button btnSaveModPart;
        private System.Windows.Forms.Button btnCancelModPart;
    }
}