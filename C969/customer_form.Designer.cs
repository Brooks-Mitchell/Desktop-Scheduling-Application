namespace C969
{
    partial class customer_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer_form));
            this.customerDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            this.homeImg = new System.Windows.Forms.PictureBox();
            this.reportBtn = new System.Windows.Forms.Button();
            this.customerPic = new System.Windows.Forms.PictureBox();
            this.custIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.custPhoneText = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.custCityText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.custCountryText = new System.Windows.Forms.TextBox();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.custNameText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDGV
            // 
            this.customerDGV.AllowUserToAddRows = false;
            this.customerDGV.AllowUserToDeleteRows = false;
            this.customerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerDGV.EnableHeadersVisualStyles = false;
            this.customerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerDGV.Location = new System.Drawing.Point(362, 52);
            this.customerDGV.Name = "customerDGV";
            this.customerDGV.ReadOnly = true;
            this.customerDGV.RowHeadersVisible = false;
            this.customerDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.customerDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.customerDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.customerDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.customerDGV.Size = new System.Drawing.Size(779, 346);
            this.customerDGV.TabIndex = 0;
            this.customerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(670, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "CUSTOMERS";
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(16, 139);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(134, 23);
            this.homeBtn.TabIndex = 17;
            this.homeBtn.Text = "HOME";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // homeImg
            // 
            this.homeImg.BackColor = System.Drawing.Color.Transparent;
            this.homeImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeImg.Image = ((System.Drawing.Image)(resources.GetObject("homeImg.Image")));
            this.homeImg.Location = new System.Drawing.Point(24, 52);
            this.homeImg.Name = "homeImg";
            this.homeImg.Size = new System.Drawing.Size(126, 81);
            this.homeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeImg.TabIndex = 16;
            this.homeImg.TabStop = false;
            this.homeImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.White;
            this.reportBtn.Location = new System.Drawing.Point(16, 334);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(134, 23);
            this.reportBtn.TabIndex = 15;
            this.reportBtn.Text = "REPORTS";
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // customerPic
            // 
            this.customerPic.BackColor = System.Drawing.Color.Transparent;
            this.customerPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerPic.Image = ((System.Drawing.Image)(resources.GetObject("customerPic.Image")));
            this.customerPic.Location = new System.Drawing.Point(24, 247);
            this.customerPic.Name = "customerPic";
            this.customerPic.Size = new System.Drawing.Size(126, 81);
            this.customerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerPic.TabIndex = 14;
            this.customerPic.TabStop = false;
            this.customerPic.Click += new System.EventHandler(this.customerPic_Click);
            // 
            // custIdTextBox
            // 
            this.custIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custIdTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIdTextBox.ForeColor = System.Drawing.Color.White;
            this.custIdTextBox.Location = new System.Drawing.Point(372, 520);
            this.custIdTextBox.Name = "custIdTextBox";
            this.custIdTextBox.ReadOnly = true;
            this.custIdTextBox.Size = new System.Drawing.Size(100, 27);
            this.custIdTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(384, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cust. #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(369, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Customer Name";
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.BackColor = System.Drawing.Color.Transparent;
            this.phonelabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelabel.ForeColor = System.Drawing.Color.White;
            this.phonelabel.Location = new System.Drawing.Point(583, 423);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(82, 18);
            this.phonelabel.TabIndex = 23;
            this.phonelabel.Text = "Phone #";
            // 
            // custPhoneText
            // 
            this.custPhoneText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custPhoneText.Enabled = false;
            this.custPhoneText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custPhoneText.ForeColor = System.Drawing.Color.White;
            this.custPhoneText.Location = new System.Drawing.Point(586, 449);
            this.custPhoneText.Name = "custPhoneText";
            this.custPhoneText.Size = new System.Drawing.Size(155, 27);
            this.custPhoneText.TabIndex = 22;
            this.custPhoneText.TextChanged += new System.EventHandler(this.custPhoneText_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(797, 423);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(41, 18);
            this.cityLabel.TabIndex = 25;
            this.cityLabel.Text = "City";
            // 
            // custCityText
            // 
            this.custCityText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custCityText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custCityText.ForeColor = System.Drawing.Color.White;
            this.custCityText.Location = new System.Drawing.Point(800, 449);
            this.custCityText.Name = "custCityText";
            this.custCityText.Size = new System.Drawing.Size(148, 27);
            this.custCityText.TabIndex = 24;
            this.custCityText.TextChanged += new System.EventHandler(this.custCityText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1010, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Country";
            // 
            // custCountryText
            // 
            this.custCountryText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custCountryText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custCountryText.ForeColor = System.Drawing.Color.White;
            this.custCountryText.Location = new System.Drawing.Point(1013, 449);
            this.custCountryText.Name = "custCountryText";
            this.custCountryText.Size = new System.Drawing.Size(128, 27);
            this.custCountryText.TabIndex = 26;
            this.custCountryText.TextChanged += new System.EventHandler(this.custCountryText_TextChanged);
            // 
            // addNewBtn
            // 
            this.addNewBtn.BackColor = System.Drawing.Color.Teal;
            this.addNewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewBtn.FlatAppearance.BorderSize = 0;
            this.addNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewBtn.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.addNewBtn.ForeColor = System.Drawing.Color.White;
            this.addNewBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addNewBtn.Location = new System.Drawing.Point(372, 590);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(222, 38);
            this.addNewBtn.TabIndex = 28;
            this.addNewBtn.Text = "Add New Customer";
            this.addNewBtn.UseVisualStyleBackColor = false;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Teal;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.editBtn.Location = new System.Drawing.Point(636, 590);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(105, 38);
            this.editBtn.TabIndex = 29;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Teal;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteBtn.Location = new System.Drawing.Point(777, 590);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 38);
            this.deleteBtn.TabIndex = 30;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Teal;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveBtn.Location = new System.Drawing.Point(1036, 540);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 38);
            this.saveBtn.TabIndex = 31;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Teal;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelBtn.Location = new System.Drawing.Point(1036, 601);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(105, 38);
            this.cancelBtn.TabIndex = 32;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // custNameText
            // 
            this.custNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custNameText.Enabled = false;
            this.custNameText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameText.ForeColor = System.Drawing.Color.White;
            this.custNameText.Location = new System.Drawing.Point(372, 449);
            this.custNameText.Name = "custNameText";
            this.custNameText.Size = new System.Drawing.Size(155, 27);
            this.custNameText.TabIndex = 33;
            this.custNameText.TextChanged += new System.EventHandler(this.custNameText_TextChanged);
            // 
            // customer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.custNameText);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.custCountryText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.custCityText);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.custPhoneText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custIdTextBox);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.homeImg);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.customerPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerDGV);
            this.Name = "customer_form";
            this.Text = "customer_form";
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.PictureBox homeImg;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.PictureBox customerPic;
        private System.Windows.Forms.TextBox custIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.TextBox custPhoneText;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox custCityText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox custCountryText;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox custNameText;
    }
}