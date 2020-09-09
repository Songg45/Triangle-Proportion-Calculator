namespace Triangle_Proportion_Calculator
{
    partial class TPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TPC));
            this.Calculate = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.SideAInput = new System.Windows.Forms.TextBox();
            this.SideXInput = new System.Windows.Forms.TextBox();
            this.SideBInput = new System.Windows.Forms.TextBox();
            this.SideYInput = new System.Windows.Forms.TextBox();
            this.SideCInput = new System.Windows.Forms.TextBox();
            this.SideZInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ThreeLabel = new System.Windows.Forms.Label();
            this.TwoThreePicker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calculate.Location = new System.Drawing.Point(149, 102);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Location = new System.Drawing.Point(12, 131);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(415, 125);
            this.OutputBox.TabIndex = 4;
            this.OutputBox.Text = "";
            // 
            // SideAInput
            // 
            this.SideAInput.Location = new System.Drawing.Point(12, 46);
            this.SideAInput.Name = "SideAInput";
            this.SideAInput.Size = new System.Drawing.Size(100, 22);
            this.SideAInput.TabIndex = 5;
            // 
            // SideXInput
            // 
            this.SideXInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SideXInput.Location = new System.Drawing.Point(12, 74);
            this.SideXInput.Name = "SideXInput";
            this.SideXInput.Size = new System.Drawing.Size(100, 22);
            this.SideXInput.TabIndex = 6;
            // 
            // SideBInput
            // 
            this.SideBInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SideBInput.Location = new System.Drawing.Point(149, 46);
            this.SideBInput.Name = "SideBInput";
            this.SideBInput.Size = new System.Drawing.Size(100, 22);
            this.SideBInput.TabIndex = 7;
            // 
            // SideYInput
            // 
            this.SideYInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SideYInput.Location = new System.Drawing.Point(149, 74);
            this.SideYInput.Name = "SideYInput";
            this.SideYInput.Size = new System.Drawing.Size(100, 22);
            this.SideYInput.TabIndex = 8;
            // 
            // SideCInput
            // 
            this.SideCInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SideCInput.Location = new System.Drawing.Point(282, 46);
            this.SideCInput.Name = "SideCInput";
            this.SideCInput.Size = new System.Drawing.Size(100, 22);
            this.SideCInput.TabIndex = 9;
            this.SideCInput.Visible = false;
            // 
            // SideZInput
            // 
            this.SideZInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SideZInput.Location = new System.Drawing.Point(282, 74);
            this.SideZInput.Name = "SideZInput";
            this.SideZInput.Size = new System.Drawing.Size(100, 22);
            this.SideZInput.TabIndex = 10;
            this.SideZInput.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "=";
            // 
            // ThreeLabel
            // 
            this.ThreeLabel.AutoSize = true;
            this.ThreeLabel.Location = new System.Drawing.Point(255, 63);
            this.ThreeLabel.Name = "ThreeLabel";
            this.ThreeLabel.Size = new System.Drawing.Size(16, 17);
            this.ThreeLabel.TabIndex = 12;
            this.ThreeLabel.Text = "=";
            this.ThreeLabel.Visible = false;
            // 
            // TwoThreePicker
            // 
            this.TwoThreePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TwoThreePicker.FormattingEnabled = true;
            this.TwoThreePicker.Items.AddRange(new object[] {
            "Two"});
            this.TwoThreePicker.Location = new System.Drawing.Point(199, 12);
            this.TwoThreePicker.Name = "TwoThreePicker";
            this.TwoThreePicker.Size = new System.Drawing.Size(100, 24);
            this.TwoThreePicker.TabIndex = 13;
            this.TwoThreePicker.SelectedIndexChanged += new System.EventHandler(this.TwoThreePicker_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Two or Three?";
            // 
            // TPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TwoThreePicker);
            this.Controls.Add(this.ThreeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SideZInput);
            this.Controls.Add(this.SideCInput);
            this.Controls.Add(this.SideYInput);
            this.Controls.Add(this.SideBInput);
            this.Controls.Add(this.SideXInput);
            this.Controls.Add(this.SideAInput);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.Calculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TPC";
            this.Text = "Triangle Proportion Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.TextBox SideAInput;
        private System.Windows.Forms.TextBox SideXInput;
        private System.Windows.Forms.TextBox SideBInput;
        private System.Windows.Forms.TextBox SideYInput;
        private System.Windows.Forms.TextBox SideCInput;
        private System.Windows.Forms.TextBox SideZInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ThreeLabel;
        private System.Windows.Forms.ComboBox TwoThreePicker;
        private System.Windows.Forms.Label label3;
    }
}

