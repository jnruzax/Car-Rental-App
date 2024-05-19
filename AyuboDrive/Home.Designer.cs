namespace AyuboDrive
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.homepanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // homepanel
            // 
            this.homepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homepanel.BackgroundImage")));
            this.homepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homepanel.Location = new System.Drawing.Point(0, 0);
            this.homepanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homepanel.Name = "homepanel";
            this.homepanel.Size = new System.Drawing.Size(928, 681);
            this.homepanel.TabIndex = 0;
            this.homepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homepanel_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(928, 634);
            this.Controls.Add(this.homepanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homepanel;
    }
}