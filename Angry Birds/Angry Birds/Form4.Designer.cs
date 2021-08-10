
namespace Angry_Birds
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.SuspendLayout();
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geckoWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.geckoWebBrowser1.MaximumSize = new System.Drawing.Size(520, 940);
            this.geckoWebBrowser1.MinimumSize = new System.Drawing.Size(520, 940);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(520, 940);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 913);
            this.Controls.Add(this.geckoWebBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 960);
            this.MinimumSize = new System.Drawing.Size(540, 960);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angry Birds TNT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.About_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Gecko.GeckoWebBrowser geckoWebBrowser1;
    }
}