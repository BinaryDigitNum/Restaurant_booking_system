namespace Restaurant_booking_system.Admin
{
    partial class Frm_AdminAddReservation
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dtGridView_availableRooms = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_searchRooms = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPicker_checkOut = new System.Windows.Forms.DateTimePicker();
            this.dtPicker_checkIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_roomType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nrc = new System.Windows.Forms.TextBox();
            this.txt_cusEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cusPhNumber = new System.Windows.Forms.TextBox();
            this.txt_cusName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_availableRooms)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_top.Controls.Add(this.label7);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1113, 47);
            this.panel_top.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(439, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Room reservation dashboard";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label8);
            this.panel_main.Controls.Add(this.dtGridView_availableRooms);
            this.panel_main.Controls.Add(this.groupBox2);
            this.panel_main.Controls.Add(this.groupBox1);
            this.panel_main.Controls.Add(this.btn_cancel);
            this.panel_main.Controls.Add(this.btn_confirm);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.ForeColor = System.Drawing.Color.White;
            this.panel_main.Location = new System.Drawing.Point(0, 47);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1113, 755);
            this.panel_main.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(502, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "Available rooms";
            // 
            // dtGridView_availableRooms
            // 
            this.dtGridView_availableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_availableRooms.Location = new System.Drawing.Point(502, 30);
            this.dtGridView_availableRooms.Name = "dtGridView_availableRooms";
            this.dtGridView_availableRooms.RowTemplate.Height = 25;
            this.dtGridView_availableRooms.Size = new System.Drawing.Size(588, 292);
            this.dtGridView_availableRooms.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_searchRooms);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtPicker_checkOut);
            this.groupBox2.Controls.Add(this.dtPicker_checkIn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmb_roomType);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(31, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 292);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search available rooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Check In :";
            // 
            // btn_searchRooms
            // 
            this.btn_searchRooms.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_searchRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchRooms.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_searchRooms.ForeColor = System.Drawing.Color.Black;
            this.btn_searchRooms.Location = new System.Drawing.Point(337, 212);
            this.btn_searchRooms.Name = "btn_searchRooms";
            this.btn_searchRooms.Size = new System.Drawing.Size(88, 36);
            this.btn_searchRooms.TabIndex = 31;
            this.btn_searchRooms.Text = "Search";
            this.btn_searchRooms.UseVisualStyleBackColor = false;
            this.btn_searchRooms.Click += new System.EventHandler(this.btn_searchRooms_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Room type";
            // 
            // dtPicker_checkOut
            // 
            this.dtPicker_checkOut.CustomFormat = "yyyy/MM/dd";
            this.dtPicker_checkOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPicker_checkOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_checkOut.Location = new System.Drawing.Point(145, 94);
            this.dtPicker_checkOut.MinDate = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            this.dtPicker_checkOut.Name = "dtPicker_checkOut";
            this.dtPicker_checkOut.Size = new System.Drawing.Size(129, 29);
            this.dtPicker_checkOut.TabIndex = 30;
            // 
            // dtPicker_checkIn
            // 
            this.dtPicker_checkIn.CustomFormat = "yyyy/MM/dd";
            this.dtPicker_checkIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPicker_checkIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_checkIn.Location = new System.Drawing.Point(144, 47);
            this.dtPicker_checkIn.MinDate = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            this.dtPicker_checkIn.Name = "dtPicker_checkIn";
            this.dtPicker_checkIn.Size = new System.Drawing.Size(130, 29);
            this.dtPicker_checkIn.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Check Out :";
            // 
            // cmb_roomType
            // 
            this.cmb_roomType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_roomType.FormattingEnabled = true;
            this.cmb_roomType.Location = new System.Drawing.Point(145, 159);
            this.cmb_roomType.Name = "cmb_roomType";
            this.cmb_roomType.Size = new System.Drawing.Size(280, 25);
            this.cmb_roomType.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_nrc);
            this.groupBox1.Controls.Add(this.txt_cusEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_cusPhNumber);
            this.groupBox1.Controls.Add(this.txt_cusName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(31, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 326);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(104, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "NRC";
            // 
            // txt_nrc
            // 
            this.txt_nrc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nrc.Location = new System.Drawing.Point(176, 126);
            this.txt_nrc.Name = "txt_nrc";
            this.txt_nrc.Size = new System.Drawing.Size(241, 29);
            this.txt_nrc.TabIndex = 27;
            // 
            // txt_cusEmail
            // 
            this.txt_cusEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cusEmail.Location = new System.Drawing.Point(176, 197);
            this.txt_cusEmail.Name = "txt_cusEmail";
            this.txt_cusEmail.Size = new System.Drawing.Size(241, 29);
            this.txt_cusEmail.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(104, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // txt_cusPhNumber
            // 
            this.txt_cusPhNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cusPhNumber.Location = new System.Drawing.Point(176, 265);
            this.txt_cusPhNumber.Name = "txt_cusPhNumber";
            this.txt_cusPhNumber.Size = new System.Drawing.Size(241, 29);
            this.txt_cusPhNumber.TabIndex = 24;
            // 
            // txt_cusName
            // 
            this.txt_cusName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cusName.Location = new System.Drawing.Point(176, 56);
            this.txt_cusName.Name = "txt_cusName";
            this.txt_cusName.Size = new System.Drawing.Size(241, 29);
            this.txt_cusName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Phone number";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(371, 662);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 35);
            this.btn_cancel.TabIndex = 27;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancelReservation_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirm.ForeColor = System.Drawing.Color.Black;
            this.btn_confirm.Location = new System.Drawing.Point(271, 662);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(94, 35);
            this.btn_confirm.TabIndex = 26;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 785);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1113, 17);
            this.panel_bottom.TabIndex = 2;
            // 
            // Frm_AdminAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 802);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AdminAddReservation";
            this.Text = "Frm_adminBookingsTable";
            this.Load += new System.EventHandler(this.Frm_AdminAddReservation_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_availableRooms)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_top;
        private Panel panel_main;
        private Panel panel_bottom;
        private Button btn_cancel;
        private Button btn_confirm;
        private TextBox txt_cusEmail;
        private TextBox txt_cusPhNumber;
        private TextBox txt_cusName;
        private ComboBox cmb_roomType;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dtPicker_checkIn;
        private Label label3;
        private Label label1;
        private Label label7;
        private GroupBox groupBox1;
        private DateTimePicker dtPicker_checkOut;
        private Label label2;
        private GroupBox groupBox2;
        private Button btn_searchRooms;
        private Label label8;
        private DataGridView dtGridView_availableRooms;
        private Label label9;
        private TextBox txt_nrc;
    }
}