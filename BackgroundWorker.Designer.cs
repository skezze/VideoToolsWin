namespace VideoToolsWin
{
    partial class BackgroundWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundWorker));
            this.backgroundWorkerIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // backgroundWorkerIcon
            // 
            this.backgroundWorkerIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("backgroundWorkerIcon.Icon")));
            this.backgroundWorkerIcon.Text = "double click for open application";
            this.backgroundWorkerIcon.Visible = true;
            this.backgroundWorkerIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.backgroundWorkerIcon_MouseDoubleClick);
            // 
            // BackgroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "BackgroundWorker";
            this.Text = "BackgroundWorker";
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon backgroundWorkerIcon;
    }
}