namespace InvoiceTotal_10_3
{
    partial class frmInvoiceTotal
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
            this.lblProductTotal = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBoxProductTotal = new System.Windows.Forms.TextBox();
            this.txtBoxDiscount = new System.Windows.Forms.TextBox();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.txtBoxTax = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangePercent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductTotal
            // 
            this.lblProductTotal.AutoSize = true;
            this.lblProductTotal.Location = new System.Drawing.Point(13, 22);
            this.lblProductTotal.Name = "lblProductTotal";
            this.lblProductTotal.Size = new System.Drawing.Size(70, 13);
            this.lblProductTotal.TabIndex = 0;
            this.lblProductTotal.Text = "Product total:";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(12, 57);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(91, 13);
            this.lblDiscountAmount.TabIndex = 1;
            this.lblDiscountAmount.Text = "Discount Amount:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(12, 91);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(12, 125);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(66, 13);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Tax (7.75%):";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 165);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtBoxProductTotal
            // 
            this.txtBoxProductTotal.Location = new System.Drawing.Point(109, 15);
            this.txtBoxProductTotal.Name = "txtBoxProductTotal";
            this.txtBoxProductTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProductTotal.TabIndex = 5;
            // 
            // txtBoxDiscount
            // 
            this.txtBoxDiscount.Location = new System.Drawing.Point(109, 57);
            this.txtBoxDiscount.Name = "txtBoxDiscount";
            this.txtBoxDiscount.ReadOnly = true;
            this.txtBoxDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDiscount.TabIndex = 6;
            this.txtBoxDiscount.TabStop = false;
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.Location = new System.Drawing.Point(109, 91);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.ReadOnly = true;
            this.txtBoxSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSubtotal.TabIndex = 7;
            this.txtBoxSubtotal.TabStop = false;
            // 
            // txtBoxTax
            // 
            this.txtBoxTax.Location = new System.Drawing.Point(109, 127);
            this.txtBoxTax.Name = "txtBoxTax";
            this.txtBoxTax.ReadOnly = true;
            this.txtBoxTax.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTax.TabIndex = 8;
            this.txtBoxTax.TabStop = false;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(109, 158);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotal.TabIndex = 9;
            this.txtBoxTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(43, 200);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(145, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChangePercent
            // 
            this.btnChangePercent.Location = new System.Drawing.Point(235, 124);
            this.btnChangePercent.Name = "btnChangePercent";
            this.btnChangePercent.Size = new System.Drawing.Size(105, 23);
            this.btnChangePercent.TabIndex = 12;
            this.btnChangePercent.Text = "Change Percent";
            this.btnChangePercent.UseVisualStyleBackColor = true;
            this.btnChangePercent.Click += new System.EventHandler(this.btnChangePercent_Click);
            // 
            // frmInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(358, 235);
            this.Controls.Add(this.btnChangePercent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.txtBoxTax);
            this.Controls.Add(this.txtBoxSubtotal);
            this.Controls.Add(this.txtBoxDiscount);
            this.Controls.Add(this.txtBoxProductTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblProductTotal);
            this.Name = "frmInvoiceTotal";
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductTotal;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBoxProductTotal;
        private System.Windows.Forms.TextBox txtBoxDiscount;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.TextBox txtBoxTax;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangePercent;
    }
}

