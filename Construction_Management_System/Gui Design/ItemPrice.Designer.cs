namespace Construction_Management_System.Gui_Design
{
    partial class ItemPrice
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
            this.panelItemPrice = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxItemPriceCatagory = new System.Windows.Forms.ComboBox();
            this.labelCatagory = new System.Windows.Forms.Label();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.dataGridViewItemPrice = new System.Windows.Forms.DataGridView();
            this.panelItemPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panelItemPrice
            // 
            this.panelItemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelItemPrice.Controls.Add(this.pictureBox1);
            this.panelItemPrice.Controls.Add(this.buttonUpdate);
            this.panelItemPrice.Controls.Add(this.buttonAdd);
            this.panelItemPrice.Controls.Add(this.textBoxPrice);
            this.panelItemPrice.Controls.Add(this.labelPrice);
            this.panelItemPrice.Controls.Add(this.comboBoxItemPriceCatagory);
            this.panelItemPrice.Controls.Add(this.labelCatagory);
            this.panelItemPrice.Controls.Add(this.labelItemPrice);
            this.panelItemPrice.Location = new System.Drawing.Point(0, 0);
            this.panelItemPrice.Name = "panelItemPrice";
            this.panelItemPrice.Size = new System.Drawing.Size(200, 519);
            this.panelItemPrice.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Construction_Management_System.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(19, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(101, 324);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(19, 324);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(19, 269);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(165, 20);
            this.textBoxPrice.TabIndex = 1;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(16, 239);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(38, 17);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price";
            // 
            // comboBoxItemPriceCatagory
            // 
            this.comboBoxItemPriceCatagory.FormattingEnabled = true;
            this.comboBoxItemPriceCatagory.Location = new System.Drawing.Point(16, 208);
            this.comboBoxItemPriceCatagory.Name = "comboBoxItemPriceCatagory";
            this.comboBoxItemPriceCatagory.Size = new System.Drawing.Size(168, 21);
            this.comboBoxItemPriceCatagory.TabIndex = 0;
            // 
            // labelCatagory
            // 
            this.labelCatagory.AutoSize = true;
            this.labelCatagory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatagory.ForeColor = System.Drawing.Color.White;
            this.labelCatagory.Location = new System.Drawing.Point(16, 188);
            this.labelCatagory.Name = "labelCatagory";
            this.labelCatagory.Size = new System.Drawing.Size(96, 17);
            this.labelCatagory.TabIndex = 9;
            this.labelCatagory.Text = "Item Category";
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPrice.ForeColor = System.Drawing.Color.White;
            this.labelItemPrice.Location = new System.Drawing.Point(12, 108);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(164, 37);
            this.labelItemPrice.TabIndex = 1;
            this.labelItemPrice.Text = "ITEM PRICE";
            // 
            // dataGridViewItemPrice
            // 
            this.dataGridViewItemPrice.AllowUserToOrderColumns = true;
            this.dataGridViewItemPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItemPrice.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItemPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemPrice.Location = new System.Drawing.Point(228, 25);
            this.dataGridViewItemPrice.Name = "dataGridViewItemPrice";
            this.dataGridViewItemPrice.Size = new System.Drawing.Size(519, 413);
            this.dataGridViewItemPrice.TabIndex = 1;
            this.dataGridViewItemPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemPrice_CellClick);
            // 
            // ItemPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 516);
            this.Controls.Add(this.dataGridViewItemPrice);
            this.Controls.Add(this.panelItemPrice);
            this.Name = "ItemPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemPrice";
            this.Load += new System.EventHandler(this.ItemPrice_Load);
            this.panelItemPrice.ResumeLayout(false);
            this.panelItemPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItemPrice;
        private System.Windows.Forms.Label labelItemPrice;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxItemPriceCatagory;
        private System.Windows.Forms.Label labelCatagory;
        private System.Windows.Forms.DataGridView dataGridViewItemPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}