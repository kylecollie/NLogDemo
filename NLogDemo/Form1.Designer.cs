namespace NLogDemo
{
    partial class frmNLogDemo
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
            this.btnTrace = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnWarn = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnFatal = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.tbxDividend = new System.Windows.Forms.TextBox();
            this.tbxDivisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrace
            // 
            this.btnTrace.Location = new System.Drawing.Point(167, 23);
            this.btnTrace.Name = "btnTrace";
            this.btnTrace.Size = new System.Drawing.Size(209, 54);
            this.btnTrace.TabIndex = 0;
            this.btnTrace.Text = "Trace";
            this.btnTrace.UseVisualStyleBackColor = true;
            this.btnTrace.Click += new System.EventHandler(this.btnTrace_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(167, 108);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(209, 54);
            this.btnDebug.TabIndex = 1;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(167, 193);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(209, 54);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnWarn
            // 
            this.btnWarn.Location = new System.Drawing.Point(167, 278);
            this.btnWarn.Name = "btnWarn";
            this.btnWarn.Size = new System.Drawing.Size(209, 54);
            this.btnWarn.TabIndex = 3;
            this.btnWarn.Text = "Warn";
            this.btnWarn.UseVisualStyleBackColor = true;
            this.btnWarn.Click += new System.EventHandler(this.btnWarn_Click);
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(167, 363);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(209, 54);
            this.btnError.TabIndex = 4;
            this.btnError.Text = "Error";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnFatal
            // 
            this.btnFatal.Location = new System.Drawing.Point(167, 448);
            this.btnFatal.Name = "btnFatal";
            this.btnFatal.Size = new System.Drawing.Size(209, 54);
            this.btnFatal.TabIndex = 5;
            this.btnFatal.Text = "Fatal";
            this.btnFatal.UseVisualStyleBackColor = true;
            this.btnFatal.Click += new System.EventHandler(this.btnFatal_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(167, 533);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(209, 54);
            this.btnOff.TabIndex = 6;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // tbxDividend
            // 
            this.tbxDividend.Location = new System.Drawing.Point(415, 379);
            this.tbxDividend.Name = "tbxDividend";
            this.tbxDividend.Size = new System.Drawing.Size(37, 22);
            this.tbxDividend.TabIndex = 7;
            // 
            // tbxDivisor
            // 
            this.tbxDivisor.Location = new System.Drawing.Point(476, 379);
            this.tbxDivisor.Name = "tbxDivisor";
            this.tbxDivisor.Size = new System.Drawing.Size(37, 22);
            this.tbxDivisor.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "/";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(437, 417);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 17);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "label2";
            this.lblResult.Visible = false;
            // 
            // frmNLogDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 614);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDivisor);
            this.Controls.Add(this.tbxDividend);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnFatal);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnWarn);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnTrace);
            this.Name = "frmNLogDemo";
            this.Text = "NLog Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrace;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnWarn;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnFatal;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.TextBox tbxDividend;
        private System.Windows.Forms.TextBox tbxDivisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}

