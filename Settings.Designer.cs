namespace VideoToolsWin
{
    partial class Settings
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
            this.defaultVideoPathButton = new System.Windows.Forms.Button();
            this.viewDeafaultVideoFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewDeafaultPhotoFolder = new System.Windows.Forms.TextBox();
            this.defaultPhotoPathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // defaultVideoPathButton
            // 
            this.defaultVideoPathButton.Location = new System.Drawing.Point(635, 22);
            this.defaultVideoPathButton.Name = "defaultVideoPathButton";
            this.defaultVideoPathButton.Size = new System.Drawing.Size(94, 29);
            this.defaultVideoPathButton.TabIndex = 0;
            this.defaultVideoPathButton.Text = "edit";
            this.defaultVideoPathButton.UseVisualStyleBackColor = true;
            this.defaultVideoPathButton.Click += new System.EventHandler(this.defaultVideoPathButton_Click);
            // 
            // viewDeafaultVideoFolder
            // 
            this.viewDeafaultVideoFolder.Enabled = false;
            this.viewDeafaultVideoFolder.Location = new System.Drawing.Point(167, 24);
            this.viewDeafaultVideoFolder.Name = "viewDeafaultVideoFolder";
            this.viewDeafaultVideoFolder.Size = new System.Drawing.Size(453, 27);
            this.viewDeafaultVideoFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "default video folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "default photo folder";
            // 
            // viewDeafaultPhotoFolder
            // 
            this.viewDeafaultPhotoFolder.Enabled = false;
            this.viewDeafaultPhotoFolder.Location = new System.Drawing.Point(167, 95);
            this.viewDeafaultPhotoFolder.Name = "viewDeafaultPhotoFolder";
            this.viewDeafaultPhotoFolder.Size = new System.Drawing.Size(453, 27);
            this.viewDeafaultPhotoFolder.TabIndex = 4;
            // 
            // defaultPhotoPathButton
            // 
            this.defaultPhotoPathButton.Location = new System.Drawing.Point(635, 93);
            this.defaultPhotoPathButton.Name = "defaultPhotoPathButton";
            this.defaultPhotoPathButton.Size = new System.Drawing.Size(94, 29);
            this.defaultPhotoPathButton.TabIndex = 3;
            this.defaultPhotoPathButton.Text = "edit";
            this.defaultPhotoPathButton.UseVisualStyleBackColor = true;
            this.defaultPhotoPathButton.Click += new System.EventHandler(this.defaultPhotoPathButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewDeafaultPhotoFolder);
            this.Controls.Add(this.defaultPhotoPathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewDeafaultVideoFolder);
            this.Controls.Add(this.defaultVideoPathButton);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button defaultVideoPathButton;
        private TextBox viewDeafaultVideoFolder;
        private Label label1;
        private Label label2;
        private TextBox viewDeafaultPhotoFolder;
        private Button defaultPhotoPathButton;
    }
}