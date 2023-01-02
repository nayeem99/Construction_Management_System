namespace Construction_Management_System.Gui_Design
{
    partial class Manager_ItemCatagory
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
            this.panelCatagory = new System.Windows.Forms.Panel();
            this.pictureBoxCatagory = new System.Windows.Forms.PictureBox();
            this.labelCatagoryName = new System.Windows.Forms.Label();
            this.labelCatagoryId = new System.Windows.Forms.Label();
            this.textBoxCatagoryName = new System.Windows.Forms.TextBox();
            this.textBoxCatagoryId = new System.Windows.Forms.TextBox();
            this.labelCatagory = new System.Windows.Forms.Label();
            this.dataGridViewCatagory = new System.Windows.Forms.DataGridView();
            this.buttonCatagoryClear = new System.Windows.Forms.Button();
            this.buttonCatagoryDelete = new System.Windows.Forms.Button();
            this.buttonCatagoryUpdate = new System.Windows.Forms.Button();
            this.buttonICatagoryAdd = new System.Windows.Forms.Button();
            this.panelCatagory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatagory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatagory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCatagory
            // 
            this.panelCatagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelCatagory.Controls.Add(this.pictureBoxCatagory);
            this.panelCatagory.Controls.Add(this.labelCatagoryName);
            this.panelCatagory.Controls.Add(this.labelCatagoryId);
            this.panelCatagory.Controls.Add(this.textBoxCatagoryName);
            this.panelCatagory.Controls.Add(this.textBoxCatagoryId);
            this.panelCatagory.Controls.Add(this.labelCatagory);
            this.panelCatagory.Location = new System.Drawing.Point(-3, -4);
            this.panelCatagory.Name = "panelCatagory";
            this.panelCatagory.Size = new System.Drawing.Size(216, 520);
            this.panelCatagory.TabIndex = 0;
            // 
            // pictureBoxCatagory
            // 
            this.pictureBoxCatagory.Image = global::Construction_Management_System.Properties.Resources.arrow;
            this.pictureBoxCatagory.Location = new System.Drawing.Point(24, 26);
            this.pictureBoxCatagory.Name = "pictureBoxCatagory";
            this.pictureBoxCatagory.Size = new System.Drawing.Size(39, 43);
            this.pictureBoxCatagory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCatagory.TabIndex = 13;
            this.pictureBoxCatagory.TabStop = false;
            this.pictureBoxCatagory.Click += new System.EventHandler(this.pictureBoxCatagory_Click);
            // 
            // labelCatagoryName
            // 
            this.labelCatagoryName.AutoSize = true;
            this.labelCatagoryName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatagoryName.ForeColor = System.Drawing.Color.White;
            this.labelCatagoryName.Location = new System.Drawing.Point(32, 245);
            this.labelCatagoryName.Name = "labelCatagoryName";
            this.labelCatagoryName.Size = new System.Drawing.Size(104, 17);
            this.labelCatagoryName.TabIndex = 9;
            this.labelCatagoryName.Text = "Category Name";
            // 
            // labelCatagoryId
            // 
            this.labelCatagoryId.AutoSize = true;
            this.labelCatagoryId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatagoryId.ForeColor = System.Drawing.Color.White;
            this.labelCatagoryId.Location = new System.Drawing.Point(32, 190);
            this.labelCatagoryId.Name = "labelCatagoryId";
            this.labelCatagoryId.Size = new System.Drawing.Size(82, 17);
            this.labelCatagoryId.TabIndex = 8;
            this.labelCatagoryId.Text = "Catagory ID";
            // 
            // textBoxCatagoryName
            // 
            this.textBoxCatagoryName.Location = new System.Drawing.Point(35, 265);
            this.textBoxCatagoryName.Name = "textBoxCatagoryName";
            this.textBoxCatagoryName.Size = new System.Drawing.Size(150, 20);
            this.textBoxCatagoryName.TabIndex = 1;
            // 
            // textBoxCatagoryId
            // 
            this.textBoxCatagoryId.Location = new System.Drawing.Point(35, 210);
            this.textBoxCatagoryId.Name = "textBoxCatagoryId";
            this.textBoxCatagoryId.Size = new System.Drawing.Size(150, 20);
            this.textBoxCatagoryId.TabIndex = 0;
            // 
            // labelCatagory
            // 
            this.labelCatagory.AutoSize = true;
            this.labelCatagory.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatagory.ForeColor = System.Drawing.Color.White;
            this.labelCatagory.Location = new System.Drawing.Point(28, 129);
            this.labelCatagory.Name = "labelCatagory";
            this.labelCatagory.Size = new System.Drawing.Size(157, 37);
            this.labelCatagory.TabIndex = 0;
            this.labelCatagory.Text = "CATAGORY";
            // 
            // dataGridViewCatagory
            // 
            this.dataGridViewCatagory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCatagory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatagory.Location = new System.Drawing.Point(248, 34);
            this.dataGridViewCatagory.Name = "dataGridViewCatagory";
            this.dataGridViewCatagory.Size = new System.Drawing.Size(496, 380);
            this.dataGridViewCatagory.TabIndex = 1;
            this.dataGridViewCatagory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatagory_CellClick);
            // 
            // buttonCatagoryClear
            // 
            this.buttonCatagoryClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonCatagoryClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCatagoryClear.Location = new System.Drawing.Point(645, 445);
            this.buttonCatagoryClear.Name = "buttonCatagoryClear";
            this.buttonCatagoryClear.Size = new System.Drawing.Size(96, 37);
            this.buttonCatagoryClear.TabIndex = 9;
            this.buttonCatagoryClear.Text = "CLEAR";
            this.buttonCatagoryClear.UseVisualStyleBackColor = false;
            this.buttonCatagoryClear.Click += new System.EventHandler(this.buttonCatagoryClear_Click);
            // 
            // buttonCatagoryDelete
            // 
            this.buttonCatagoryDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonCatagoryDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCatagoryDelete.Location = new System.Drawing.Point(519, 445);
            this.buttonCatagoryDelete.Name = "buttonCatagoryDelete";
            this.buttonCatagoryDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonCatagoryDelete.TabIndex = 8;
            this.buttonCatagoryDelete.Text = "DELETE";
            this.buttonCatagoryDelete.UseVisualStyleBackColor = false;
            this.buttonCatagoryDelete.Click += new System.EventHandler(this.buttonCatagoryDelete_Click);
            // 
            // buttonCatagoryUpdate
            // 
            this.buttonCatagoryUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonCatagoryUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCatagoryUpdate.Location = new System.Drawing.Point(391, 445);
            this.buttonCatagoryUpdate.Name = "buttonCatagoryUpdate";
            this.buttonCatagoryUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonCatagoryUpdate.TabIndex = 7;
            this.buttonCatagoryUpdate.Text = "UPDATE";
            this.buttonCatagoryUpdate.UseVisualStyleBackColor = false;
            this.buttonCatagoryUpdate.Click += new System.EventHandler(this.buttonCatagoryUpdate_Click);
            // 
            // buttonICatagoryAdd
            // 
            this.buttonICatagoryAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonICatagoryAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonICatagoryAdd.Location = new System.Drawing.Point(253, 445);
            this.buttonICatagoryAdd.Name = "buttonICatagoryAdd";
            this.buttonICatagoryAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonICatagoryAdd.TabIndex = 6;
            this.buttonICatagoryAdd.Text = "ADD";
            this.buttonICatagoryAdd.UseVisualStyleBackColor = false;
            this.buttonICatagoryAdd.Click += new System.EventHandler(this.buttonICatagoryAdd_Click);
            // 
            // Manager_ItemCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 516);
            this.Controls.Add(this.buttonCatagoryClear);
            this.Controls.Add(this.buttonCatagoryDelete);
            this.Controls.Add(this.buttonCatagoryUpdate);
            this.Controls.Add(this.buttonICatagoryAdd);
            this.Controls.Add(this.dataGridViewCatagory);
            this.Controls.Add(this.panelCatagory);
            this.Name = "Manager_ItemCatagory";
            this.Text = "ItemCatagory";
            this.Load += new System.EventHandler(this.ItemCatagory_Load);
            this.panelCatagory.ResumeLayout(false);
            this.panelCatagory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatagory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatagory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCatagory;
        private System.Windows.Forms.Label labelCatagory;
        private System.Windows.Forms.TextBox textBoxCatagoryName;
        private System.Windows.Forms.TextBox textBoxCatagoryId;
        private System.Windows.Forms.DataGridView dataGridViewCatagory;
        private System.Windows.Forms.Button buttonCatagoryClear;
        private System.Windows.Forms.Button buttonCatagoryDelete;
        private System.Windows.Forms.Button buttonCatagoryUpdate;
        private System.Windows.Forms.Button buttonICatagoryAdd;
        private System.Windows.Forms.Label labelCatagoryName;
        private System.Windows.Forms.Label labelCatagoryId;
        private System.Windows.Forms.PictureBox pictureBoxCatagory;
    }
}