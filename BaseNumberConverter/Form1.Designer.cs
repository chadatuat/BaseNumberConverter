using System;

namespace BaseNumberConverter
{
    partial class MainWindows
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.inputValueLabel = new System.Windows.Forms.Label();
            this.inputNumberBaseLabel = new System.Windows.Forms.Label();
            this.inputValueTB = new System.Windows.Forms.TextBox();
            this.outputNumberBaseLabel = new System.Windows.Forms.Label();
            this.inputNumberBaseLB = new System.Windows.Forms.ListBox();
            this.outputNumberLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(153, 10);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputValueLabel
            // 
            this.inputValueLabel.AutoSize = true;
            this.inputValueLabel.Location = new System.Drawing.Point(13, 13);
            this.inputValueLabel.Name = "inputValueLabel";
            this.inputValueLabel.Size = new System.Drawing.Size(60, 13);
            this.inputValueLabel.TabIndex = 1;
            this.inputValueLabel.Text = "Input value";
            this.inputValueLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputNumberBaseLabel
            // 
            this.inputNumberBaseLabel.AutoSize = true;
            this.inputNumberBaseLabel.Location = new System.Drawing.Point(13, 42);
            this.inputNumberBaseLabel.Name = "inputNumberBaseLabel";
            this.inputNumberBaseLabel.Size = new System.Drawing.Size(95, 13);
            this.inputNumberBaseLabel.TabIndex = 2;
            this.inputNumberBaseLabel.Text = "Input number base";
            // 
            // inputValueTB
            // 
            this.inputValueTB.Location = new System.Drawing.Point(79, 12);
            this.inputValueTB.Name = "inputValueTB";
            this.inputValueTB.Size = new System.Drawing.Size(59, 20);
            this.inputValueTB.TabIndex = 3;
            // 
            // outputNumberBaseLabel
            // 
            this.outputNumberBaseLabel.AutoSize = true;
            this.outputNumberBaseLabel.Location = new System.Drawing.Point(135, 42);
            this.outputNumberBaseLabel.Name = "outputNumberBaseLabel";
            this.outputNumberBaseLabel.Size = new System.Drawing.Size(103, 13);
            this.outputNumberBaseLabel.TabIndex = 5;
            this.outputNumberBaseLabel.Text = "Output number base";
            this.outputNumberBaseLabel.Click += new System.EventHandler(this.outputNumberBaseLabel_Click);
            // 
            // inputNumberBaseLB
            // 
            this.inputNumberBaseLB.FormattingEnabled = true;
            this.inputNumberBaseLB.Location = new System.Drawing.Point(16, 70);
            this.inputNumberBaseLB.Name = "inputNumberBaseLB";
            this.inputNumberBaseLB.Size = new System.Drawing.Size(100, 82);
            this.inputNumberBaseLB.TabIndex = 6;
            this.inputNumberBaseLB.SelectedIndexChanged += new System.EventHandler(this.inputNumberBaseLB_SelectedIndexChanged);
            // 
            // outputNumberLB
            // 
            this.outputNumberLB.FormattingEnabled = true;
            this.outputNumberLB.Location = new System.Drawing.Point(138, 70);
            this.outputNumberLB.Name = "outputNumberLB";
            this.outputNumberLB.Size = new System.Drawing.Size(100, 82);
            this.outputNumberLB.TabIndex = 7;
            this.outputNumberLB.SelectedIndexChanged += new System.EventHandler(this.outputNumberLB_SelectedIndexChanged);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 167);
            this.Controls.Add(this.outputNumberLB);
            this.Controls.Add(this.inputNumberBaseLB);
            this.Controls.Add(this.outputNumberBaseLabel);
            this.Controls.Add(this.inputValueTB);
            this.Controls.Add(this.inputNumberBaseLabel);
            this.Controls.Add(this.inputValueLabel);
            this.Controls.Add(this.ConvertButton);
            this.Name = "MainWindows";
            this.Text = "Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label inputValueLabel;
        private System.Windows.Forms.Label inputNumberBaseLabel;
        private System.Windows.Forms.TextBox inputValueTB;
        private System.Windows.Forms.Label outputNumberBaseLabel;
        private System.Windows.Forms.ListBox inputNumberBaseLB;
        private System.Windows.Forms.ListBox outputNumberLB;
    }
}

