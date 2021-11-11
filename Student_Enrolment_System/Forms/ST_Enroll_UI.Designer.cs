namespace Student_Enrolment_System
{
    partial class ST_Enroll_UI
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_regNumber = new System.Windows.Forms.Label();
            this.lbl_studentName = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_courses = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txt_regNumber = new System.Windows.Forms.TextBox();
            this.txt_studentName = new System.Windows.Forms.TextBox();
            this.pik_date = new System.Windows.Forms.DateTimePicker();
            this.rdbtn_male = new System.Windows.Forms.RadioButton();
            this.rdbtn_female = new System.Windows.Forms.RadioButton();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.cmb_courses = new System.Windows.Forms.ComboBox();
            this.txt_age = new System.Windows.Forms.Label();
            this.btn_insert = new ePOSOne.btnProduct.Button_WOC();
            this.btn_delete = new ePOSOne.btnProduct.Button_WOC();
            this.btn_clear = new ePOSOne.btnProduct.Button_WOC();
            this.btn_exit = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(164, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(327, 29);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Student Enrollment System";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_regNumber
            // 
            this.lbl_regNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_regNumber.AutoSize = true;
            this.lbl_regNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regNumber.Location = new System.Drawing.Point(54, 83);
            this.lbl_regNumber.Name = "lbl_regNumber";
            this.lbl_regNumber.Size = new System.Drawing.Size(188, 25);
            this.lbl_regNumber.TabIndex = 2;
            this.lbl_regNumber.Text = "Registration Number";
            // 
            // lbl_studentName
            // 
            this.lbl_studentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_studentName.AutoSize = true;
            this.lbl_studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_studentName.Location = new System.Drawing.Point(54, 122);
            this.lbl_studentName.Name = "lbl_studentName";
            this.lbl_studentName.Size = new System.Drawing.Size(137, 25);
            this.lbl_studentName.TabIndex = 3;
            this.lbl_studentName.Text = "Student Name";
            // 
            // lbl_dob
            // 
            this.lbl_dob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.Location = new System.Drawing.Point(54, 161);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(118, 25);
            this.lbl_dob.TabIndex = 4;
            this.lbl_dob.Text = "Date of Birth";
            // 
            // lbl_gender
            // 
            this.lbl_gender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(54, 200);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(77, 25);
            this.lbl_gender.TabIndex = 5;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_contact
            // 
            this.lbl_contact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.Location = new System.Drawing.Point(54, 236);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(154, 25);
            this.lbl_contact.TabIndex = 6;
            this.lbl_contact.Text = "Contact Number";
            // 
            // lbl_courses
            // 
            this.lbl_courses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_courses.AutoSize = true;
            this.lbl_courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_courses.Location = new System.Drawing.Point(54, 271);
            this.lbl_courses.Name = "lbl_courses";
            this.lbl_courses.Size = new System.Drawing.Size(172, 25);
            this.lbl_courses.TabIndex = 7;
            this.lbl_courses.Text = "Course Enrolled in";
            // 
            // lbl_age
            // 
            this.lbl_age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(497, 152);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(48, 25);
            this.lbl_age.TabIndex = 8;
            this.lbl_age.Text = "Age";
            // 
            // txt_regNumber
            // 
            this.txt_regNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_regNumber.Location = new System.Drawing.Point(281, 83);
            this.txt_regNumber.Multiline = true;
            this.txt_regNumber.Name = "txt_regNumber";
            this.txt_regNumber.Size = new System.Drawing.Size(210, 21);
            this.txt_regNumber.TabIndex = 9;
            this.txt_regNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_regNumber_KeyPress);
            this.txt_regNumber.Leave += new System.EventHandler(this.txt_regNumber_Leave);
            // 
            // txt_studentName
            // 
            this.txt_studentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_studentName.Location = new System.Drawing.Point(281, 120);
            this.txt_studentName.Multiline = true;
            this.txt_studentName.Name = "txt_studentName";
            this.txt_studentName.Size = new System.Drawing.Size(210, 21);
            this.txt_studentName.TabIndex = 10;
            // 
            // pik_date
            // 
            this.pik_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pik_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pik_date.Location = new System.Drawing.Point(281, 157);
            this.pik_date.Name = "pik_date";
            this.pik_date.Size = new System.Drawing.Size(210, 20);
            this.pik_date.TabIndex = 11;
            this.pik_date.CloseUp += new System.EventHandler(this.pik_date_CloseUp);
            // 
            // rdbtn_male
            // 
            this.rdbtn_male.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtn_male.AutoSize = true;
            this.rdbtn_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_male.Location = new System.Drawing.Point(281, 200);
            this.rdbtn_male.Name = "rdbtn_male";
            this.rdbtn_male.Size = new System.Drawing.Size(73, 29);
            this.rdbtn_male.TabIndex = 12;
            this.rdbtn_male.TabStop = true;
            this.rdbtn_male.Text = "Male";
            this.rdbtn_male.UseVisualStyleBackColor = true;
            // 
            // rdbtn_female
            // 
            this.rdbtn_female.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtn_female.AutoSize = true;
            this.rdbtn_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_female.Location = new System.Drawing.Point(406, 200);
            this.rdbtn_female.Name = "rdbtn_female";
            this.rdbtn_female.Size = new System.Drawing.Size(95, 29);
            this.rdbtn_female.TabIndex = 13;
            this.rdbtn_female.TabStop = true;
            this.rdbtn_female.Text = "Female";
            this.rdbtn_female.UseVisualStyleBackColor = true;
            // 
            // txt_contact
            // 
            this.txt_contact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contact.DataBindings.Add(new System.Windows.Forms.Binding("MaxLength", global::Student_Enrolment_System.Properties.Settings.Default, "contact", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_contact.Location = new System.Drawing.Point(281, 242);
            this.txt_contact.MaxLength = global::Student_Enrolment_System.Properties.Settings.Default.contact;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(210, 20);
            this.txt_contact.TabIndex = 14;
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            // 
            // cmb_courses
            // 
            this.cmb_courses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_courses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_courses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_courses.FormattingEnabled = true;
            this.cmb_courses.Items.AddRange(new object[] {
            "Select Course",
            "HND - COM ",
            "HND – BM ",
            "Dip - IT ",
            "Dip - English ",
            "Dip - BM"});
            this.cmb_courses.Location = new System.Drawing.Point(281, 277);
            this.cmb_courses.Name = "cmb_courses";
            this.cmb_courses.Size = new System.Drawing.Size(210, 21);
            this.cmb_courses.TabIndex = 15;
            // 
            // txt_age
            // 
            this.txt_age.AutoSize = true;
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(551, 152);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(23, 25);
            this.txt_age.TabIndex = 16;
            this.txt_age.Text = "0";
            this.txt_age.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_insert.BorderColor = System.Drawing.Color.Black;
            this.btn_insert.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.btn_insert.FlatAppearance.BorderSize = 0;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(247, 337);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_insert.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btn_insert.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_insert.Size = new System.Drawing.Size(160, 42);
            this.btn_insert.TabIndex = 25;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.TextColor = System.Drawing.Color.Black;
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(247, 402);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btn_delete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_delete.Size = new System.Drawing.Size(160, 42);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.TextColor = System.Drawing.Color.Black;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clear.BorderColor = System.Drawing.Color.Black;
            this.btn_clear.ButtonColor = System.Drawing.SystemColors.Highlight;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(247, 465);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_clear.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btn_clear.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_clear.Size = new System.Drawing.Size(160, 42);
            this.btn_clear.TabIndex = 27;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.TextColor = System.Drawing.Color.Black;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exit.BorderColor = System.Drawing.Color.Black;
            this.btn_exit.ButtonColor = System.Drawing.Color.Red;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(464, 465);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_exit.OnHoverButtonColor = System.Drawing.Color.OrangeRed;
            this.btn_exit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_exit.Size = new System.Drawing.Size(160, 42);
            this.btn_exit.TabIndex = 28;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.TextColor = System.Drawing.Color.Black;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ST_Enroll_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(655, 552);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.cmb_courses);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.rdbtn_female);
            this.Controls.Add(this.rdbtn_male);
            this.Controls.Add(this.pik_date);
            this.Controls.Add(this.txt_studentName);
            this.Controls.Add(this.txt_regNumber);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_courses);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_studentName);
            this.Controls.Add(this.lbl_regNumber);
            this.Controls.Add(this.lbl_title);
            this.MinimumSize = new System.Drawing.Size(671, 591);
            this.Name = "ST_Enroll_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Enroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_regNumber;
        private System.Windows.Forms.Label lbl_studentName;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_courses;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label txt_age;
        internal System.Windows.Forms.TextBox txt_regNumber;
        internal System.Windows.Forms.TextBox txt_studentName;
        internal System.Windows.Forms.RadioButton rdbtn_male;
        internal System.Windows.Forms.RadioButton rdbtn_female;
        internal System.Windows.Forms.TextBox txt_contact;
        internal System.Windows.Forms.ComboBox cmb_courses;
        internal System.Windows.Forms.DateTimePicker pik_date;
        private ePOSOne.btnProduct.Button_WOC btn_insert;
        private ePOSOne.btnProduct.Button_WOC btn_delete;
        private ePOSOne.btnProduct.Button_WOC btn_clear;
        private ePOSOne.btnProduct.Button_WOC btn_exit;
    }
}

