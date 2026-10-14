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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
