namespace InvoiceTotal_10_3
{
    partial class frmSalesTax
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
            this.lblSalesTaxPct = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBoxSalesTaxPct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSalesTaxPct
            // 
            this.lblSalesTaxPct.AutoSize = true;
            this.lblSalesTaxPct.Location = new System.Drawing.Point(12, 32);
            this.lblSalesTaxPct.Name = "lblSalesTaxPct";
            this.lblSalesTaxPct.Size = new System.Drawing.Size(71, 13);
            this.lblSalesTaxPct.TabIndex = 0;
            this.lblSalesTaxPct.Text = "Sales tax pct:";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(15, 75);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(117, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxSalesTaxPct
            // 
            this.txtBoxSalesTaxPct.Location = new System.Drawing.Point(92, 32);
            this.txtBoxSalesTaxPct.Name = "txtBoxSalesTaxPct";
            this.txtBoxSalesTaxPct.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSalesTaxPct.TabIndex = 3;
            // 
            // frmSalesTax
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(231, 110);
            this.Controls.Add(this.txtBoxSalesTaxPct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSalesTaxPct);
            this.Name = "frmSalesTax";
            this.Text = "Sales Tax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesTaxPct;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBoxSalesTaxPct;
    }
}