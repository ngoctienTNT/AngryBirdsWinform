
namespace Angry_Birds
{
    partial class GamePlay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lbPoint = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(10, 100);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.BackgroundImage = global::Angry_Birds.Properties.Resources.yes_button;
            this.btnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Location = new System.Drawing.Point(55, 645);
            this.btnYes.Margin = new System.Windows.Forms.Padding(0);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(150, 150);
            this.btnYes.TabIndex = 2;
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.BackgroundImage = global::Angry_Birds.Properties.Resources.no_button;
            this.btnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Location = new System.Drawing.Point(302, 645);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(150, 150);
            this.btnNo.TabIndex = 3;
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.BackColor = System.Drawing.Color.Transparent;
            this.lbPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoint.Location = new System.Drawing.Point(371, 21);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(95, 29);
            this.lbPoint.TabIndex = 4;
            this.lbPoint.Text = "Điểm: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Angry_Birds.Properties.Resources.exit_button;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(147, 21);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(156, 29);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "Thời Gian: 30";
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Angry_Birds.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 913);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 960);
            this.MinimumSize = new System.Drawing.Size(540, 960);
            this.Name = "GamePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angry Birds TNT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GamePlay_FormClosing);
            this.Load += new System.EventHandler(this.GamePlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbTime;
    }
}