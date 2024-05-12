namespace IMS.model
{
    partial class AddProduct
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
            this.dgvAddProductView = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedPartsView = new System.Windows.Forms.DataGridView();
            this.lblAddProdID = new System.Windows.Forms.Label();
            this.lblAddProdName = new System.Windows.Forms.Label();
            this.lblAddProdInv = new System.Windows.Forms.Label();
            this.lblAddProdPrice = new System.Windows.Forms.Label();
            this.lblAddProdMax = new System.Windows.Forms.Label();
            this.lblAddProdMin = new System.Windows.Forms.Label();
            this.addProdIDTextbox = new System.Windows.Forms.TextBox();
            this.addProdNameTextbox = new System.Windows.Forms.TextBox();
            this.addProdInvTextbox = new System.Windows.Forms.TextBox();
            this.addProdPriceTextbox = new System.Windows.Forms.TextBox();
            this.addProdMaxTextbox = new System.Windows.Forms.TextBox();
            this.addProdMinTextbox = new System.Windows.Forms.TextBox();
            this.btnAddCandidatePart = new System.Windows.Forms.Button();
            this.btnDelAssocPart = new System.Windows.Forms.Button();
            this.btnCancelAddProduct = new System.Windows.Forms.Button();
            this.btnSaveAddProduct = new System.Windows.Forms.Button();
            this.addProdSearchTextbox = new System.Windows.Forms.TextBox();
            this.btnAddProductSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedPartsView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddProductView
            // 
            this.dgvAddProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddProductView.Location = new System.Drawing.Point(426, 61);
            this.dgvAddProductView.Name = "dgvAddProductView";
            this.dgvAddProductView.Size = new System.Drawing.Size(569, 190);
            this.dgvAddProductView.TabIndex = 0;
            // 
            // dgvAssociatedPartsView
            // 
            this.dgvAssociatedPartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedPartsView.Location = new System.Drawing.Point(426, 328);
            this.dgvAssociatedPartsView.Name = "dgvAssociatedPartsView";
            this.dgvAssociatedPartsView.Size = new System.Drawing.Size(569, 187);
            this.dgvAssociatedPartsView.TabIndex = 1;
            // 
            // lblAddProdID
            // 
            this.lblAddProdID.AutoSize = true;
            this.lblAddProdID.Location = new System.Drawing.Point(36, 180);
            this.lblAddProdID.Name = "lblAddProdID";
            this.lblAddProdID.Size = new System.Drawing.Size(18, 13);
            this.lblAddProdID.TabIndex = 2;
            this.lblAddProdID.Text = "ID";
            // 
            // lblAddProdName
            // 
            this.lblAddProdName.AutoSize = true;
            this.lblAddProdName.Location = new System.Drawing.Point(36, 217);
            this.lblAddProdName.Name = "lblAddProdName";
            this.lblAddProdName.Size = new System.Drawing.Size(35, 13);
            this.lblAddProdName.TabIndex = 3;
            this.lblAddProdName.Text = "Name";
            // 
            // lblAddProdInv
            // 
            this.lblAddProdInv.AutoSize = true;
            this.lblAddProdInv.Location = new System.Drawing.Point(36, 253);
            this.lblAddProdInv.Name = "lblAddProdInv";
            this.lblAddProdInv.Size = new System.Drawing.Size(51, 13);
            this.lblAddProdInv.TabIndex = 4;
            this.lblAddProdInv.Text = "Inventory";
            // 
            // lblAddProdPrice
            // 
            this.lblAddProdPrice.AutoSize = true;
            this.lblAddProdPrice.Location = new System.Drawing.Point(36, 293);
            this.lblAddProdPrice.Name = "lblAddProdPrice";
            this.lblAddProdPrice.Size = new System.Drawing.Size(31, 13);
            this.lblAddProdPrice.TabIndex = 5;
            this.lblAddProdPrice.Text = "Price";
            // 
            // lblAddProdMax
            // 
            this.lblAddProdMax.AutoSize = true;
            this.lblAddProdMax.Location = new System.Drawing.Point(36, 331);
            this.lblAddProdMax.Name = "lblAddProdMax";
            this.lblAddProdMax.Size = new System.Drawing.Size(27, 13);
            this.lblAddProdMax.TabIndex = 6;
            this.lblAddProdMax.Text = "Max";
            // 
            // lblAddProdMin
            // 
            this.lblAddProdMin.AutoSize = true;
            this.lblAddProdMin.Location = new System.Drawing.Point(210, 331);
            this.lblAddProdMin.Name = "lblAddProdMin";
            this.lblAddProdMin.Size = new System.Drawing.Size(24, 13);
            this.lblAddProdMin.TabIndex = 7;
            this.lblAddProdMin.Text = "Min";
            // 
            // addProdIDTextbox
            // 
            this.addProdIDTextbox.Location = new System.Drawing.Point(95, 177);
            this.addProdIDTextbox.Name = "addProdIDTextbox";
            this.addProdIDTextbox.ReadOnly = true;
            this.addProdIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.addProdIDTextbox.TabIndex = 1;
            // 
            // addProdNameTextbox
            // 
            this.addProdNameTextbox.Location = new System.Drawing.Point(95, 214);
            this.addProdNameTextbox.Name = "addProdNameTextbox";
            this.addProdNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.addProdNameTextbox.TabIndex = 2;
            // 
            // addProdInvTextbox
            // 
            this.addProdInvTextbox.Location = new System.Drawing.Point(95, 250);
            this.addProdInvTextbox.Name = "addProdInvTextbox";
            this.addProdInvTextbox.Size = new System.Drawing.Size(100, 20);
            this.addProdInvTextbox.TabIndex = 3;
            // 
            // addProdPriceTextbox
            // 
            this.addProdPriceTextbox.Location = new System.Drawing.Point(95, 290);
            this.addProdPriceTextbox.Name = "addProdPriceTextbox";
            this.addProdPriceTextbox.Size = new System.Drawing.Size(100, 20);
            this.addProdPriceTextbox.TabIndex = 4;
            // 
            // addProdMaxTextbox
            // 
            this.addProdMaxTextbox.Location = new System.Drawing.Point(95, 328);
            this.addProdMaxTextbox.Name = "addProdMaxTextbox";
            this.addProdMaxTextbox.Size = new System.Drawing.Size(100, 20);
            this.addProdMaxTextbox.TabIndex = 5;
            // 
            // addProdMinTextbox
            // 
            this.addProdMinTextbox.Location = new System.Drawing.Point(260, 328);
            this.addProdMinTextbox.Name = "addProdMinTextbox";
            this.addProdMinTextbox.Size = new System.Drawing.Size(100, 20);
            this.addProdMinTextbox.TabIndex = 6;
            // 
            // btnAddCandidatePart
            // 
            this.btnAddCandidatePart.Location = new System.Drawing.Point(918, 271);
            this.btnAddCandidatePart.Name = "btnAddCandidatePart";
            this.btnAddCandidatePart.Size = new System.Drawing.Size(75, 35);
            this.btnAddCandidatePart.TabIndex = 8;
            this.btnAddCandidatePart.Text = "Add";
            this.btnAddCandidatePart.UseVisualStyleBackColor = true;
            this.btnAddCandidatePart.Click += new System.EventHandler(this.btnAddCandidatePart_Click);
            // 
            // btnDelAssocPart
            // 
            this.btnDelAssocPart.Location = new System.Drawing.Point(918, 532);
            this.btnDelAssocPart.Name = "btnDelAssocPart";
            this.btnDelAssocPart.Size = new System.Drawing.Size(75, 36);
            this.btnDelAssocPart.TabIndex = 9;
            this.btnDelAssocPart.Text = "Delete";
            this.btnDelAssocPart.UseVisualStyleBackColor = true;
            this.btnDelAssocPart.Click += new System.EventHandler(this.btnDelAssocPart_Click);
            // 
            // btnCancelAddProduct
            // 
            this.btnCancelAddProduct.Location = new System.Drawing.Point(918, 574);
            this.btnCancelAddProduct.Name = "btnCancelAddProduct";
            this.btnCancelAddProduct.Size = new System.Drawing.Size(75, 36);
            this.btnCancelAddProduct.TabIndex = 10;
            this.btnCancelAddProduct.Text = "Cancel";
            this.btnCancelAddProduct.UseVisualStyleBackColor = true;
            this.btnCancelAddProduct.Click += new System.EventHandler(this.btnCancelAddProduct_Click);
            // 
            // btnSaveAddProduct
            // 
            this.btnSaveAddProduct.Location = new System.Drawing.Point(808, 574);
            this.btnSaveAddProduct.Name = "btnSaveAddProduct";
            this.btnSaveAddProduct.Size = new System.Drawing.Size(75, 35);
            this.btnSaveAddProduct.TabIndex = 11;
            this.btnSaveAddProduct.Text = "Save";
            this.btnSaveAddProduct.UseVisualStyleBackColor = true;
            this.btnSaveAddProduct.Click += new System.EventHandler(this.btnSaveAddProduct_Click);
            // 
            // addProdSearchTextbox
            // 
            this.addProdSearchTextbox.Location = new System.Drawing.Point(826, 25);
            this.addProdSearchTextbox.Name = "addProdSearchTextbox";
            this.addProdSearchTextbox.Size = new System.Drawing.Size(169, 20);
            this.addProdSearchTextbox.TabIndex = 12;
            // 
            // btnAddProductSearch
            // 
            this.btnAddProductSearch.Location = new System.Drawing.Point(731, 23);
            this.btnAddProductSearch.Name = "btnAddProductSearch";
            this.btnAddProductSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAddProductSearch.TabIndex = 13;
            this.btnAddProductSearch.Text = "Search";
            this.btnAddProductSearch.UseVisualStyleBackColor = true;
            this.btnAddProductSearch.Click += new System.EventHandler(this.btnAddProductSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "All candidate parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Parts Associated with this Product";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProductSearch);
            this.Controls.Add(this.addProdSearchTextbox);
            this.Controls.Add(this.btnSaveAddProduct);
            this.Controls.Add(this.btnCancelAddProduct);
            this.Controls.Add(this.btnDelAssocPart);
            this.Controls.Add(this.btnAddCandidatePart);
            this.Controls.Add(this.addProdMinTextbox);
            this.Controls.Add(this.addProdMaxTextbox);
            this.Controls.Add(this.addProdPriceTextbox);
            this.Controls.Add(this.addProdInvTextbox);
            this.Controls.Add(this.addProdNameTextbox);
            this.Controls.Add(this.addProdIDTextbox);
            this.Controls.Add(this.lblAddProdMin);
            this.Controls.Add(this.lblAddProdMax);
            this.Controls.Add(this.lblAddProdPrice);
            this.Controls.Add(this.lblAddProdInv);
            this.Controls.Add(this.lblAddProdName);
            this.Controls.Add(this.lblAddProdID);
            this.Controls.Add(this.dgvAssociatedPartsView);
            this.Controls.Add(this.dgvAddProductView);
            this.Name = "AddProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedPartsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddProductView;
        private System.Windows.Forms.DataGridView dgvAssociatedPartsView;
        private System.Windows.Forms.Label lblAddProdID;
        private System.Windows.Forms.Label lblAddProdName;
        private System.Windows.Forms.Label lblAddProdInv;
        private System.Windows.Forms.Label lblAddProdPrice;
        private System.Windows.Forms.Label lblAddProdMax;
        private System.Windows.Forms.Label lblAddProdMin;
        private System.Windows.Forms.TextBox addProdIDTextbox;
        private System.Windows.Forms.TextBox addProdNameTextbox;
        private System.Windows.Forms.TextBox addProdInvTextbox;
        private System.Windows.Forms.TextBox addProdPriceTextbox;
        private System.Windows.Forms.TextBox addProdMaxTextbox;
        private System.Windows.Forms.TextBox addProdMinTextbox;
        private System.Windows.Forms.Button btnAddCandidatePart;
        private System.Windows.Forms.Button btnDelAssocPart;
        private System.Windows.Forms.Button btnCancelAddProduct;
        private System.Windows.Forms.Button btnSaveAddProduct;
        private System.Windows.Forms.TextBox addProdSearchTextbox;
        private System.Windows.Forms.Button btnAddProductSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}