namespace Construction_Management_System
{
    partial class FormEmployee
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
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxEmpCatagory = new System.Windows.Forms.ComboBox();
            this.textBoxEmpAddress = new System.Windows.Forms.TextBox();
            this.labelEmpAddress = new System.Windows.Forms.Label();
            this.textBoxEmpContact = new System.Windows.Forms.TextBox();
            this.labelEmpContact = new System.Windows.Forms.Label();
            this.labelEmpCategory = new System.Windows.Forms.Label();
            this.textBoxEmpSalary = new System.Windows.Forms.TextBox();
            this.labelEmpSalary = new System.Windows.Forms.Label();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.textBoxEmpId = new System.Windows.Forms.TextBox();
            this.labelEmpId = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.buttonEmpClear = new System.Windows.Forms.Button();
            this.buttonIEmpDelete = new System.Windows.Forms.Button();
            this.buttonEmpUpdate = new System.Windows.Forms.Button();
            this.buttonEmpAdd = new System.Windows.Forms.Button();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmployee
            // 
            this.panelEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelEmployee.Controls.Add(this.pictureBox1);
            this.panelEmployee.Controls.Add(this.comboBoxEmpCatagory);
            this.panelEmployee.Controls.Add(this.textBoxEmpAddress);
            this.panelEmployee.Controls.Add(this.labelEmpAddress);
            this.panelEmployee.Controls.Add(this.textBoxEmpContact);
            this.panelEmployee.Controls.Add(this.labelEmpContact);
            this.panelEmployee.Controls.Add(this.labelEmpCategory);
            this.panelEmployee.Controls.Add(this.textBoxEmpSalary);
            this.panelEmployee.Controls.Add(this.labelEmpSalary);
            this.panelEmployee.Controls.Add(this.textBoxEmpName);
            this.panelEmployee.Controls.Add(this.labelEmpName);
            this.panelEmployee.Controls.Add(this.textBoxEmpId);
            this.panelEmployee.Controls.Add(this.labelEmpId);
            this.panelEmployee.Controls.Add(this.labelEmployee);
            this.panelEmployee.Location = new System.Drawing.Point(0, 0);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(200, 522);
            this.panelEmployee.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Construction_Management_System.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxEmpCatagory
            // 
            this.comboBoxEmpCatagory.FormattingEnabled = true;
            this.comboBoxEmpCatagory.Location = new System.Drawing.Point(12, 329);
            this.comboBoxEmpCatagory.Name = "comboBoxEmpCatagory";
            this.comboBoxEmpCatagory.Size = new System.Drawing.Size(169, 21);
            this.comboBoxEmpCatagory.TabIndex = 3;
            this.comboBoxEmpCatagory.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpCatagory_SelectedIndexChanged);
            // 
            // textBoxEmpAddress
            // 
            this.textBoxEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEmpAddress.Location = new System.Drawing.Point(12, 428);
            this.textBoxEmpAddress.Multiline = true;
            this.textBoxEmpAddress.Name = "textBoxEmpAddress";
            this.textBoxEmpAddress.Size = new System.Drawing.Size(169, 52);
            this.textBoxEmpAddress.TabIndex = 5;
            // 
            // labelEmpAddress
            // 
            this.labelEmpAddress.AutoSize = true;
            this.labelEmpAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpAddress.ForeColor = System.Drawing.Color.White;
            this.labelEmpAddress.Location = new System.Drawing.Point(9, 408);
            this.labelEmpAddress.Name = "labelEmpAddress";
            this.labelEmpAddress.Size = new System.Drawing.Size(57, 17);
            this.labelEmpAddress.TabIndex = 21;
            this.labelEmpAddress.Text = "Address";
            // 
            // textBoxEmpContact
            // 
            this.textBoxEmpContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEmpContact.Location = new System.Drawing.Point(12, 373);
            this.textBoxEmpContact.Name = "textBoxEmpContact";
            this.textBoxEmpContact.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmpContact.TabIndex = 4;
            // 
            // labelEmpContact
            // 
            this.labelEmpContact.AutoSize = true;
            this.labelEmpContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpContact.ForeColor = System.Drawing.Color.White;
            this.labelEmpContact.Location = new System.Drawing.Point(9, 353);
            this.labelEmpContact.Name = "labelEmpContact";
            this.labelEmpContact.Size = new System.Drawing.Size(55, 17);
            this.labelEmpContact.TabIndex = 19;
            this.labelEmpContact.Text = "Contact";
            // 
            // labelEmpCategory
            // 
            this.labelEmpCategory.AutoSize = true;
            this.labelEmpCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpCategory.ForeColor = System.Drawing.Color.White;
            this.labelEmpCategory.Location = new System.Drawing.Point(9, 295);
            this.labelEmpCategory.Name = "labelEmpCategory";
            this.labelEmpCategory.Size = new System.Drawing.Size(128, 17);
            this.labelEmpCategory.TabIndex = 17;
            this.labelEmpCategory.Text = "Employee Category";
            // 
            // textBoxEmpSalary
            // 
            this.textBoxEmpSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEmpSalary.Location = new System.Drawing.Point(12, 263);
            this.textBoxEmpSalary.Name = "textBoxEmpSalary";
            this.textBoxEmpSalary.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmpSalary.TabIndex = 2;
            // 
            // labelEmpSalary
            // 
            this.labelEmpSalary.AutoSize = true;
            this.labelEmpSalary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpSalary.ForeColor = System.Drawing.Color.White;
            this.labelEmpSalary.Location = new System.Drawing.Point(9, 243);
            this.labelEmpSalary.Name = "labelEmpSalary";
            this.labelEmpSalary.Size = new System.Drawing.Size(46, 17);
            this.labelEmpSalary.TabIndex = 15;
            this.labelEmpSalary.Text = "Salary";
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEmpName.Location = new System.Drawing.Point(12, 206);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmpName.TabIndex = 1;
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpName.ForeColor = System.Drawing.Color.White;
            this.labelEmpName.Location = new System.Drawing.Point(9, 186);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(108, 17);
            this.labelEmpName.TabIndex = 13;
            this.labelEmpName.Text = "Employee Name";
            // 
            // textBoxEmpId
            // 
            this.textBoxEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxEmpId.Location = new System.Drawing.Point(12, 153);
            this.textBoxEmpId.Name = "textBoxEmpId";
            this.textBoxEmpId.Size = new System.Drawing.Size(169, 20);
            this.textBoxEmpId.TabIndex = 0;
            // 
            // labelEmpId
            // 
            this.labelEmpId.AutoSize = true;
            this.labelEmpId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpId.ForeColor = System.Drawing.Color.White;
            this.labelEmpId.Location = new System.Drawing.Point(9, 133);
            this.labelEmpId.Name = "labelEmpId";
            this.labelEmpId.Size = new System.Drawing.Size(86, 17);
            this.labelEmpId.TabIndex = 11;
            this.labelEmpId.Text = "Employee ID";
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.ForeColor = System.Drawing.Color.White;
            this.labelEmployee.Location = new System.Drawing.Point(21, 70);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(150, 37);
            this.labelEmployee.TabIndex = 0;
            this.labelEmployee.Text = "EMPLOYEE";
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Location = new System.Drawing.Point(224, 21);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.Size = new System.Drawing.Size(522, 402);
            this.dataGridViewEmp.TabIndex = 1;
            this.dataGridViewEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmp_CellClick);
            // 
            // buttonEmpClear
            // 
            this.buttonEmpClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonEmpClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpClear.Location = new System.Drawing.Point(635, 441);
            this.buttonEmpClear.Name = "buttonEmpClear";
            this.buttonEmpClear.Size = new System.Drawing.Size(96, 37);
            this.buttonEmpClear.TabIndex = 9;
            this.buttonEmpClear.Text = "CLEAR";
            this.buttonEmpClear.UseVisualStyleBackColor = false;
            this.buttonEmpClear.Click += new System.EventHandler(this.buttonEmpClear_Click);
            // 
            // buttonIEmpDelete
            // 
            this.buttonIEmpDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonIEmpDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIEmpDelete.Location = new System.Drawing.Point(509, 441);
            this.buttonIEmpDelete.Name = "buttonIEmpDelete";
            this.buttonIEmpDelete.Size = new System.Drawing.Size(96, 37);
            this.buttonIEmpDelete.TabIndex = 8;
            this.buttonIEmpDelete.Text = "DELETE";
            this.buttonIEmpDelete.UseVisualStyleBackColor = false;
            this.buttonIEmpDelete.Click += new System.EventHandler(this.buttonIEmpDelete_Click);
            // 
            // buttonEmpUpdate
            // 
            this.buttonEmpUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEmpUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpUpdate.Location = new System.Drawing.Point(381, 441);
            this.buttonEmpUpdate.Name = "buttonEmpUpdate";
            this.buttonEmpUpdate.Size = new System.Drawing.Size(96, 37);
            this.buttonEmpUpdate.TabIndex = 7;
            this.buttonEmpUpdate.Text = "UPDATE";
            this.buttonEmpUpdate.UseVisualStyleBackColor = false;
            this.buttonEmpUpdate.Click += new System.EventHandler(this.buttonEmpUpdate_Click);
            // 
            // buttonEmpAdd
            // 
            this.buttonEmpAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEmpAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpAdd.Location = new System.Drawing.Point(243, 441);
            this.buttonEmpAdd.Name = "buttonEmpAdd";
            this.buttonEmpAdd.Size = new System.Drawing.Size(96, 37);
            this.buttonEmpAdd.TabIndex = 6;
            this.buttonEmpAdd.Text = "ADD";
            this.buttonEmpAdd.UseVisualStyleBackColor = false;
            this.buttonEmpAdd.Click += new System.EventHandler(this.buttonEmpAdd_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 516);
            this.Controls.Add(this.buttonEmpClear);
            this.Controls.Add(this.buttonIEmpDelete);
            this.Controls.Add(this.buttonEmpUpdate);
            this.Controls.Add(this.buttonEmpAdd);
            this.Controls.Add(this.dataGridViewEmp);
            this.Controls.Add(this.panelEmployee);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.TextBox textBoxEmpAddress;
        private System.Windows.Forms.Label labelEmpAddress;
        private System.Windows.Forms.TextBox textBoxEmpContact;
        private System.Windows.Forms.Label labelEmpContact;
        private System.Windows.Forms.Label labelEmpCategory;
        private System.Windows.Forms.TextBox textBoxEmpSalary;
        private System.Windows.Forms.Label labelEmpSalary;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.TextBox textBoxEmpId;
        private System.Windows.Forms.Label labelEmpId;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.Button buttonEmpClear;
        private System.Windows.Forms.Button buttonIEmpDelete;
        private System.Windows.Forms.Button buttonEmpUpdate;
        private System.Windows.Forms.Button buttonEmpAdd;
        private System.Windows.Forms.ComboBox comboBoxEmpCatagory;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}