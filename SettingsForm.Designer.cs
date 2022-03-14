namespace VideoToolsWin
{
    partial class SettingsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.usingGpuCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // defaultVideoPathButton
            // 
            this.defaultVideoPathButton.Location = new System.Drawing.Point(556, 16);
            this.defaultVideoPathButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.defaultVideoPathButton.Name = "defaultVideoPathButton";
            this.defaultVideoPathButton.Size = new System.Drawing.Size(82, 22);
            this.defaultVideoPathButton.TabIndex = 0;
            this.defaultVideoPathButton.Text = "edit";
            this.defaultVideoPathButton.UseVisualStyleBackColor = true;
            this.defaultVideoPathButton.Click += new System.EventHandler(this.defaultVideoPathButton_Click);
            // 
            // viewDeafaultVideoFolder
            // 
            this.viewDeafaultVideoFolder.Enabled = false;
            this.viewDeafaultVideoFolder.Location = new System.Drawing.Point(146, 18);
            this.viewDeafaultVideoFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewDeafaultVideoFolder.Name = "viewDeafaultVideoFolder";
            this.viewDeafaultVideoFolder.Size = new System.Drawing.Size(397, 23);
            this.viewDeafaultVideoFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "default video folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "default photo folder";
            // 
            // viewDeafaultPhotoFolder
            // 
            this.viewDeafaultPhotoFolder.Enabled = false;
            this.viewDeafaultPhotoFolder.Location = new System.Drawing.Point(146, 71);
            this.viewDeafaultPhotoFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewDeafaultPhotoFolder.Name = "viewDeafaultPhotoFolder";
            this.viewDeafaultPhotoFolder.Size = new System.Drawing.Size(397, 23);
            this.viewDeafaultPhotoFolder.TabIndex = 4;
            // 
            // defaultPhotoPathButton
            // 
            this.defaultPhotoPathButton.Location = new System.Drawing.Point(556, 70);
            this.defaultPhotoPathButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.defaultPhotoPathButton.Name = "defaultPhotoPathButton";
            this.defaultPhotoPathButton.Size = new System.Drawing.Size(82, 22);
            this.defaultPhotoPathButton.TabIndex = 3;
            this.defaultPhotoPathButton.Text = "edit";
            this.defaultPhotoPathButton.UseVisualStyleBackColor = true;
            this.defaultPhotoPathButton.Click += new System.EventHandler(this.defaultPhotoPathButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "using gpu(restart)";
            this.label3.Visible = false;
            // 
            // usingGpuCheckBox
            // 
            this.usingGpuCheckBox.AutoSize = true;
            this.usingGpuCheckBox.Location = new System.Drawing.Point(122, 129);
            this.usingGpuCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usingGpuCheckBox.Name = "usingGpuCheckBox";
            this.usingGpuCheckBox.Size = new System.Drawing.Size(15, 14);
            this.usingGpuCheckBox.TabIndex = 7;
            this.usingGpuCheckBox.UseVisualStyleBackColor = true;
            this.usingGpuCheckBox.Visible = false;
            this.usingGpuCheckBox.CheckedChanged += new System.EventHandler(this.usingGpuCheckBox_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 178);
            this.Controls.Add(this.usingGpuCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewDeafaultPhotoFolder);
            this.Controls.Add(this.defaultPhotoPathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewDeafaultVideoFolder);
            this.Controls.Add(this.defaultVideoPathButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
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
        private Label label3;
        private CheckBox usingGpuCheckBox;
    }
}