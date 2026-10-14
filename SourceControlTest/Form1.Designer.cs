namespace SourceControlTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAddition = new Label();
            txtNum1Addition = new TextBox();
            lblNum1Addition = new Label();
            lblNum2Addition = new Label();
            txtNum2Addition = new TextBox();
            lblResultAddition = new Label();
            txtResultAddition = new TextBox();
            btnCalculateAddition = new Button();
            btnCalculateSubtraction = new Button();
            txtResultSubtraction = new TextBox();
            lblResultSubtraction = new Label();
            txtNum2Subtraction = new TextBox();
            lblNum2Subtraction = new Label();
            txtNum1Subtraction = new TextBox();
            lblNum1Subtraction = new Label();
            lblSubtraction = new Label();
            SuspendLayout();
            // 
            // lblAddition
            // 
            lblAddition.AutoSize = true;
            lblAddition.Location = new Point(49, 22);
            lblAddition.Name = "lblAddition";
            lblAddition.Size = new Size(53, 15);
            lblAddition.TabIndex = 0;
            lblAddition.Text = "Addition";
            // 
            // txtNum1Addition
            // 
            txtNum1Addition.Location = new Point(58, 40);
            txtNum1Addition.Name = "txtNum1Addition";
            txtNum1Addition.Size = new Size(100, 23);
            txtNum1Addition.TabIndex = 1;
            // 
            // lblNum1Addition
            // 
            lblNum1Addition.AutoSize = true;
            lblNum1Addition.Location = new Point(9, 43);
            lblNum1Addition.Name = "lblNum1Addition";
            lblNum1Addition.Size = new Size(43, 15);
            lblNum1Addition.TabIndex = 0;
            lblNum1Addition.Text = "Num 1";
            // 
            // lblNum2Addition
            // 
            lblNum2Addition.AutoSize = true;
            lblNum2Addition.Location = new Point(9, 72);
            lblNum2Addition.Name = "lblNum2Addition";
            lblNum2Addition.Size = new Size(43, 15);
            lblNum2Addition.TabIndex = 0;
            lblNum2Addition.Text = "Num 2";
            // 
            // txtNum2Addition
            // 
            txtNum2Addition.Location = new Point(58, 69);
            txtNum2Addition.Name = "txtNum2Addition";
            txtNum2Addition.Size = new Size(100, 23);
            txtNum2Addition.TabIndex = 1;
            // 
            // lblResultAddition
            // 
            lblResultAddition.AutoSize = true;
            lblResultAddition.Location = new Point(9, 101);
            lblResultAddition.Name = "lblResultAddition";
            lblResultAddition.Size = new Size(39, 15);
            lblResultAddition.TabIndex = 0;
            lblResultAddition.Text = "Result";
            // 
            // txtResultAddition
            // 
            txtResultAddition.Location = new Point(58, 98);
            txtResultAddition.Name = "txtResultAddition";
            txtResultAddition.Size = new Size(100, 23);
            txtResultAddition.TabIndex = 1;
            // 
            // btnCalculateAddition
            // 
            btnCalculateAddition.Location = new Point(40, 127);
            btnCalculateAddition.Name = "btnCalculateAddition";
            btnCalculateAddition.Size = new Size(75, 23);
            btnCalculateAddition.TabIndex = 2;
            btnCalculateAddition.Text = "Calculate";
            btnCalculateAddition.UseVisualStyleBackColor = true;
            btnCalculateAddition.Click += btnCalculateAddition_Click;
            // 
            // btnCalculateSubtraction
            // 
            btnCalculateSubtraction.Location = new Point(425, 127);
            btnCalculateSubtraction.Name = "btnCalculateSubtraction";
            btnCalculateSubtraction.Size = new Size(75, 23);
            btnCalculateSubtraction.TabIndex = 10;
            btnCalculateSubtraction.Text = "Calculate";
            btnCalculateSubtraction.UseVisualStyleBackColor = true;
            btnCalculateSubtraction.Click += btnCalculateSubtraction_Click;
            // 
            // txtResultSubtraction
            // 
            txtResultSubtraction.Location = new Point(443, 98);
            txtResultSubtraction.Name = "txtResultSubtraction";
            txtResultSubtraction.Size = new Size(100, 23);
            txtResultSubtraction.TabIndex = 7;
            // 
            // lblResultSubtraction
            // 
            lblResultSubtraction.AutoSize = true;
            lblResultSubtraction.Location = new Point(394, 101);
            lblResultSubtraction.Name = "lblResultSubtraction";
            lblResultSubtraction.Size = new Size(39, 15);
            lblResultSubtraction.TabIndex = 3;
            lblResultSubtraction.Text = "Result";
            // 
            // txtNum2Subtraction
            // 
            txtNum2Subtraction.Location = new Point(443, 69);
            txtNum2Subtraction.Name = "txtNum2Subtraction";
            txtNum2Subtraction.Size = new Size(100, 23);
            txtNum2Subtraction.TabIndex = 8;
            // 
            // lblNum2Subtraction
            // 
            lblNum2Subtraction.AutoSize = true;
            lblNum2Subtraction.Location = new Point(394, 72);
            lblNum2Subtraction.Name = "lblNum2Subtraction";
            lblNum2Subtraction.Size = new Size(43, 15);
            lblNum2Subtraction.TabIndex = 4;
            lblNum2Subtraction.Text = "Num 2";
            // 
            // txtNum1Subtraction
            // 
            txtNum1Subtraction.Location = new Point(443, 40);
            txtNum1Subtraction.Name = "txtNum1Subtraction";
            txtNum1Subtraction.Size = new Size(100, 23);
            txtNum1Subtraction.TabIndex = 9;
            // 
            // lblNum1Subtraction
            // 
            lblNum1Subtraction.AutoSize = true;
            lblNum1Subtraction.Location = new Point(394, 43);
            lblNum1Subtraction.Name = "lblNum1Subtraction";
            lblNum1Subtraction.Size = new Size(43, 15);
            lblNum1Subtraction.TabIndex = 5;
            lblNum1Subtraction.Text = "Num 1";
            // 
            // lblSubtraction
            // 
            lblSubtraction.AutoSize = true;
            lblSubtraction.Location = new Point(434, 22);
            lblSubtraction.Name = "lblSubtraction";
            lblSubtraction.Size = new Size(68, 15);
            lblSubtraction.TabIndex = 6;
            lblSubtraction.Text = "Subtraction";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculateSubtraction);
            Controls.Add(txtResultSubtraction);
            Controls.Add(lblResultSubtraction);
            Controls.Add(txtNum2Subtraction);
            Controls.Add(lblNum2Subtraction);
            Controls.Add(txtNum1Subtraction);
            Controls.Add(lblNum1Subtraction);
            Controls.Add(lblSubtraction);
            Controls.Add(btnCalculateAddition);
            Controls.Add(txtResultAddition);
            Controls.Add(lblResultAddition);
            Controls.Add(txtNum2Addition);
            Controls.Add(lblNum2Addition);
            Controls.Add(txtNum1Addition);
            Controls.Add(lblNum1Addition);
            Controls.Add(lblAddition);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddition;
        private TextBox txtNum1Addition;
        private Label lblNum1Addition;
        private Label lblNum2Addition;
        private TextBox txtNum2Addition;
        private Label lblResultAddition;
        private TextBox txtResultAddition;
        private Button btnCalculateAddition;
        private Button btnCalculateSubtraction;
        private TextBox txtResultSubtraction;
        private Label lblResultSubtraction;
        private TextBox txtNum2Subtraction;
        private Label lblNum2Subtraction;
        private TextBox txtNum1Subtraction;
        private Label lblNum1Subtraction;
        private Label lblSubtraction;
    }
}
