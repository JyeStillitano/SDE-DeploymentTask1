namespace DeploymentTask1
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
            this.AddButton = new System.Windows.Forms.Button();
            this.Value1Label = new System.Windows.Forms.Label();
            this.Value2Label = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.InputTextBox1 = new System.Windows.Forms.TextBox();
            this.InputTextBox2 = new System.Windows.Forms.TextBox();
            this.ResultOutputLabel = new System.Windows.Forms.Label();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.WelcomeButton = new System.Windows.Forms.Button();
            this.GdayButton = new System.Windows.Forms.Button();
            this.WhatsUpButton = new System.Windows.Forms.Button();
            this.GreetingOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(501, 71);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Value1Label
            // 
            this.Value1Label.AutoSize = true;
            this.Value1Label.Location = new System.Drawing.Point(53, 111);
            this.Value1Label.Name = "Value1Label";
            this.Value1Label.Size = new System.Drawing.Size(46, 13);
            this.Value1Label.TabIndex = 1;
            this.Value1Label.Text = "Value 1:";
            // 
            // Value2Label
            // 
            this.Value2Label.AutoSize = true;
            this.Value2Label.Location = new System.Drawing.Point(261, 111);
            this.Value2Label.Name = "Value2Label";
            this.Value2Label.Size = new System.Drawing.Size(46, 13);
            this.Value2Label.TabIndex = 2;
            this.Value2Label.Text = "Value 2:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(617, 111);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(40, 13);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Result:";
            // 
            // InputTextBox1
            // 
            this.InputTextBox1.Location = new System.Drawing.Point(110, 110);
            this.InputTextBox1.Name = "InputTextBox1";
            this.InputTextBox1.Size = new System.Drawing.Size(133, 20);
            this.InputTextBox1.TabIndex = 4;
            // 
            // InputTextBox2
            // 
            this.InputTextBox2.Location = new System.Drawing.Point(334, 111);
            this.InputTextBox2.Name = "InputTextBox2";
            this.InputTextBox2.Size = new System.Drawing.Size(133, 20);
            this.InputTextBox2.TabIndex = 5;
            // 
            // ResultOutputLabel
            // 
            this.ResultOutputLabel.AutoSize = true;
            this.ResultOutputLabel.Location = new System.Drawing.Point(663, 113);
            this.ResultOutputLabel.Name = "ResultOutputLabel";
            this.ResultOutputLabel.Size = new System.Drawing.Size(13, 13);
            this.ResultOutputLabel.TabIndex = 6;
            this.ResultOutputLabel.Text = "0";
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(501, 100);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(75, 23);
            this.SubtractButton.TabIndex = 7;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(501, 129);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplyButton.TabIndex = 8;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(501, 158);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 23);
            this.DivideButton.TabIndex = 9;
            this.DivideButton.Text = "Divide";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(53, 275);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name:";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(110, 272);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(357, 20);
            this.NameInput.TabIndex = 11;
            // 
            // WelcomeButton
            // 
            this.WelcomeButton.Location = new System.Drawing.Point(501, 243);
            this.WelcomeButton.Name = "WelcomeButton";
            this.WelcomeButton.Size = new System.Drawing.Size(75, 23);
            this.WelcomeButton.TabIndex = 12;
            this.WelcomeButton.Text = "Welcome";
            this.WelcomeButton.UseVisualStyleBackColor = true;
            this.WelcomeButton.Click += new System.EventHandler(this.WelcomeButton_Click);
            // 
            // GdayButton
            // 
            this.GdayButton.Location = new System.Drawing.Point(501, 272);
            this.GdayButton.Name = "GdayButton";
            this.GdayButton.Size = new System.Drawing.Size(75, 23);
            this.GdayButton.TabIndex = 13;
            this.GdayButton.Text = "G\'day";
            this.GdayButton.UseVisualStyleBackColor = true;
            this.GdayButton.Click += new System.EventHandler(this.GdayButton_Click);
            // 
            // WhatsUpButton
            // 
            this.WhatsUpButton.Location = new System.Drawing.Point(501, 301);
            this.WhatsUpButton.Name = "WhatsUpButton";
            this.WhatsUpButton.Size = new System.Drawing.Size(75, 23);
            this.WhatsUpButton.TabIndex = 14;
            this.WhatsUpButton.Text = "What\'s up?";
            this.WhatsUpButton.UseVisualStyleBackColor = true;
            this.WhatsUpButton.Click += new System.EventHandler(this.WhatsUpButton_Click);
            // 
            // GreetingOutputLabel
            // 
            this.GreetingOutputLabel.AutoSize = true;
            this.GreetingOutputLabel.Location = new System.Drawing.Point(617, 275);
            this.GreetingOutputLabel.Name = "GreetingOutputLabel";
            this.GreetingOutputLabel.Size = new System.Drawing.Size(16, 13);
            this.GreetingOutputLabel.TabIndex = 15;
            this.GreetingOutputLabel.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GreetingOutputLabel);
            this.Controls.Add(this.WhatsUpButton);
            this.Controls.Add(this.GdayButton);
            this.Controls.Add(this.WelcomeButton);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.ResultOutputLabel);
            this.Controls.Add(this.InputTextBox2);
            this.Controls.Add(this.InputTextBox1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Value2Label);
            this.Controls.Add(this.Value1Label);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label Value1Label;
        private System.Windows.Forms.Label Value2Label;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox InputTextBox1;
        private System.Windows.Forms.TextBox InputTextBox2;
        private System.Windows.Forms.Label ResultOutputLabel;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Button WelcomeButton;
        private System.Windows.Forms.Button GdayButton;
        private System.Windows.Forms.Button WhatsUpButton;
        private System.Windows.Forms.Label GreetingOutputLabel;
    }
}

