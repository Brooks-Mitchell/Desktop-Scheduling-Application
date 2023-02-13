namespace C969
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reportPic = new System.Windows.Forms.PictureBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.displayUserTime = new System.Windows.Forms.Label();
            this.hello_user = new System.Windows.Forms.Label();
            this.calendarDGV = new System.Windows.Forms.DataGridView();
            this.customerPic = new System.Windows.Forms.PictureBox();
            this.reportBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.aptTypeField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchField = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // reportPic
            // 
            this.reportPic.BackColor = System.Drawing.Color.Transparent;
            this.reportPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportPic.Image = ((System.Drawing.Image)(resources.GetObject("reportPic.Image")));
            this.reportPic.Location = new System.Drawing.Point(12, 279);
            this.reportPic.Name = "reportPic";
            this.reportPic.Size = new System.Drawing.Size(126, 81);
            this.reportPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reportPic.TabIndex = 0;
            this.reportPic.TabStop = false;
            this.reportPic.Click += new System.EventHandler(this.reportPic_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // displayUserTime
            // 
            this.displayUserTime.AutoSize = true;
            this.displayUserTime.BackColor = System.Drawing.Color.Transparent;
            this.displayUserTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayUserTime.ForeColor = System.Drawing.Color.White;
            this.displayUserTime.Location = new System.Drawing.Point(668, 13);
            this.displayUserTime.Name = "displayUserTime";
            this.displayUserTime.Size = new System.Drawing.Size(214, 18);
            this.displayUserTime.TabIndex = 1;
            this.displayUserTime.Text = "* shows user time zone*";
            // 
            // hello_user
            // 
            this.hello_user.AutoSize = true;
            this.hello_user.BackColor = System.Drawing.Color.Transparent;
            this.hello_user.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello_user.ForeColor = System.Drawing.Color.White;
            this.hello_user.Location = new System.Drawing.Point(1056, 13);
            this.hello_user.Name = "hello_user";
            this.hello_user.Size = new System.Drawing.Size(120, 18);
            this.hello_user.TabIndex = 2;
            this.hello_user.Text = "*shows user*";
            // 
            // calendarDGV
            // 
            this.calendarDGV.AllowUserToAddRows = false;
            this.calendarDGV.AllowUserToDeleteRows = false;
            this.calendarDGV.AllowUserToResizeColumns = false;
            this.calendarDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Teal;
            this.calendarDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.calendarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.calendarDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calendarDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calendarDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.calendarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarDGV.EnableHeadersVisualStyles = false;
            this.calendarDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calendarDGV.Location = new System.Drawing.Point(426, 83);
            this.calendarDGV.MultiSelect = false;
            this.calendarDGV.Name = "calendarDGV";
            this.calendarDGV.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.calendarDGV.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.calendarDGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.calendarDGV.Size = new System.Drawing.Size(826, 346);
            this.calendarDGV.TabIndex = 3;
            this.calendarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendarDGV_CellContentClick);
            // 
            // customerPic
            // 
            this.customerPic.BackColor = System.Drawing.Color.Transparent;
            this.customerPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerPic.Image = ((System.Drawing.Image)(resources.GetObject("customerPic.Image")));
            this.customerPic.Location = new System.Drawing.Point(12, 74);
            this.customerPic.Name = "customerPic";
            this.customerPic.Size = new System.Drawing.Size(126, 81);
            this.customerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerPic.TabIndex = 4;
            this.customerPic.TabStop = false;
            this.customerPic.Click += new System.EventHandler(this.customerPic_Click);
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
            this.reportBtn.Location = new System.Drawing.Point(12, 366);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(126, 23);
            this.reportBtn.TabIndex = 8;
            this.reportBtn.Text = "REPORTS";
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.Transparent;
            this.customerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerBtn.FlatAppearance.BorderSize = 0;
            this.customerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.White;
            this.customerBtn.Location = new System.Drawing.Point(4, 161);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(134, 23);
            this.customerBtn.TabIndex = 9;
            this.customerBtn.Text = "CUSTOMERS";
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // dateComboBox
            // 
            this.dateComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dateComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateComboBox.ForeColor = System.Drawing.Color.White;
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(643, 54);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(121, 26);
            this.dateComboBox.TabIndex = 10;
            this.dateComboBox.SelectedIndexChanged += new System.EventHandler(this.dateComboBox_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Location = new System.Drawing.Point(623, 437);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(151, 28);
            this.nameBox.TabIndex = 14;
            this.nameBox.SelectedIndexChanged += new System.EventHandler(this.nameBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(449, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Customer Name:";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(814, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Appointment Type:";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(565, 494);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(239, 27);
            this.dateTimePicker.TabIndex = 19;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(443, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 31);
            this.button3.TabIndex = 20;
            this.button3.Text = "Start Time:";
            this.button3.UseVisualStyleBackColor = false;
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
            this.saveBtn.Location = new System.Drawing.Point(1117, 547);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 38);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // aptTypeField
            // 
            this.aptTypeField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aptTypeField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aptTypeField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aptTypeField.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptTypeField.ForeColor = System.Drawing.Color.White;
            this.aptTypeField.FormattingEnabled = true;
            this.aptTypeField.Location = new System.Drawing.Point(999, 439);
            this.aptTypeField.Name = "aptTypeField";
            this.aptTypeField.Size = new System.Drawing.Size(188, 26);
            this.aptTypeField.TabIndex = 33;
            this.aptTypeField.SelectedIndexChanged += new System.EventHandler(this.aptTypeField_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "APPOINTMENTS";
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
            this.cancelBtn.Location = new System.Drawing.Point(1117, 601);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(105, 38);
            this.cancelBtn.TabIndex = 38;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            this.deleteBtn.Location = new System.Drawing.Point(858, 590);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 38);
            this.deleteBtn.TabIndex = 37;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.editBtn.Location = new System.Drawing.Point(717, 590);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(105, 38);
            this.editBtn.TabIndex = 36;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addNewBtn
            // 
            this.addNewBtn.BackColor = System.Drawing.Color.Teal;
            this.addNewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewBtn.FlatAppearance.BorderSize = 0;
            this.addNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBtn.ForeColor = System.Drawing.Color.White;
            this.addNewBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addNewBtn.Location = new System.Drawing.Point(453, 590);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(222, 38);
            this.addNewBtn.TabIndex = 35;
            this.addNewBtn.Text = "Add New Appointment";
            this.addNewBtn.UseVisualStyleBackColor = false;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(823, 494);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 31);
            this.button4.TabIndex = 40;
            this.button4.Text = "End Time:";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(961, 494);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(261, 27);
            this.endTimePicker.TabIndex = 39;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // searchField
            // 
            this.searchField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchField.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.ForeColor = System.Drawing.Color.White;
            this.searchField.Location = new System.Drawing.Point(867, 50);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(188, 27);
            this.searchField.TabIndex = 41;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Teal;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchBtn.Location = new System.Drawing.Point(1082, 50);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(105, 27);
            this.searchBtn.TabIndex = 42;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aptTypeField);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dateComboBox);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.customerPic);
            this.Controls.Add(this.calendarDGV);
            this.Controls.Add(this.hello_user);
            this.Controls.Add(this.displayUserTime);
            this.Controls.Add(this.reportPic);
            this.Name = "home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.reportPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox reportPic;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Label displayUserTime;
        private System.Windows.Forms.Label hello_user;
        private System.Windows.Forms.DataGridView calendarDGV;
        private System.Windows.Forms.PictureBox customerPic;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox aptTypeField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button searchBtn;
    }
}

