namespace LunchOrder_10_2
{
    partial class frmLunchOrder
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
            this.grpBoxMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoButtonSalad = new System.Windows.Forms.RadioButton();
            this.rdoButtonPizza = new System.Windows.Forms.RadioButton();
            this.rdoButtonHamburger = new System.Windows.Forms.RadioButton();
            this.grpBoxAddOnItems = new System.Windows.Forms.GroupBox();
            this.chkBoxThree = new System.Windows.Forms.CheckBox();
            this.chkBoxTwo = new System.Windows.Forms.CheckBox();
            this.chkBoxOne = new System.Windows.Forms.CheckBox();
            this.grpBoxOrderTotal = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtBoxOrderTotal = new System.Windows.Forms.TextBox();
            this.txtBoxTax = new System.Windows.Forms.TextBox();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxMainCourse.SuspendLayout();
            this.grpBoxAddOnItems.SuspendLayout();
            this.grpBoxOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxMainCourse
            // 
            this.grpBoxMainCourse.Controls.Add(this.rdoButtonSalad);
            this.grpBoxMainCourse.Controls.Add(this.rdoButtonPizza);
            this.grpBoxMainCourse.Controls.Add(this.rdoButtonHamburger);
            this.grpBoxMainCourse.Location = new System.Drawing.Point(38, 18);
            this.grpBoxMainCourse.Name = "grpBoxMainCourse";
            this.grpBoxMainCourse.Size = new System.Drawing.Size(200, 101);
            this.grpBoxMainCourse.TabIndex = 0;
            this.grpBoxMainCourse.TabStop = false;
            this.grpBoxMainCourse.Text = "Main Course";
            this.grpBoxMainCourse.Enter += new System.EventHandler(this.addOnItem_CheckChanged);
            // 
            // rdoButtonSalad
            // 
            this.rdoButtonSalad.AutoSize = true;
            this.rdoButtonSalad.Location = new System.Drawing.Point(6, 68);
            this.rdoButtonSalad.Name = "rdoButtonSalad";
            this.rdoButtonSalad.Size = new System.Drawing.Size(88, 17);
            this.rdoButtonSalad.TabIndex = 2;
            this.rdoButtonSalad.TabStop = true;
            this.rdoButtonSalad.Text = "Salad - $4.95";
            this.rdoButtonSalad.UseVisualStyleBackColor = true;
            this.rdoButtonSalad.CheckedChanged += new System.EventHandler(this.mainCourse_CheckedChanged);
            // 
            // rdoButtonPizza
            // 
            this.rdoButtonPizza.AutoSize = true;
            this.rdoButtonPizza.Location = new System.Drawing.Point(6, 45);
            this.rdoButtonPizza.Name = "rdoButtonPizza";
            this.rdoButtonPizza.Size = new System.Drawing.Size(86, 17);
            this.rdoButtonPizza.TabIndex = 1;
            this.rdoButtonPizza.TabStop = true;
            this.rdoButtonPizza.Text = "Pizza - $5.95";
            this.rdoButtonPizza.UseVisualStyleBackColor = true;
            this.rdoButtonPizza.CheckedChanged += new System.EventHandler(this.mainCourse_CheckedChanged);
            // 
            // rdoButtonHamburger
            // 
            this.rdoButtonHamburger.AutoSize = true;
            this.rdoButtonHamburger.Location = new System.Drawing.Point(6, 19);
            this.rdoButtonHamburger.Name = "rdoButtonHamburger";
            this.rdoButtonHamburger.Size = new System.Drawing.Size(113, 17);
            this.rdoButtonHamburger.TabIndex = 0;
            this.rdoButtonHamburger.TabStop = true;
            this.rdoButtonHamburger.Text = "Hamburger - $6.95";
            this.rdoButtonHamburger.UseVisualStyleBackColor = true;
            this.rdoButtonHamburger.CheckedChanged += new System.EventHandler(this.mainCourse_CheckedChanged);
            // 
            // grpBoxAddOnItems
            // 
            this.grpBoxAddOnItems.Controls.Add(this.chkBoxThree);
            this.grpBoxAddOnItems.Controls.Add(this.chkBoxTwo);
            this.grpBoxAddOnItems.Controls.Add(this.chkBoxOne);
            this.grpBoxAddOnItems.Location = new System.Drawing.Point(277, 18);
            this.grpBoxAddOnItems.Name = "grpBoxAddOnItems";
            this.grpBoxAddOnItems.Size = new System.Drawing.Size(200, 101);
            this.grpBoxAddOnItems.TabIndex = 1;
            this.grpBoxAddOnItems.TabStop = false;
            this.grpBoxAddOnItems.Text = "Add on items ($.75/each)";
            // 
            // chkBoxThree
            // 
            this.chkBoxThree.AutoSize = true;
            this.chkBoxThree.Location = new System.Drawing.Point(6, 69);
            this.chkBoxThree.Name = "chkBoxThree";
            this.chkBoxThree.Size = new System.Drawing.Size(81, 17);
            this.chkBoxThree.TabIndex = 2;
            this.chkBoxThree.Text = "French fries";
            this.chkBoxThree.UseVisualStyleBackColor = true;
            this.chkBoxThree.CheckedChanged += new System.EventHandler(this.addOnItem_CheckChanged);
            // 
            // chkBoxTwo
            // 
            this.chkBoxTwo.AutoSize = true;
            this.chkBoxTwo.Location = new System.Drawing.Point(6, 46);
            this.chkBoxTwo.Name = "chkBoxTwo";
            this.chkBoxTwo.Size = new System.Drawing.Size(161, 17);
            this.chkBoxTwo.TabIndex = 1;
            this.chkBoxTwo.Text = "Ketchup, mustard, and mayo";
            this.chkBoxTwo.UseVisualStyleBackColor = true;
            this.chkBoxTwo.CheckedChanged += new System.EventHandler(this.addOnItem_CheckChanged);
            // 
            // chkBoxOne
            // 
            this.chkBoxOne.AutoSize = true;
            this.chkBoxOne.Location = new System.Drawing.Point(6, 20);
            this.chkBoxOne.Name = "chkBoxOne";
            this.chkBoxOne.Size = new System.Drawing.Size(161, 17);
            this.chkBoxOne.TabIndex = 0;
            this.chkBoxOne.Text = "Lettuce, tomato, and onions ";
            this.chkBoxOne.UseVisualStyleBackColor = true;
            this.chkBoxOne.CheckedChanged += new System.EventHandler(this.addOnItem_CheckChanged);
            // 
            // grpBoxOrderTotal
            // 
            this.grpBoxOrderTotal.Controls.Add(this.lblOrderTotal);
            this.grpBoxOrderTotal.Controls.Add(this.lblTax);
            this.grpBoxOrderTotal.Controls.Add(this.lblSubtotal);
            this.grpBoxOrderTotal.Controls.Add(this.txtBoxOrderTotal);
            this.grpBoxOrderTotal.Controls.Add(this.txtBoxTax);
            this.grpBoxOrderTotal.Controls.Add(this.txtBoxSubtotal);
            this.grpBoxOrderTotal.Location = new System.Drawing.Point(38, 155);
            this.grpBoxOrderTotal.Name = "grpBoxOrderTotal";
            this.grpBoxOrderTotal.Size = new System.Drawing.Size(276, 117);
            this.grpBoxOrderTotal.TabIndex = 2;
            this.grpBoxOrderTotal.TabStop = false;
            this.grpBoxOrderTotal.Text = "Order total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(30, 91);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(57, 13);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.Text = "OrderTotal";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(30, 59);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(66, 13);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax (7.75%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(30, 26);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtBoxOrderTotal
            // 
            this.txtBoxOrderTotal.Location = new System.Drawing.Point(149, 91);
            this.txtBoxOrderTotal.Name = "txtBoxOrderTotal";
            this.txtBoxOrderTotal.ReadOnly = true;
            this.txtBoxOrderTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOrderTotal.TabIndex = 2;
            this.txtBoxOrderTotal.TabStop = false;
            // 
            // txtBoxTax
            // 
            this.txtBoxTax.Location = new System.Drawing.Point(149, 56);
            this.txtBoxTax.Name = "txtBoxTax";
            this.txtBoxTax.ReadOnly = true;
            this.txtBoxTax.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTax.TabIndex = 1;
            this.txtBoxTax.TabStop = false;
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.Location = new System.Drawing.Point(149, 20);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.ReadOnly = true;
            this.txtBoxSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSubtotal.TabIndex = 0;
            this.txtBoxSubtotal.TabStop = false;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(363, 155);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(363, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(499, 300);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpBoxOrderTotal);
            this.Controls.Add(this.grpBoxAddOnItems);
            this.Controls.Add(this.grpBoxMainCourse);
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.frmLunchOrder_Load);
            this.grpBoxMainCourse.ResumeLayout(false);
            this.grpBoxMainCourse.PerformLayout();
            this.grpBoxAddOnItems.ResumeLayout(false);
            this.grpBoxAddOnItems.PerformLayout();
            this.grpBoxOrderTotal.ResumeLayout(false);
            this.grpBoxOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMainCourse;
        private System.Windows.Forms.RadioButton rdoButtonSalad;
        private System.Windows.Forms.RadioButton rdoButtonPizza;
        private System.Windows.Forms.RadioButton rdoButtonHamburger;
        private System.Windows.Forms.GroupBox grpBoxAddOnItems;
        private System.Windows.Forms.CheckBox chkBoxThree;
        private System.Windows.Forms.CheckBox chkBoxTwo;
        private System.Windows.Forms.CheckBox chkBoxOne;
        private System.Windows.Forms.GroupBox grpBoxOrderTotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtBoxOrderTotal;
        private System.Windows.Forms.TextBox txtBoxTax;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
    }
}

