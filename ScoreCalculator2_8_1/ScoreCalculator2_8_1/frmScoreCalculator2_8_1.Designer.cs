namespace ScoreCalculator2_8_1
{
    partial class frmScoreCalculator2_8_1
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearScore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(32, 22);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Location = new System.Drawing.Point(12, 51);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(61, 13);
            this.lblScoreTotal.TabIndex = 5;
            this.lblScoreTotal.Text = "Score total:";
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Location = new System.Drawing.Point(5, 81);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(68, 13);
            this.lblScoreCount.TabIndex = 7;
            this.lblScoreCount.Text = "Score count:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(12, 120);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 13);
            this.lblAverage.TabIndex = 9;
            this.lblAverage.Text = "Average:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(73, 22);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(75, 20);
            this.txtScore.TabIndex = 1;
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Location = new System.Drawing.Point(73, 78);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.ReadOnly = true;
            this.txtScoreCount.Size = new System.Drawing.Size(75, 20);
            this.txtScoreCount.TabIndex = 8;
            this.txtScoreCount.TabStop = false;
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Location = new System.Drawing.Point(74, 48);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.ReadOnly = true;
            this.txtScoreTotal.Size = new System.Drawing.Size(75, 20);
            this.txtScoreTotal.TabIndex = 6;
            this.txtScoreTotal.TabStop = false;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(73, 113);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(75, 20);
            this.txtAverage.TabIndex = 10;
            this.txtAverage.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(179, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearScore
            // 
            this.btnClearScore.Location = new System.Drawing.Point(179, 159);
            this.btnClearScore.Name = "btnClearScore";
            this.btnClearScore.Size = new System.Drawing.Size(75, 23);
            this.btnClearScore.TabIndex = 3;
            this.btnClearScore.Text = "Clear Score";
            this.btnClearScore.UseVisualStyleBackColor = true;
            this.btnClearScore.Click += new System.EventHandler(this.btnClearScore_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(179, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayScores
            // 
            this.btnDisplayScores.Location = new System.Drawing.Point(60, 159);
            this.btnDisplayScores.Name = "btnDisplayScores";
            this.btnDisplayScores.Size = new System.Drawing.Size(89, 23);
            this.btnDisplayScores.TabIndex = 11;
            this.btnDisplayScores.Text = "Display Scores";
            this.btnDisplayScores.UseVisualStyleBackColor = true;
            this.btnDisplayScores.Click += new System.EventHandler(this.btnDisplayScores_Click);
            // 
            // frmScoreCalculator2_8_1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.btnDisplayScores);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearScore);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblScore);
            this.Name = "frmScoreCalculator2_8_1";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplayScores;
    }
}

