namespace ConvertLength_10_1
{
    partial class frmConvertLength
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
            this.lblConversion = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbBoxConversion = new System.Windows.Forms.ComboBox();
            this.lblEntry = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.Location = new System.Drawing.Point(13, 22);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(63, 13);
            this.lblConversion.TabIndex = 0;
            this.lblConversion.Text = "Conversion:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(13, 50);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(0, 13);
            this.lblInput.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(13, 78);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 2;
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(96, 47);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInput.TabIndex = 3;
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Location = new System.Drawing.Point(96, 80);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ReadOnly = true;
            this.txtBoxOutput.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOutput.TabIndex = 4;
            this.txtBoxOutput.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 132);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(150, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbBoxConversion
            // 
            this.cmbBoxConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxConversion.FormattingEnabled = true;
            this.cmbBoxConversion.Location = new System.Drawing.Point(82, 19);
            this.cmbBoxConversion.Name = "cmbBoxConversion";
            this.cmbBoxConversion.Size = new System.Drawing.Size(154, 21);
            this.cmbBoxConversion.TabIndex = 7;
            this.cmbBoxConversion.SelectedIndexChanged += new System.EventHandler(this.cmbBoxConversion_SelectedIndexChanged);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Location = new System.Drawing.Point(28, 53);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(35, 13);
            this.lblEntry.TabIndex = 8;
            this.lblEntry.Text = "label1";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(28, 83);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "label2";
            // 
            // frmConvertLength
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(312, 198);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.cmbBoxConversion);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblConversion);
            this.Name = "frmConvertLength";
            this.RightToLeftLayout = true;
            this.Text = "Conversions";
            this.Load += new System.EventHandler(this.frmConvertLength_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbBoxConversion;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Label lblResult;
    }
}

