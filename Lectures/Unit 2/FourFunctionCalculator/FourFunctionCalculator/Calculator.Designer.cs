namespace FourFunctionCalculator
{
    partial class Calculator
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
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LHS = new System.Windows.Forms.TextBox();
            this.RHS = new System.Windows.Forms.TextBox();
            this.OperatorLabel = new System.Windows.Forms.Label();
            this.EqualsLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(12, 119);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(37, 23);
            this.PlusButton.TabIndex = 0;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(65, 119);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(37, 23);
            this.MinusButton.TabIndex = 1;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Location = new System.Drawing.Point(118, 119);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(37, 23);
            this.MultiplicationButton.TabIndex = 2;
            this.MultiplicationButton.Text = "x";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(179, 119);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(37, 23);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // AnswerButton
            // 
            this.AnswerButton.Location = new System.Drawing.Point(234, 119);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(52, 23);
            this.AnswerButton.TabIndex = 4;
            this.AnswerButton.Text = "Answer";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(303, 119);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(47, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LHS
            // 
            this.LHS.Location = new System.Drawing.Point(8, 43);
            this.LHS.Name = "LHS";
            this.LHS.Size = new System.Drawing.Size(100, 20);
            this.LHS.TabIndex = 6;
            this.LHS.Text = "0";
            // 
            // RHS
            // 
            this.RHS.Location = new System.Drawing.Point(131, 43);
            this.RHS.Name = "RHS";
            this.RHS.Size = new System.Drawing.Size(108, 20);
            this.RHS.TabIndex = 7;
            this.RHS.Text = "0";
            this.RHS.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // OperatorLabel
            // 
            this.OperatorLabel.AutoSize = true;
            this.OperatorLabel.Location = new System.Drawing.Point(115, 49);
            this.OperatorLabel.Name = "OperatorLabel";
            this.OperatorLabel.Size = new System.Drawing.Size(0, 13);
            this.OperatorLabel.TabIndex = 8;
            // 
            // EqualsLabel
            // 
            this.EqualsLabel.AutoSize = true;
            this.EqualsLabel.Location = new System.Drawing.Point(245, 50);
            this.EqualsLabel.Name = "EqualsLabel";
            this.EqualsLabel.Size = new System.Drawing.Size(13, 13);
            this.EqualsLabel.TabIndex = 9;
            this.EqualsLabel.Text = "=";
            this.EqualsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(264, 49);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(0, 13);
            this.AnswerLabel.TabIndex = 10;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 261);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.EqualsLabel);
            this.Controls.Add(this.OperatorLabel);
            this.Controls.Add(this.RHS);
            this.Controls.Add(this.LHS);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox LHS;
        private System.Windows.Forms.TextBox RHS;
        private System.Windows.Forms.Label OperatorLabel;
        private System.Windows.Forms.Label EqualsLabel;
        private System.Windows.Forms.Label AnswerLabel;
    }
}

