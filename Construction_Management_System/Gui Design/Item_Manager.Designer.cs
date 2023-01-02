namespace Construction_Management_System.Gui_Design
{
    partial class Item_Manager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonItemClear = new System.Windows.Forms.Button();
            this.buttonItemDelete = new System.Windows.Forms.Button();
            this.buttonItemUpdate = new System.Windows.Forms.Button();
            this.buttonItemAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxItemManagerPrice = new System.Windows.Forms.TextBox();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.labelItemTotal = new System.Windows.Forms.Label();
            this.textBoxItemTotal = new System.Windows.Forms.TextBox();
            this.comboBoxSupplierName = new System.Windows.Forms.ComboBox();
            this.buttonAddCatagory = new System.Windows.Forms.Button();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.labelItemQuantity = new System.Windows.Forms.Label();
            this.textBoxItemQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxItemCatagory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.textBoxItemId = new System.Windows.Forms.TextBox();
            this.labelItemId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(521, 484);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonItemClear
            // 
            this.buttonItemClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonItemClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemClear.Location = new System.Drawing.Point(640, 538);
            this.buttonItemClear.Name = "buttonItemClear";
            this.buttonItemClear.Size = new System.Drawing.Size(96, 37);
            this.buttonItemClear.TabIndex = 9;
            this.buttonItemClear.Text = "CLEAR";
            this.buttonItemClear.UseVisualStyleBackColor = false;
            this.buttonItemClear.Click += new System.EventHandler(this.buttonItemClear_Click);
            // 
            // buttonItemDelete
            // 
            this.buttonItemDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonItemDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemDelete.Location = new System.Drawing.Point(514, 538);
            this.buttonItemDelete.Name = "buttonItemDelete";
            this.buttonItemDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonItemDelete.TabIndex = 8;
            this.buttonItemDelete.Text = "DELETE";
            this.buttonItemDelete.UseVisualStyleBackColor = false;
            this.buttonItemDelete.Click += new System.EventHandler(this.buttonItemDelete_Click);
            // 
            // buttonItemUpdate
            // 
            this.buttonItemUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonItemUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemUpdate.Location = new System.Drawing.Point(386, 538);
            this.buttonItemUpdate.Name = "buttonItemUpdate";
            this.buttonItemUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonItemUpdate.TabIndex = 7;
            this.buttonItemUpdate.Text = "UPDATE";
            this.buttonItemUpdate.UseVisualStyleBackColor = false;
            this.buttonItemUpdate.Click += new System.EventHandler(this.buttonItemUpdate_Click);
            // 
            // buttonItemAdd
            // 
            this.buttonItemAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonItemAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemAdd.Location = new System.Drawing.Point(248, 538);
            this.buttonItemAdd.Name = "buttonItemAdd";
            this.buttonItemAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonItemAdd.TabIndex = 6;
            this.buttonItemAdd.Text = "ADD";
            this.buttonItemAdd.UseVisualStyleBackColor = false;
            this.buttonItemAdd.Click += new System.EventHandler(this.buttonItemAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Construction_Management_System.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textBoxItemManagerPrice);
            this.panel1.Controls.Add(this.labelItemPrice);
            this.panel1.Controls.Add(this.labelItemTotal);
            this.panel1.Controls.Add(this.textBoxItemTotal);
            this.panel1.Controls.Add(this.comboBoxSupplierName);
            this.panel1.Controls.Add(this.buttonAddCatagory);
            this.panel1.Controls.Add(this.labelSupplierName);
            this.panel1.Controls.Add(this.labelItemQuantity);
            this.panel1.Controls.Add(this.textBoxItemQuantity);
            this.panel1.Controls.Add(this.comboBoxItemCatagory);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxItemName);
            this.panel1.Controls.Add(this.labelItemName);
            this.panel1.Controls.Add(this.textBoxItemId);
            this.panel1.Controls.Add(this.labelItemId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 634);
            this.panel1.TabIndex = 1;
            // 
            // textBoxItemManagerPrice
            // 
            this.textBoxItemManagerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemManagerPrice.Location = new System.Drawing.Point(21, 364);
            this.textBoxItemManagerPrice.Name = "textBoxItemManagerPrice";
            this.textBoxItemManagerPrice.Size = new System.Drawing.Size(169, 20);
            this.textBoxItemManagerPrice.TabIndex = 3;
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPrice.ForeColor = System.Drawing.Color.White;
            this.labelItemPrice.Location = new System.Drawing.Point(18, 344);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(70, 17);
            this.labelItemPrice.TabIndex = 37;
            this.labelItemPrice.Text = "Item Price";
            // 
            // labelItemTotal
            // 
            this.labelItemTotal.AutoSize = true;
            this.labelItemTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemTotal.ForeColor = System.Drawing.Color.White;
            this.labelItemTotal.Location = new System.Drawing.Point(20, 451);
            this.labelItemTotal.Name = "labelItemTotal";
            this.labelItemTotal.Size = new System.Drawing.Size(73, 17);
            this.labelItemTotal.TabIndex = 35;
            this.labelItemTotal.Text = "Total Price";
            // 
            // textBoxItemTotal
            // 
            this.textBoxItemTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemTotal.Location = new System.Drawing.Point(21, 471);
            this.textBoxItemTotal.Name = "textBoxItemTotal";
            this.textBoxItemTotal.Size = new System.Drawing.Size(171, 20);
            this.textBoxItemTotal.TabIndex = 5;
            // 
            // comboBoxSupplierName
            // 
            this.comboBoxSupplierName.FormattingEnabled = true;
            this.comboBoxSupplierName.Location = new System.Drawing.Point(22, 528);
            this.comboBoxSupplierName.Name = "comboBoxSupplierName";
            this.comboBoxSupplierName.Size = new System.Drawing.Size(168, 21);
            this.comboBoxSupplierName.TabIndex = 6;
            // 
            // buttonAddCatagory
            // 
            this.buttonAddCatagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAddCatagory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCatagory.Location = new System.Drawing.Point(20, 309);
            this.buttonAddCatagory.Name = "buttonAddCatagory";
            this.buttonAddCatagory.Size = new System.Drawing.Size(112, 32);
            this.buttonAddCatagory.TabIndex = 32;
            this.buttonAddCatagory.Text = "ADD CATAGORY";
            this.buttonAddCatagory.UseVisualStyleBackColor = false;
            this.buttonAddCatagory.Click += new System.EventHandler(this.buttonAddCatagory_Click);
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierName.ForeColor = System.Drawing.Color.White;
            this.labelSupplierName.Location = new System.Drawing.Point(18, 506);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(99, 17);
            this.labelSupplierName.TabIndex = 30;
            this.labelSupplierName.Text = "Supplier Name";
            // 
            // labelItemQuantity
            // 
            this.labelItemQuantity.AutoSize = true;
            this.labelItemQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemQuantity.ForeColor = System.Drawing.Color.White;
            this.labelItemQuantity.Location = new System.Drawing.Point(19, 399);
            this.labelItemQuantity.Name = "labelItemQuantity";
            this.labelItemQuantity.Size = new System.Drawing.Size(94, 17);
            this.labelItemQuantity.TabIndex = 31;
            this.labelItemQuantity.Text = "Item Quantity";
            // 
            // textBoxItemQuantity
            // 
            this.textBoxItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemQuantity.Location = new System.Drawing.Point(20, 419);
            this.textBoxItemQuantity.Name = "textBoxItemQuantity";
            this.textBoxItemQuantity.Size = new System.Drawing.Size(171, 20);
            this.textBoxItemQuantity.TabIndex = 4;
            this.textBoxItemQuantity.TextChanged += new System.EventHandler(this.textBoxItemQuantity_TextChanged);
            // 
            // comboBoxItemCatagory
            // 
            this.comboBoxItemCatagory.FormattingEnabled = true;
            this.comboBoxItemCatagory.Location = new System.Drawing.Point(21, 282);
            this.comboBoxItemCatagory.Name = "comboBoxItemCatagory";
            this.comboBoxItemCatagory.Size = new System.Drawing.Size(168, 21);
            this.comboBoxItemCatagory.TabIndex = 2;
            this.comboBoxItemCatagory.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemCatagory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Item Category";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemName.Location = new System.Drawing.Point(18, 228);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(169, 20);
            this.textBoxItemName.TabIndex = 1;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.ForeColor = System.Drawing.Color.White;
            this.labelItemName.Location = new System.Drawing.Point(15, 208);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(76, 17);
            this.labelItemName.TabIndex = 25;
            this.labelItemName.Text = "Item Name";
            // 
            // textBoxItemId
            // 
            this.textBoxItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxItemId.Location = new System.Drawing.Point(18, 175);
            this.textBoxItemId.Name = "textBoxItemId";
            this.textBoxItemId.Size = new System.Drawing.Size(169, 20);
            this.textBoxItemId.TabIndex = 0;
            // 
            // labelItemId
            // 
            this.labelItemId.AutoSize = true;
            this.labelItemId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemId.ForeColor = System.Drawing.Color.White;
            this.labelItemId.Location = new System.Drawing.Point(15, 155);
            this.labelItemId.Name = "labelItemId";
            this.labelItemId.Size = new System.Drawing.Size(54, 17);
            this.labelItemId.TabIndex = 23;
            this.labelItemId.Text = "Item ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "ITEM";
            // 
            // Item_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 625);
            this.Controls.Add(this.buttonItemClear);
            this.Controls.Add(this.buttonItemDelete);
            this.Controls.Add(this.buttonItemUpdate);
            this.Controls.Add(this.buttonItemAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Item_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item_Manager";
            this.Load += new System.EventHandler(this.Item_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonItemClear;
        private System.Windows.Forms.Button buttonItemDelete;
        private System.Windows.Forms.Button buttonItemUpdate;
        private System.Windows.Forms.Button buttonItemAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxSupplierName;
        private System.Windows.Forms.Button buttonAddCatagory;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.Label labelItemQuantity;
        private System.Windows.Forms.TextBox textBoxItemQuantity;
        private System.Windows.Forms.ComboBox comboBoxItemCatagory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.TextBox textBoxItemId;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelItemTotal;
        private System.Windows.Forms.TextBox textBoxItemTotal;
        private System.Windows.Forms.TextBox textBoxItemManagerPrice;
        private System.Windows.Forms.Label labelItemPrice;
    }
}