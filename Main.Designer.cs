namespace VideoToolsWin
{
    partial class VideoToolsWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoToolsWin));
            this.conversionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.inputfileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.conversionFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fileCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enabled_lossles = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputFilePathLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conversionTypeComboBox
            // 
            this.conversionTypeComboBox.FormattingEnabled = true;
            this.conversionTypeComboBox.Location = new System.Drawing.Point(424, 26);
            this.conversionTypeComboBox.Name = "conversionTypeComboBox";
            this.conversionTypeComboBox.Size = new System.Drawing.Size(76, 28);
            this.conversionTypeComboBox.TabIndex = 6;
            this.conversionTypeComboBox.Tag = "";
            this.conversionTypeComboBox.TextUpdate += new System.EventHandler(this.selectExtension);
            this.conversionTypeComboBox.TextChanged += new System.EventHandler(this.selectExtension);
            // 
            // inputfileButton
            // 
            this.inputfileButton.Location = new System.Drawing.Point(128, 30);
            this.inputfileButton.Name = "inputfileButton";
            this.inputfileButton.Size = new System.Drawing.Size(94, 29);
            this.inputfileButton.TabIndex = 0;
            this.inputfileButton.Text = "select";
            this.inputfileButton.UseVisualStyleBackColor = true;
            this.inputfileButton.Click += new System.EventHandler(this.inputfileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "select input file";
            // 
            // conversionFileButton
            // 
            this.conversionFileButton.Location = new System.Drawing.Point(694, 409);
            this.conversionFileButton.Name = "conversionFileButton";
            this.conversionFileButton.Size = new System.Drawing.Size(94, 29);
            this.conversionFileButton.TabIndex = 2;
            this.conversionFileButton.Text = "Conversion";
            this.conversionFileButton.UseVisualStyleBackColor = true;
            this.conversionFileButton.Click += new System.EventHandler(this.conversionFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "select conversion type";
            // 
            // fileCheckBox
            // 
            this.fileCheckBox.AutoSize = true;
            this.fileCheckBox.Enabled = false;
            this.fileCheckBox.Location = new System.Drawing.Point(228, 37);
            this.fileCheckBox.Name = "fileCheckBox";
            this.fileCheckBox.Size = new System.Drawing.Size(18, 17);
            this.fileCheckBox.TabIndex = 7;
            this.fileCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(328, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "drop here";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Losless";
            // 
            // enabled_lossles
            // 
            this.enabled_lossles.AutoSize = true;
            this.enabled_lossles.Location = new System.Drawing.Point(579, 37);
            this.enabled_lossles.Name = "enabled_lossles";
            this.enabled_lossles.Size = new System.Drawing.Size(18, 17);
            this.enabled_lossles.TabIndex = 10;
            this.enabled_lossles.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "add options";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(698, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 27);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "options";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputFilePathLabel
            // 
            this.inputFilePathLabel.AutoSize = true;
            this.inputFilePathLabel.Enabled = false;
            this.inputFilePathLabel.Location = new System.Drawing.Point(12, 73);
            this.inputFilePathLabel.Name = "inputFilePathLabel";
            this.inputFilePathLabel.Size = new System.Drawing.Size(51, 20);
            this.inputFilePathLabel.TabIndex = 15;
            this.inputFilePathLabel.Text = "empty";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressLabel.Location = new System.Drawing.Point(139, 406);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(150, 28);
            this.progressLabel.TabIndex = 16;
            this.progressLabel.Text = "task is running...";
            this.progressLabel.Visible = false;
            // 
            // VideoToolsWin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.inputFilePathLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enabled_lossles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileCheckBox);
            this.Controls.Add(this.conversionTypeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conversionFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputfileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoToolsWin";
            this.Text = "VideoToolsWin";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideoToolsWin_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.VideoToolsWin_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.VideoToolsWin_DragOver);
            this.DragLeave += new System.EventHandler(this.VideoToolsWin_DragLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button inputfileButton;
        private Label label1;
        private Button conversionFileButton;
        private Label label3;
        private CheckBox fileCheckBox;
        private Label label2;
        private Label label4;
        private CheckBox enabled_lossles;
        private Label label5;
        private TextBox textBox1;
        private Button button1;
        private Label inputFilePathLabel;
        private Label progressLabel;
        private ComboBox conversionTypeComboBox;
    }
}