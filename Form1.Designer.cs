namespace QuickDelimiter
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
            this.lblSourceData = new System.Windows.Forms.Label();
            this.txtSourceData = new System.Windows.Forms.TextBox();
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.chkTrimSourceData = new System.Windows.Forms.CheckBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnCopyOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSourceData
            // 
            this.lblSourceData.AutoSize = true;
            this.lblSourceData.Location = new System.Drawing.Point(12, 19);
            this.lblSourceData.Name = "lblSourceData";
            this.lblSourceData.Size = new System.Drawing.Size(162, 13);
            this.lblSourceData.TabIndex = 0;
            this.lblSourceData.Text = "Source data (one value per row):";
            // 
            // txtSourceData
            // 
            this.txtSourceData.AcceptsReturn = true;
            this.txtSourceData.Location = new System.Drawing.Point(15, 35);
            this.txtSourceData.Multiline = true;
            this.txtSourceData.Name = "txtSourceData";
            this.txtSourceData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSourceData.Size = new System.Drawing.Size(429, 315);
            this.txtSourceData.TabIndex = 1;
            this.txtSourceData.WordWrap = false;
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.Location = new System.Drawing.Point(470, 19);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(50, 13);
            this.lblDelimiter.TabIndex = 2;
            this.lblDelimiter.Text = "Delimiter:";
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Location = new System.Drawing.Point(473, 35);
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(173, 20);
            this.txtDelimiter.TabIndex = 3;
            this.txtDelimiter.Text = ",";
            this.txtDelimiter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDelimiter_KeyPress);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(662, 33);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 391);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 416);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(722, 20);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(470, 93);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(36, 13);
            this.lblPrefix.TabIndex = 7;
            this.lblPrefix.Text = "Prefix:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(473, 109);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(173, 20);
            this.txtPrefix.TabIndex = 8;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(473, 164);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(173, 20);
            this.txtSuffix.TabIndex = 10;
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(470, 148);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(36, 13);
            this.lblSuffix.TabIndex = 9;
            this.lblSuffix.Text = "Suffix:";
            // 
            // chkTrimSourceData
            // 
            this.chkTrimSourceData.AutoSize = true;
            this.chkTrimSourceData.Checked = true;
            this.chkTrimSourceData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrimSourceData.Location = new System.Drawing.Point(473, 218);
            this.chkTrimSourceData.Name = "chkTrimSourceData";
            this.chkTrimSourceData.Size = new System.Drawing.Size(130, 17);
            this.chkTrimSourceData.TabIndex = 11;
            this.chkTrimSourceData.Text = "Trim source data rows";
            this.chkTrimSourceData.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Location = new System.Drawing.Point(518, 386);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(219, 23);
            this.lblCount.TabIndex = 12;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCopyOutput
            // 
            this.btnCopyOutput.Enabled = false;
            this.btnCopyOutput.Location = new System.Drawing.Point(60, 386);
            this.btnCopyOutput.Name = "btnCopyOutput";
            this.btnCopyOutput.Size = new System.Drawing.Size(125, 23);
            this.btnCopyOutput.TabIndex = 13;
            this.btnCopyOutput.Text = "Copy to Clipboard";
            this.btnCopyOutput.UseVisualStyleBackColor = true;
            this.btnCopyOutput.Click += new System.EventHandler(this.btnCopyOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 456);
            this.Controls.Add(this.btnCopyOutput);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.chkTrimSourceData);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtDelimiter);
            this.Controls.Add(this.lblDelimiter);
            this.Controls.Add(this.txtSourceData);
            this.Controls.Add(this.lblSourceData);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Quick Delimiter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSourceData;
        private System.Windows.Forms.TextBox txtSourceData;
        private System.Windows.Forms.Label lblDelimiter;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.CheckBox chkTrimSourceData;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnCopyOutput;
    }
}

