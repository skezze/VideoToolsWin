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
            this.defaultPathButton = new System.Windows.Forms.Button();
            this.viewDeafaultFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // defaultPathButton
            // 
            this.defaultPathButton.Location = new System.Drawing.Point(627, 29);
            this.defaultPathButton.Name = "defaultPathButton";
            this.defaultPathButton.Size = new System.Drawing.Size(94, 29);
            this.defaultPathButton.TabIndex = 0;
            this.defaultPathButton.Text = "edit";
            this.defaultPathButton.UseVisualStyleBackColor = true;
            this.defaultPathButton.Click += new System.EventHandler(this.defaultPathButton_Click);
            // 
            // viewDeafaultFolder
            // 
            this.viewDeafaultFolder.Enabled = false;
            this.viewDeafaultFolder.Location = new System.Drawing.Point(150, 31);
            this.viewDeafaultFolder.Name = "viewDeafaultFolder";
            this.viewDeafaultFolder.Size = new System.Drawing.Size(453, 27);
            this.viewDeafaultFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "default folder";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewDeafaultFolder);
            this.Controls.Add(this.defaultPathButton);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button defaultPathButton;
        private TextBox viewDeafaultFolder;
        private Label label1;
    }
}