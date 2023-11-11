namespace lab3_Arduino
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
            this.SlowModeRadioBtn = new System.Windows.Forms.RadioButton();
            this.MediumModeRadioBtn = new System.Windows.Forms.RadioButton();
            this.FastModeRadioBtn = new System.Windows.Forms.RadioButton();
            this.VeryFastModeRadioBtn = new System.Windows.Forms.RadioButton();
            this.CustomModeRadioBtn = new System.Windows.Forms.RadioButton();
            this.CustomModeTextBox = new System.Windows.Forms.TextBox();
            this.StaticRadioBtn = new System.Windows.Forms.RadioButton();
            this.OnOffBtn = new System.Windows.Forms.Button();
            this.OnOffTextField = new System.Windows.Forms.TextBox();
            this.SetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SlowModeRadioBtn
            // 
            this.SlowModeRadioBtn.AutoSize = true;
            this.SlowModeRadioBtn.Location = new System.Drawing.Point(47, 107);
            this.SlowModeRadioBtn.Name = "SlowModeRadioBtn";
            this.SlowModeRadioBtn.Size = new System.Drawing.Size(113, 24);
            this.SlowModeRadioBtn.TabIndex = 3;
            this.SlowModeRadioBtn.TabStop = true;
            this.SlowModeRadioBtn.Text = "Slowe Mode";
            this.SlowModeRadioBtn.UseVisualStyleBackColor = true;
            this.SlowModeRadioBtn.CheckedChanged += new System.EventHandler(this.SlowModeRadioBtn_CheckedChanged);
            // 
            // MediumModeRadioBtn
            // 
            this.MediumModeRadioBtn.AutoSize = true;
            this.MediumModeRadioBtn.Location = new System.Drawing.Point(47, 137);
            this.MediumModeRadioBtn.Name = "MediumModeRadioBtn";
            this.MediumModeRadioBtn.Size = new System.Drawing.Size(128, 24);
            this.MediumModeRadioBtn.TabIndex = 4;
            this.MediumModeRadioBtn.TabStop = true;
            this.MediumModeRadioBtn.Text = "Medium Mode";
            this.MediumModeRadioBtn.UseVisualStyleBackColor = true;
            this.MediumModeRadioBtn.CheckedChanged += new System.EventHandler(this.MediumModeRadioBtn_CheckedChanged);
            // 
            // FastModeRadioBtn
            // 
            this.FastModeRadioBtn.AutoSize = true;
            this.FastModeRadioBtn.Location = new System.Drawing.Point(47, 167);
            this.FastModeRadioBtn.Name = "FastModeRadioBtn";
            this.FastModeRadioBtn.Size = new System.Drawing.Size(98, 24);
            this.FastModeRadioBtn.TabIndex = 5;
            this.FastModeRadioBtn.TabStop = true;
            this.FastModeRadioBtn.Text = "Fast Mode";
            this.FastModeRadioBtn.UseVisualStyleBackColor = true;
            this.FastModeRadioBtn.CheckedChanged += new System.EventHandler(this.FastModeRadioBtn_CheckedChanged);
            // 
            // VeryFastModeRadioBtn
            // 
            this.VeryFastModeRadioBtn.AutoSize = true;
            this.VeryFastModeRadioBtn.Location = new System.Drawing.Point(47, 197);
            this.VeryFastModeRadioBtn.Name = "VeryFastModeRadioBtn";
            this.VeryFastModeRadioBtn.Size = new System.Drawing.Size(130, 24);
            this.VeryFastModeRadioBtn.TabIndex = 6;
            this.VeryFastModeRadioBtn.TabStop = true;
            this.VeryFastModeRadioBtn.Text = "Very Fast Mode";
            this.VeryFastModeRadioBtn.UseVisualStyleBackColor = true;
            this.VeryFastModeRadioBtn.CheckedChanged += new System.EventHandler(this.VeryFastModeRadioBtn_CheckedChanged);
            // 
            // CustomModeRadioBtn
            // 
            this.CustomModeRadioBtn.AutoSize = true;
            this.CustomModeRadioBtn.Location = new System.Drawing.Point(47, 227);
            this.CustomModeRadioBtn.Name = "CustomModeRadioBtn";
            this.CustomModeRadioBtn.Size = new System.Drawing.Size(123, 24);
            this.CustomModeRadioBtn.TabIndex = 7;
            this.CustomModeRadioBtn.TabStop = true;
            this.CustomModeRadioBtn.Text = "Custom Mode";
            this.CustomModeRadioBtn.UseVisualStyleBackColor = true;
            this.CustomModeRadioBtn.CheckedChanged += new System.EventHandler(this.CustomModeRadioBtn_CheckedChanged);
            // 
            // CustomModeTextBox
            // 
            this.CustomModeTextBox.Location = new System.Drawing.Point(191, 226);
            this.CustomModeTextBox.Name = "CustomModeTextBox";
            this.CustomModeTextBox.Size = new System.Drawing.Size(147, 27);
            this.CustomModeTextBox.TabIndex = 8;
            this.CustomModeTextBox.Text = "500";
            this.CustomModeTextBox.TextChanged += new System.EventHandler(this.CustomModeTextBox_TextChanged);
            // 
            // StaticRadioBtn
            // 
            this.StaticRadioBtn.AutoSize = true;
            this.StaticRadioBtn.Location = new System.Drawing.Point(47, 77);
            this.StaticRadioBtn.Name = "StaticRadioBtn";
            this.StaticRadioBtn.Size = new System.Drawing.Size(110, 24);
            this.StaticRadioBtn.TabIndex = 10;
            this.StaticRadioBtn.TabStop = true;
            this.StaticRadioBtn.Text = "Static Mode";
            this.StaticRadioBtn.UseVisualStyleBackColor = true;
            this.StaticRadioBtn.CheckedChanged += new System.EventHandler(this.StaticRadioBtn_CheckedChanged);
            // 
            // OnOffBtn
            // 
            this.OnOffBtn.Location = new System.Drawing.Point(47, 367);
            this.OnOffBtn.Name = "OnOffBtn";
            this.OnOffBtn.Size = new System.Drawing.Size(94, 29);
            this.OnOffBtn.TabIndex = 11;
            this.OnOffBtn.Text = "Press";
            this.OnOffBtn.UseVisualStyleBackColor = true;
            this.OnOffBtn.Click += new System.EventHandler(this.OnOffBtn_Click);
            // 
            // OnOffTextField
            // 
            this.OnOffTextField.Location = new System.Drawing.Point(162, 367);
            this.OnOffTextField.Name = "OnOffTextField";
            this.OnOffTextField.ReadOnly = true;
            this.OnOffTextField.Size = new System.Drawing.Size(46, 27);
            this.OnOffTextField.TabIndex = 12;
            this.OnOffTextField.Text = "Off";
            // 
            // SetBtn
            // 
            this.SetBtn.Location = new System.Drawing.Point(344, 227);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(42, 29);
            this.SetBtn.TabIndex = 13;
            this.SetBtn.Text = "Ok";
            this.SetBtn.UseVisualStyleBackColor = true;
            this.SetBtn.Click += new System.EventHandler(this.SetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetBtn);
            this.Controls.Add(this.OnOffTextField);
            this.Controls.Add(this.OnOffBtn);
            this.Controls.Add(this.StaticRadioBtn);
            this.Controls.Add(this.CustomModeTextBox);
            this.Controls.Add(this.CustomModeRadioBtn);
            this.Controls.Add(this.VeryFastModeRadioBtn);
            this.Controls.Add(this.FastModeRadioBtn);
            this.Controls.Add(this.MediumModeRadioBtn);
            this.Controls.Add(this.SlowModeRadioBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton SlowModeRadioBtn;
        private RadioButton MediumModeRadioBtn;
        private RadioButton FastModeRadioBtn;
        private RadioButton VeryFastModeRadioBtn;
        private RadioButton CustomModeRadioBtn;
        private TextBox CustomModeTextBox;
        private RadioButton StaticRadioBtn;
        private Button OnOffBtn;
        private TextBox OnOffTextField;
        private Button SetBtn;
    }
}