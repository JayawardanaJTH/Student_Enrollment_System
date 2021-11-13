namespace Student_Enrolment_System.Forms
{
    partial class CourseFeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseFeePage));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_presentMark = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.cmb_regno = new System.Windows.Forms.ComboBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_regno = new System.Windows.Forms.Label();
            this.btn_saveFee = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_exit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_home = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(174, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(307, 29);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Course Fee Management";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox.Controls.Add(this.txt_total);
            this.groupBox.Controls.Add(this.lbl_presentMark);
            this.groupBox.Controls.Add(this.txt_discount);
            this.groupBox.Controls.Add(this.txt_amount);
            this.groupBox.Controls.Add(this.cmb_regno);
            this.groupBox.Controls.Add(this.lbl_total);
            this.groupBox.Controls.Add(this.lbl_discount);
            this.groupBox.Controls.Add(this.lbl_amount);
            this.groupBox.Controls.Add(this.lbl_regno);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(51, 72);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(550, 252);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Payment Details";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(291, 168);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(180, 26);
            this.txt_total.TabIndex = 8;
            // 
            // lbl_presentMark
            // 
            this.lbl_presentMark.AutoSize = true;
            this.lbl_presentMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presentMark.Location = new System.Drawing.Point(349, 132);
            this.lbl_presentMark.Name = "lbl_presentMark";
            this.lbl_presentMark.Size = new System.Drawing.Size(23, 20);
            this.lbl_presentMark.TabIndex = 7;
            this.lbl_presentMark.Text = "%";
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(291, 131);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(52, 26);
            this.txt_discount.TabIndex = 6;
            this.txt_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            this.txt_discount.Leave += new System.EventHandler(this.txt_discount_Leave);
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(291, 94);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(181, 26);
            this.txt_amount.TabIndex = 5;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            this.txt_amount.Leave += new System.EventHandler(this.txt_amount_Leave);
            // 
            // cmb_regno
            // 
            this.cmb_regno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_regno.FormattingEnabled = true;
            this.cmb_regno.Location = new System.Drawing.Point(291, 55);
            this.cmb_regno.Name = "cmb_regno";
            this.cmb_regno.Size = new System.Drawing.Size(181, 28);
            this.cmb_regno.TabIndex = 4;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(33, 169);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(197, 25);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "Total Amount To Pay";
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.Location = new System.Drawing.Point(33, 132);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(88, 25);
            this.lbl_discount.TabIndex = 2;
            this.lbl_discount.Text = "Discount";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(33, 95);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(80, 25);
            this.lbl_amount.TabIndex = 1;
            this.lbl_amount.Text = "Amount";
            // 
            // lbl_regno
            // 
            this.lbl_regno.AutoSize = true;
            this.lbl_regno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regno.Location = new System.Drawing.Point(33, 58);
            this.lbl_regno.Name = "lbl_regno";
            this.lbl_regno.Size = new System.Drawing.Size(183, 25);
            this.lbl_regno.TabIndex = 0;
            this.lbl_regno.Text = "Registraion Number";
            // 
            // btn_saveFee
            // 
            this.btn_saveFee.ActiveBorderThickness = 3;
            this.btn_saveFee.ActiveCornerRadius = 20;
            this.btn_saveFee.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_saveFee.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_saveFee.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_saveFee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveFee.BackColor = System.Drawing.SystemColors.Control;
            this.btn_saveFee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_saveFee.BackgroundImage")));
            this.btn_saveFee.ButtonText = "SAVE";
            this.btn_saveFee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveFee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveFee.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_saveFee.IdleBorderThickness = 3;
            this.btn_saveFee.IdleCornerRadius = 20;
            this.btn_saveFee.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.btn_saveFee.IdleForecolor = System.Drawing.Color.Black;
            this.btn_saveFee.IdleLineColor = System.Drawing.Color.Black;
            this.btn_saveFee.Location = new System.Drawing.Point(246, 393);
            this.btn_saveFee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_saveFee.Name = "btn_saveFee";
            this.btn_saveFee.Size = new System.Drawing.Size(163, 52);
            this.btn_saveFee.TabIndex = 2;
            this.btn_saveFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_saveFee.Click += new System.EventHandler(this.btn_saveFee_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.ActiveBorderThickness = 3;
            this.btn_exit.ActiveCornerRadius = 20;
            this.btn_exit.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.btn_exit.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_exit.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.ButtonText = "EXIT";
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_exit.IdleBorderThickness = 3;
            this.btn_exit.IdleCornerRadius = 20;
            this.btn_exit.IdleFillColor = System.Drawing.Color.Red;
            this.btn_exit.IdleForecolor = System.Drawing.Color.Black;
            this.btn_exit.IdleLineColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(479, 486);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(163, 52);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_home
            // 
            this.btn_home.ActiveBorderThickness = 3;
            this.btn_home.ActiveCornerRadius = 20;
            this.btn_home.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.btn_home.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_home.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_home.BackColor = System.Drawing.SystemColors.Control;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.ButtonText = "HOME";
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_home.IdleBorderThickness = 3;
            this.btn_home.IdleCornerRadius = 20;
            this.btn_home.IdleFillColor = System.Drawing.Color.Red;
            this.btn_home.IdleForecolor = System.Drawing.Color.Black;
            this.btn_home.IdleLineColor = System.Drawing.Color.Black;
            this.btn_home.Location = new System.Drawing.Point(479, 424);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(163, 52);
            this.btn_home.TabIndex = 4;
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // CourseFeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Enrolment_System.Properties.Resources._6617;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 552);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_saveFee);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.MinimumSize = new System.Drawing.Size(671, 591);
            this.Name = "CourseFeePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseFeePage";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lbl_regno;
        private System.Windows.Forms.Label lbl_presentMark;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.ComboBox cmb_regno;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_total;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_saveFee;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_exit;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_home;
    }
}