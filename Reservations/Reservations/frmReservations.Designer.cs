namespace Reservations
{
    partial class frmReservations
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
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblNumberNights = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblAveragePricePerNight = new System.Windows.Forms.Label();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.txtNumberNights = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtAveragePerNight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(89, 40);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(63, 13);
            this.lblArrival.TabIndex = 0;
            this.lblArrival.Text = "Arrival date:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(71, 66);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(81, 13);
            this.lblDeparture.TabIndex = 1;
            this.lblDeparture.Text = "Departure date:";
            // 
            // lblNumberNights
            // 
            this.lblNumberNights.AutoSize = true;
            this.lblNumberNights.Location = new System.Drawing.Point(62, 95);
            this.lblNumberNights.Name = "lblNumberNights";
            this.lblNumberNights.Size = new System.Drawing.Size(90, 13);
            this.lblNumberNights.TabIndex = 2;
            this.lblNumberNights.Text = "Number of nights:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(89, 128);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(60, 13);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total price:";
            // 
            // lblAveragePricePerNight
            // 
            this.lblAveragePricePerNight.AutoSize = true;
            this.lblAveragePricePerNight.Location = new System.Drawing.Point(50, 152);
            this.lblAveragePricePerNight.Name = "lblAveragePricePerNight";
            this.lblAveragePricePerNight.Size = new System.Drawing.Size(102, 13);
            this.lblAveragePricePerNight.TabIndex = 4;
            this.lblAveragePricePerNight.Text = "Avg. price per night:";
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(158, 40);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(100, 20);
            this.txtArrivalDate.TabIndex = 1;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(158, 66);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(100, 20);
            this.txtDepartureDate.TabIndex = 2;
            // 
            // txtNumberNights
            // 
            this.txtNumberNights.Location = new System.Drawing.Point(158, 92);
            this.txtNumberNights.Name = "txtNumberNights";
            this.txtNumberNights.ReadOnly = true;
            this.txtNumberNights.Size = new System.Drawing.Size(100, 20);
            this.txtNumberNights.TabIndex = 7;
            this.txtNumberNights.TabStop = false;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(158, 125);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrice.TabIndex = 8;
            this.txtTotalPrice.TabStop = false;
            // 
            // txtAveragePerNight
            // 
            this.txtAveragePerNight.Location = new System.Drawing.Point(158, 152);
            this.txtAveragePerNight.Name = "txtAveragePerNight";
            this.txtAveragePerNight.ReadOnly = true;
            this.txtAveragePerNight.Size = new System.Drawing.Size(100, 20);
            this.txtAveragePerNight.TabIndex = 9;
            this.txtAveragePerNight.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Location = new System.Drawing.Point(53, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(171, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmReservations
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAveragePerNight);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtNumberNights);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.lblAveragePricePerNight);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblNumberNights);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblArrival);
            this.Name = "frmReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.frmReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblNumberNights;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblAveragePricePerNight;
        private System.Windows.Forms.TextBox txtArrivalDate;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.TextBox txtNumberNights;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtAveragePerNight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

