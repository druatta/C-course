namespace WindowsFormHelloWorld
{
    partial class GUI
    {
        
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            this.TestButton = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(82, 63);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(119, 75);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "TestButton";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.ButtonHasBeenClicked);
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Location = new System.Drawing.Point(112, 164);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(54, 13);
            this.Test.TabIndex = 1;
            this.Test.Text = "TestLabel";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.TestButton);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label Test;
    }
}

