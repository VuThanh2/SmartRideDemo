namespace SmartRideDemo {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPickup = new System.Windows.Forms.Label();
            this.lblDropoff = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPickup = new System.Windows.Forms.TextBox();
            this.txtDropoff = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblSelectRide = new System.Windows.Forms.Label();
            this.lstRides = new System.Windows.Forms.ListBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.rbSortETA = new System.Windows.Forms.RadioButton();
            this.rbSortFare = new System.Windows.Forms.RadioButton();
            this.lstAvailableDrivers = new System.Windows.Forms.ListBox();
            this.tabComplete = new System.Windows.Forms.TabPage();
            this.lblPaymentResult = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.lstPayments = new System.Windows.Forms.ListBox();
            this.btnRefreshStats = new System.Windows.Forms.Button();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblCompletedRides = new System.Windows.Forms.Label();
            this.lblTotalRides = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.tabComplete.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPickup
            // 
            this.lblPickup.AutoSize = true;
            this.lblPickup.Location = new System.Drawing.Point(37, 155);
            this.lblPickup.Name = "lblPickup";
            this.lblPickup.Size = new System.Drawing.Size(102, 16);
            this.lblPickup.TabIndex = 1;
            this.lblPickup.Text = "Pickup Location";
            // 
            // lblDropoff
            // 
            this.lblDropoff.AutoSize = true;
            this.lblDropoff.Location = new System.Drawing.Point(35, 202);
            this.lblDropoff.Name = "lblDropoff";
            this.lblDropoff.Size = new System.Drawing.Size(109, 16);
            this.lblDropoff.TabIndex = 2;
            this.lblDropoff.Text = "Drop-off Location";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(224, 335);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtPickup
            // 
            this.txtPickup.Location = new System.Drawing.Point(169, 152);
            this.txtPickup.Name = "txtPickup";
            this.txtPickup.Size = new System.Drawing.Size(100, 22);
            this.txtPickup.TabIndex = 5;
            // 
            // txtDropoff
            // 
            this.txtDropoff.Location = new System.Drawing.Point(169, 202);
            this.txtDropoff.Name = "txtDropoff";
            this.txtDropoff.Size = new System.Drawing.Size(100, 22);
            this.txtDropoff.TabIndex = 6;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(280, 284);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(131, 23);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "Book Ride";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblSelectRide
            // 
            this.lblSelectRide.AutoSize = true;
            this.lblSelectRide.Location = new System.Drawing.Point(223, 52);
            this.lblSelectRide.Name = "lblSelectRide";
            this.lblSelectRide.Size = new System.Drawing.Size(155, 16);
            this.lblSelectRide.TabIndex = 8;
            this.lblSelectRide.Text = "Select Ride to Complete:";
            // 
            // lstRides
            // 
            this.lstRides.FormattingEnabled = true;
            this.lstRides.ItemHeight = 16;
            this.lstRides.Location = new System.Drawing.Point(184, 92);
            this.lstRides.Name = "lstRides";
            this.lstRides.Size = new System.Drawing.Size(349, 164);
            this.lstRides.TabIndex = 9;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(184, 341);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(223, 33);
            this.btnComplete.TabIndex = 10;
            this.btnComplete.Text = "Complete Ride and Pay";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabBooking);
            this.tabControlMain.Controls.Add(this.tabComplete);
            this.tabControlMain.Controls.Add(this.tabAdmin);
            this.tabControlMain.Location = new System.Drawing.Point(50, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(798, 460);
            this.tabControlMain.TabIndex = 11;
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.rbSortETA);
            this.tabBooking.Controls.Add(this.rbSortFare);
            this.tabBooking.Controls.Add(this.lstAvailableDrivers);
            this.tabBooking.Controls.Add(this.lblName);
            this.tabBooking.Controls.Add(this.lblPickup);
            this.tabBooking.Controls.Add(this.lblDropoff);
            this.tabBooking.Controls.Add(this.lblResult);
            this.tabBooking.Controls.Add(this.btnBook);
            this.tabBooking.Controls.Add(this.txtName);
            this.tabBooking.Controls.Add(this.txtDropoff);
            this.tabBooking.Controls.Add(this.txtPickup);
            this.tabBooking.Location = new System.Drawing.Point(4, 25);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooking.Size = new System.Drawing.Size(790, 431);
            this.tabBooking.TabIndex = 0;
            this.tabBooking.Text = "Book Ride";
            this.tabBooking.UseVisualStyleBackColor = true;
            this.tabBooking.Click += new System.EventHandler(this.tabBooking_Click);
            // 
            // rbSortETA
            // 
            this.rbSortETA.AutoSize = true;
            this.rbSortETA.Location = new System.Drawing.Point(353, 61);
            this.rbSortETA.Name = "rbSortETA";
            this.rbSortETA.Size = new System.Drawing.Size(100, 20);
            this.rbSortETA.TabIndex = 10;
            this.rbSortETA.TabStop = true;
            this.rbSortETA.Text = "Sort by ETA";
            this.rbSortETA.UseVisualStyleBackColor = true;
            this.rbSortETA.CheckedChanged += new System.EventHandler(this.rbSortETA_CheckedChanged);
            // 
            // rbSortFare
            // 
            this.rbSortFare.AutoSize = true;
            this.rbSortFare.Location = new System.Drawing.Point(353, 35);
            this.rbSortFare.Name = "rbSortFare";
            this.rbSortFare.Size = new System.Drawing.Size(101, 20);
            this.rbSortFare.TabIndex = 9;
            this.rbSortFare.TabStop = true;
            this.rbSortFare.Text = "Sort by Fare";
            this.rbSortFare.UseVisualStyleBackColor = true;
            this.rbSortFare.CheckedChanged += new System.EventHandler(this.rbSortFare_CheckedChanged);
            // 
            // lstAvailableDrivers
            // 
            this.lstAvailableDrivers.FormattingEnabled = true;
            this.lstAvailableDrivers.ItemHeight = 16;
            this.lstAvailableDrivers.Location = new System.Drawing.Point(353, 97);
            this.lstAvailableDrivers.Name = "lstAvailableDrivers";
            this.lstAvailableDrivers.Size = new System.Drawing.Size(303, 164);
            this.lstAvailableDrivers.TabIndex = 8;
            // 
            // tabComplete
            // 
            this.tabComplete.Controls.Add(this.lblPaymentResult);
            this.tabComplete.Controls.Add(this.lblSelectRide);
            this.tabComplete.Controls.Add(this.btnComplete);
            this.tabComplete.Controls.Add(this.lstRides);
            this.tabComplete.Location = new System.Drawing.Point(4, 25);
            this.tabComplete.Name = "tabComplete";
            this.tabComplete.Padding = new System.Windows.Forms.Padding(3);
            this.tabComplete.Size = new System.Drawing.Size(790, 431);
            this.tabComplete.TabIndex = 1;
            this.tabComplete.Text = "Complete Ride";
            this.tabComplete.UseVisualStyleBackColor = true;
            // 
            // lblPaymentResult
            // 
            this.lblPaymentResult.AutoSize = true;
            this.lblPaymentResult.Location = new System.Drawing.Point(181, 286);
            this.lblPaymentResult.Name = "lblPaymentResult";
            this.lblPaymentResult.Size = new System.Drawing.Size(45, 16);
            this.lblPaymentResult.TabIndex = 11;
            this.lblPaymentResult.Text = "Result";
            this.lblPaymentResult.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.lstPayments);
            this.tabAdmin.Controls.Add(this.btnRefreshStats);
            this.tabAdmin.Controls.Add(this.lblRevenue);
            this.tabAdmin.Controls.Add(this.lblCompletedRides);
            this.tabAdmin.Controls.Add(this.lblTotalRides);
            this.tabAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Size = new System.Drawing.Size(790, 431);
            this.tabAdmin.TabIndex = 2;
            this.tabAdmin.Text = "Admin Dashboard";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // lstPayments
            // 
            this.lstPayments.FormattingEnabled = true;
            this.lstPayments.ItemHeight = 16;
            this.lstPayments.Location = new System.Drawing.Point(86, 46);
            this.lstPayments.Name = "lstPayments";
            this.lstPayments.Size = new System.Drawing.Size(525, 212);
            this.lstPayments.TabIndex = 4;
            // 
            // btnRefreshStats
            // 
            this.btnRefreshStats.Location = new System.Drawing.Point(291, 371);
            this.btnRefreshStats.Name = "btnRefreshStats";
            this.btnRefreshStats.Size = new System.Drawing.Size(170, 42);
            this.btnRefreshStats.TabIndex = 3;
            this.btnRefreshStats.Text = "Refresh Analytics";
            this.btnRefreshStats.UseVisualStyleBackColor = true;
            this.btnRefreshStats.Click += new System.EventHandler(this.btnRefreshStats_Click);
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(154, 344);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(99, 16);
            this.lblRevenue.TabIndex = 2;
            this.lblRevenue.Text = "Total Revenue:";
            // 
            // lblCompletedRides
            // 
            this.lblCompletedRides.AutoSize = true;
            this.lblCompletedRides.Location = new System.Drawing.Point(154, 314);
            this.lblCompletedRides.Name = "lblCompletedRides";
            this.lblCompletedRides.Size = new System.Drawing.Size(118, 16);
            this.lblCompletedRides.TabIndex = 1;
            this.lblCompletedRides.Text = "Completed Rides: ";
            // 
            // lblTotalRides
            // 
            this.lblTotalRides.AutoSize = true;
            this.lblTotalRides.Location = new System.Drawing.Point(154, 286);
            this.lblTotalRides.Name = "lblTotalRides";
            this.lblTotalRides.Size = new System.Drawing.Size(83, 16);
            this.lblTotalRides.TabIndex = 0;
            this.lblTotalRides.Text = "Total Rides: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 550);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabBooking.ResumeLayout(false);
            this.tabBooking.PerformLayout();
            this.tabComplete.ResumeLayout(false);
            this.tabComplete.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPickup;
        private System.Windows.Forms.Label lblDropoff;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPickup;
        private System.Windows.Forms.TextBox txtDropoff;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblSelectRide;
        private System.Windows.Forms.ListBox lstRides;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.TabPage tabComplete;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblCompletedRides;
        private System.Windows.Forms.Label lblTotalRides;
        private System.Windows.Forms.Button btnRefreshStats;
        private System.Windows.Forms.Label lblPaymentResult;
        private System.Windows.Forms.ListBox lstPayments;
        private System.Windows.Forms.ListBox lstAvailableDrivers;
        private System.Windows.Forms.RadioButton rbSortETA;
        private System.Windows.Forms.RadioButton rbSortFare;
    }
}

