namespace ConfigitWinClient
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
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrint = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbPrint = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(37, 55);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color";
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(37, 88);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(28, 13);
            this.lblPrint.TabIndex = 1;
            this.lblPrint.Text = "Print";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(37, 118);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(74, 52);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(95, 21);
            this.cbColor.TabIndex = 3;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // cbPrint
            // 
            this.cbPrint.FormattingEnabled = true;
            this.cbPrint.Location = new System.Drawing.Point(74, 88);
            this.cbPrint.Name = "cbPrint";
            this.cbPrint.Size = new System.Drawing.Size(95, 21);
            this.cbPrint.TabIndex = 4;
            this.cbPrint.SelectedIndexChanged += new System.EventHandler(this.cbPrint_SelectedIndexChanged);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(74, 118);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(95, 21);
            this.cbSize.TabIndex = 5;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(74, 160);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.cbPrint);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.lblColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbPrint;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Button btnReset;
    }
}

