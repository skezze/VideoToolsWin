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
            this.qualityLabel = new System.Windows.Forms.Label();
            this.parametersTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inputFilePathLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.compressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conversionTypeComboBox
            // 
            this.conversionTypeComboBox.FormattingEnabled = true;
            this.conversionTypeComboBox.Location = new System.Drawing.Point(371, 20);
            this.conversionTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conversionTypeComboBox.Name = "conversionTypeComboBox";
            this.conversionTypeComboBox.Size = new System.Drawing.Size(67, 23);
            this.conversionTypeComboBox.TabIndex = 6;
            this.conversionTypeComboBox.Tag = "";
            this.conversionTypeComboBox.TextUpdate += new System.EventHandler(this.selectExtension);
            this.conversionTypeComboBox.TextChanged += new System.EventHandler(this.selectExtension);
            // 
            // inputfileButton
            // 
            this.inputfileButton.Location = new System.Drawing.Point(112, 22);
            this.inputfileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputfileButton.Name = "inputfileButton";
            this.inputfileButton.Size = new System.Drawing.Size(82, 22);
            this.inputfileButton.TabIndex = 0;
            this.inputfileButton.Text = "select";
            this.inputfileButton.UseVisualStyleBackColor = true;
            this.inputfileButton.Click += new System.EventHandler(this.inputFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "select input file";
            // 
            // conversionFileButton
            // 
            this.conversionFileButton.Location = new System.Drawing.Point(498, 204);
            this.conversionFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conversionFileButton.Name = "conversionFileButton";
            this.conversionFileButton.Size = new System.Drawing.Size(82, 22);
            this.conversionFileButton.TabIndex = 2;
            this.conversionFileButton.Text = "Conversion";
            this.conversionFileButton.UseVisualStyleBackColor = true;
            this.conversionFileButton.Click += new System.EventHandler(this.conversionFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "select conversion type";
            // 
            // fileCheckBox
            // 
            this.fileCheckBox.AutoSize = true;
            this.fileCheckBox.Enabled = false;
            this.fileCheckBox.Location = new System.Drawing.Point(200, 28);
            this.fileCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileCheckBox.Name = "fileCheckBox";
            this.fileCheckBox.Size = new System.Drawing.Size(15, 14);
            this.fileCheckBox.TabIndex = 7;
            this.fileCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(230, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "drop here";
            this.label2.Visible = false;
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(458, 26);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(43, 15);
            this.qualityLabel.TabIndex = 11;
            this.qualityLabel.Text = "quality";
            this.qualityLabel.Visible = false;
            // 
            // parametersTextBox
            // 
            this.parametersTextBox.Location = new System.Drawing.Point(507, 22);
            this.parametersTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parametersTextBox.Name = "parametersTextBox";
            this.parametersTextBox.Size = new System.Drawing.Size(79, 23);
            this.parametersTextBox.TabIndex = 12;
            this.parametersTextBox.Visible = false;
            this.parametersTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 13;
            this.button1.Text = "options";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputFilePathLabel
            // 
            this.inputFilePathLabel.AutoSize = true;
            this.inputFilePathLabel.Enabled = false;
            this.inputFilePathLabel.Location = new System.Drawing.Point(10, 55);
            this.inputFilePathLabel.Name = "inputFilePathLabel";
            this.inputFilePathLabel.Size = new System.Drawing.Size(41, 15);
            this.inputFilePathLabel.TabIndex = 15;
            this.inputFilePathLabel.Text = "empty";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressLabel.Location = new System.Drawing.Point(132, 205);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(121, 21);
            this.progressLabel.TabIndex = 16;
            this.progressLabel.Text = "task is running...";
            this.progressLabel.Visible = false;
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(410, 204);
            this.compressButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(82, 22);
            this.compressButton.TabIndex = 17;
            this.compressButton.Text = "Compress";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // VideoToolsWin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(592, 237);
            this.Controls.Add(this.compressButton);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.inputFilePathLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parametersTextBox);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileCheckBox);
            this.Controls.Add(this.conversionTypeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conversionFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputfileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
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
        private Label qualityLabel;
        private TextBox parametersTextBox;
        private Button button1;
        private Label inputFilePathLabel;
        private Label progressLabel;
        private ComboBox conversionTypeComboBox;
        private Button compressButton;
    }
}