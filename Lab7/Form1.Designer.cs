namespace Lab7
{
    partial class Form1
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
            this.calcButton = new System.Windows.Forms.Button();
            this.futureValLabel = new System.Windows.Forms.Label();
            this.futureValTextBox = new System.Windows.Forms.TextBox();
            this.aprTextBox = new System.Windows.Forms.TextBox();
            this.aprLabel = new System.Windows.Forms.Label();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.presentValLabel = new System.Windows.Forms.Label();
            this.presentValResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(83, 168);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // futureValLabel
            // 
            this.futureValLabel.AutoSize = true;
            this.futureValLabel.Location = new System.Drawing.Point(48, 15);
            this.futureValLabel.Name = "futureValLabel";
            this.futureValLabel.Size = new System.Drawing.Size(70, 13);
            this.futureValLabel.TabIndex = 10;
            this.futureValLabel.Text = "Future Value:";
            // 
            // futureValTextBox
            // 
            this.futureValTextBox.Location = new System.Drawing.Point(124, 12);
            this.futureValTextBox.Name = "futureValTextBox";
            this.futureValTextBox.Size = new System.Drawing.Size(100, 20);
            this.futureValTextBox.TabIndex = 0;
            // 
            // aprTextBox
            // 
            this.aprTextBox.Location = new System.Drawing.Point(124, 52);
            this.aprTextBox.Name = "aprTextBox";
            this.aprTextBox.Size = new System.Drawing.Size(100, 20);
            this.aprTextBox.TabIndex = 1;
            // 
            // aprLabel
            // 
            this.aprLabel.AutoSize = true;
            this.aprLabel.Location = new System.Drawing.Point(11, 55);
            this.aprLabel.Name = "aprLabel";
            this.aprLabel.Size = new System.Drawing.Size(107, 13);
            this.aprLabel.TabIndex = 30;
            this.aprLabel.Text = "Annual Interest Rate:";
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(124, 92);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearsTextBox.TabIndex = 2;
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(48, 92);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(69, 13);
            this.yearsLabel.TabIndex = 50;
            this.yearsLabel.Text = "No. of Years:";
            // 
            // presentValLabel
            // 
            this.presentValLabel.AutoSize = true;
            this.presentValLabel.Location = new System.Drawing.Point(42, 135);
            this.presentValLabel.Name = "presentValLabel";
            this.presentValLabel.Size = new System.Drawing.Size(76, 13);
            this.presentValLabel.TabIndex = 70;
            this.presentValLabel.Text = "Present Value:";
            // 
            // presentValResultLabel
            // 
            this.presentValResultLabel.AutoEllipsis = true;
            this.presentValResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presentValResultLabel.Location = new System.Drawing.Point(124, 134);
            this.presentValResultLabel.Name = "presentValResultLabel";
            this.presentValResultLabel.Size = new System.Drawing.Size(100, 20);
            this.presentValResultLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 204);
            this.Controls.Add(this.presentValResultLabel);
            this.Controls.Add(this.presentValLabel);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.aprTextBox);
            this.Controls.Add(this.aprLabel);
            this.Controls.Add(this.futureValTextBox);
            this.Controls.Add(this.futureValLabel);
            this.Controls.Add(this.calcButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label futureValLabel;
        private System.Windows.Forms.TextBox futureValTextBox;
        private System.Windows.Forms.TextBox aprTextBox;
        private System.Windows.Forms.Label aprLabel;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Label presentValLabel;
        private System.Windows.Forms.Label presentValResultLabel;
    }
}

