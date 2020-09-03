namespace CurrentAddressWindowsApi
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
            this.txtTopUrlBox = new System.Windows.Forms.TextBox();
            this.txtLowResponseBox = new System.Windows.Forms.TextBox();
            this.btnCmdRequestBox = new System.Windows.Forms.Button();
            this.lblRequestUrl = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTopUrlBox
            // 
            this.txtTopUrlBox.Location = new System.Drawing.Point(170, 67);
            this.txtTopUrlBox.Name = "txtTopUrlBox";
            this.txtTopUrlBox.Size = new System.Drawing.Size(399, 20);
            this.txtTopUrlBox.TabIndex = 0;
            // 
            // txtLowResponseBox
            // 
            this.txtLowResponseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLowResponseBox.Location = new System.Drawing.Point(170, 123);
            this.txtLowResponseBox.Multiline = true;
            this.txtLowResponseBox.Name = "txtLowResponseBox";
            this.txtLowResponseBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLowResponseBox.Size = new System.Drawing.Size(523, 278);
            this.txtLowResponseBox.TabIndex = 1;
            // 
            // btnCmdRequestBox
            // 
            this.btnCmdRequestBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCmdRequestBox.Location = new System.Drawing.Point(575, 64);
            this.btnCmdRequestBox.Name = "btnCmdRequestBox";
            this.btnCmdRequestBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCmdRequestBox.Size = new System.Drawing.Size(118, 23);
            this.btnCmdRequestBox.TabIndex = 2;
            this.btnCmdRequestBox.TabStop = false;
            this.btnCmdRequestBox.Text = "Request";
            this.btnCmdRequestBox.UseVisualStyleBackColor = true;
            this.btnCmdRequestBox.Click += new System.EventHandler(this.btnCmdRequestBox_Click);
            // 
            // lblRequestUrl
            // 
            this.lblRequestUrl.AutoSize = true;
            this.lblRequestUrl.Location = new System.Drawing.Point(64, 74);
            this.lblRequestUrl.Name = "lblRequestUrl";
            this.lblRequestUrl.Size = new System.Drawing.Size(75, 13);
            this.lblRequestUrl.TabIndex = 3;
            this.lblRequestUrl.Text = "Request URL:";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(64, 123);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(58, 13);
            this.lblResponse.TabIndex = 4;
            this.lblResponse.Text = "Response:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblRequestUrl);
            this.Controls.Add(this.btnCmdRequestBox);
            this.Controls.Add(this.txtLowResponseBox);
            this.Controls.Add(this.txtTopUrlBox);
            this.Name = "Form1";
            this.Text = "GPS_API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTopUrlBox;
        private System.Windows.Forms.TextBox txtLowResponseBox;
        private System.Windows.Forms.Button btnCmdRequestBox;
        private System.Windows.Forms.Label lblRequestUrl;
        private System.Windows.Forms.Label lblResponse;
    }
}

