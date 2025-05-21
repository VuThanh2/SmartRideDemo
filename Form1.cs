using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRideDemo
{
    public partial class Form1: Form
    {
        private List<Driver> drivers = new List<Driver>();
        private List<Ride> rideHistory = new List<Ride>();
        private Random random = new Random();
        //Hiwwwwww

        public Form1()
        {
            InitializeComponent();
            AddDriver("Alice");
            AddDriver("Tom");
            AddDriver("Mike");
            AddDriver("Bill");
            AddDriver("Bob");
            AddDriver("Bane");
            LoadAvailableDrivers();
        }

        private void AddDriver(string name) {
            int fare = random.Next(30000, 60001); // Random fare between 30,000 and 60,000
            int eta = random.Next(3, 11);         // Random ETA between 3 and 10 mins
            drivers.Add(new Driver { Name = name, Fare = fare, ETA = eta });
        }
        private void label1_Click(object sender, EventArgs e) {

        }
        private void lblResult_Click(object sender, EventArgs e) {

        }
        private void Form1_Load(object sender, EventArgs e) {

        }
        private void btnBook_Click(object sender, EventArgs e) {
            string customerName = txtName.Text.Trim();
            string pickup = txtPickup.Text.Trim();
            string dropoff = txtDropoff.Text.Trim();

            if (!IsValidBookingInput())
                return;
            Driver driver = (Driver)lstAvailableDrivers.SelectedItem;
            if (driver == null) {
                lblResult.Text = "No drivers available. Please try again later.";
                return;
            }
            DialogResult confirm = MessageBox.Show(
                $"You are about to book a ride with {driver.Name}.\n" +
                $"Fare: {driver.Fare:N0} VND\nETA: {driver.ETA} minutes\n\nConfirm booking?",
                "Confirm Booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (confirm != DialogResult.Yes) {
                lblResult.Text = "Booking cancelled by user.";
                return;
            }

            // Assign driver
            driver.IsAvailable = false;

            Ride ride = new Ride {
                CustomerName = customerName,
                DriverName = driver.Name,
                PickupLocation = pickup,
                DropoffLocation = dropoff,
                Status = "Ongoing",
                Fare = driver.Fare,
                ETA = driver.ETA
            };

            rideHistory.Add(ride);

            lblResult.Text = $"Ride booked successfully!\nDriver: {ride.DriverName}\nETA: {driver.ETA} mins\nFare: {driver.Fare:N0} VND";
            lblResult.ForeColor = Color.DarkGreen;
            // Optional: Save to file
            SaveRideToFile(ride);
            RefreshRideList();  // Add this
            LoadAvailableDrivers();
            txtName.Text = "";
            txtPickup.Text = "";
            txtDropoff.Text = "";
            lstAvailableDrivers.ClearSelected();
        }
        private void SaveRideToFile(Ride ride) {
            using (StreamWriter writer = new StreamWriter("rides.txt", false)) // overwrite
            {
                foreach (var r in rideHistory) {
                    string line = $"{r.CustomerName},{r.DriverName},{r.PickupLocation},{r.DropoffLocation},{r.Status},{(r.Paid ? "Paid" : "Unpaid")},{r.Fare},{r.ETA}";
                    writer.WriteLine(line);
                }
            }
        }

        private void RefreshRideList() {
            lstRides.Items.Clear();
            foreach (var ride in rideHistory) {
                // Only show ongoing rides
                if (ride.Status == "Ongoing" && !ride.Paid)
                    lstRides.Items.Add(ride);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e) {
            if (lstRides.SelectedItem == null) {
                lblPaymentResult.Text = "Please select a ride to complete.";
                return;
            }

            var selectedRide = (Ride)lstRides.SelectedItem;

            // Mark as completed
            selectedRide.Status = "Completed";

            // Mock payment confirmation
            bool paymentSuccess = false;

            while (!paymentSuccess) {
                DialogResult confirm = MessageBox.Show(
                    $"Total fare is {selectedRide.Fare:N0} VND for {selectedRide.CustomerName}.\nPay now?",
                    "Confirm Payment",
                    MessageBoxButtons.YesNo
                );

                if (confirm == DialogResult.No) {
                    lblPaymentResult.Text = "Payment cancelled. Ride remains unpaid.";
                    lblPaymentResult.ForeColor = Color.Red;
                    return;
                }

                // Simulate payment result (70% chance of success)
                int chance = random.Next(0, 100);
                if (chance < 70) {
                    paymentSuccess = true;
                    selectedRide.Paid = true;
                    lblPaymentResult.Text = $"Payment successful! Receipt generated for {selectedRide.CustomerName}.";
                    SaveRideToFile(selectedRide);
                    lblPaymentResult.ForeColor = Color.Green; 
                } else {
                    DialogResult retry = MessageBox.Show(
                        "❌ Payment failed (card declined).\nDo you want to retry with another method?",
                        "Payment Failed",
                        MessageBoxButtons.YesNo
                    );
                    lblPaymentResult.ForeColor = Color.Red;  
                    if (retry == DialogResult.No) {
                        lblPaymentResult.Text = "Payment failed and was cancelled by the customer.";
                        return;
                    }
                    lblPaymentResult.ForeColor = Color.Red;
                    // Else loop again for retry
                }
            }
            RefreshRideList(); // Remove from list
        }
        private void tabBooking_Click(object sender, EventArgs e) {

        }

        private void btnRefreshStats_Click(object sender, EventArgs e) {
            int totalRides = rideHistory.Count;
            int completedRides = rideHistory.Count(r => r.Status == "Completed");
            int paidRides = rideHistory.Count(r => r.Paid);

            int totalRevenue = rideHistory.Where(r => r.Paid).Sum(r => r.Fare);

            lblTotalRides.Text = $"Total Rides: {totalRides}";
            lblCompletedRides.Text = $"Completed Rides: {completedRides}";
            lblRevenue.Text = $"Total Revenue: {totalRevenue:N0} VND";
            lstPayments.Items.Clear();
            foreach (var ride in rideHistory.Where(r => r.Paid)) {
                string paymentInfo = $"{ride.CustomerName,-10} | Driver: {ride.DriverName,-8} | Fare: {ride.Fare,6:N0} VND | From {ride.PickupLocation} → {ride.DropoffLocation}";
                lstPayments.Items.Add(paymentInfo);
            }
        }
        private void LoadAvailableDrivers() {
            lstAvailableDrivers.Items.Clear();

            IEnumerable<Driver> sortedDrivers;

            if (rbSortFare.Checked) {
                sortedDrivers = drivers.Where(d => d.IsAvailable).OrderBy(d => d.Fare);
            } else if (rbSortETA.Checked) {
                sortedDrivers = drivers.Where(d => d.IsAvailable).OrderBy(d => d.ETA);
            } else {
                sortedDrivers = drivers.Where(d => d.IsAvailable); // fallback
            }

            foreach (var driver in sortedDrivers) {
                lstAvailableDrivers.Items.Add(driver);
            }
        }

        private void label1_Click_1(object sender, EventArgs e) {

        }

        private void rbSortFare_CheckedChanged(object sender, EventArgs e) {
            if (rbSortFare.Checked) LoadAvailableDrivers();
        }

        private void rbSortETA_CheckedChanged(object sender, EventArgs e) {
            if (rbSortETA.Checked) LoadAvailableDrivers();
        }

        private bool IsValidName(string name) {
            return name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool ContainsLetters(string input) {
            return input.Any(char.IsLetter);
        }

        private bool IsValidBookingInput() {
            string name = txtName.Text.Trim();
            string pickup = txtPickup.Text.Trim();
            string dropoff = txtDropoff.Text.Trim();

            if (string.IsNullOrWhiteSpace(name)) {
                lblResult.Text = "Customer name is required.";
                lblResult.ForeColor = Color.Red;
                txtName.Focus();
                return false;
            }

            if (!IsValidName(name)) {
                lblResult.Text = "Customer name must only contain letters and spaces.";
                lblResult.ForeColor = Color.Red;
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(pickup)) {
                lblResult.Text = "Pickup location is required.";
                lblResult.ForeColor = Color.Red;
                txtPickup.Focus();
                return false;
            }

            if (!ContainsLetters(pickup)) {
                lblResult.Text = "Pickup location must include at least one letter.";
                lblResult.ForeColor = Color.Red;
                txtPickup.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(dropoff)) {
                lblResult.Text = "Drop-off location is required.";
                lblResult.ForeColor = Color.Red;
                txtDropoff.Focus();
                return false;
            }

            if (!ContainsLetters(dropoff)) {
                lblResult.Text = "Drop-off location must include at least one letter.";
                lblResult.ForeColor = Color.Red;
                txtDropoff.Focus();
                return false;
            }

            if (lstAvailableDrivers.SelectedItem == null || !(lstAvailableDrivers.SelectedItem is Driver)) {
                lblResult.Text = "Please select a valid driver from the list.";
                lblResult.ForeColor = Color.Red;
                return false;
            }

            lblResult.ForeColor = Color.Black;
            return true;
        }
    }
}
