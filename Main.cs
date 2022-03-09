using System.Diagnostics;

namespace VideoToolsWin
{
    public partial class VideoToolsWin : Form
    {
        public VideoToolsWin()
        {
            InitializeComponent();
            GetDefaultStorages();
            targetProcessName = "VideoToolsWin";
            if (Process.GetProcessesByName(targetProcessName).Length > 1)
            {
                MessageBox.Show("1 more process started");
                this.Close();
                Application.Exit();
            }
        }
        private bool convesion_state;
        private string selected_extension;
        private string inputVideoFile;
        private string outputVideoFile;
        private string inputPhotoFile;
        private string outputPhotoFile;
        private string parameters;
        public delegate void InvokeDelegate();
        private string lossles_parameter = "-qscale 0";
        private string[] suported_extension = {
        ".avi",".mkv", ".mp4",".flv",".webm"
        };
        private string defaultVideoStorage;
        private string defaultPhotoStorage;
        string targetProcessName;
        private void GetDefaultStorages()
        {
            try
            {
                if (File.Exists(@"D:\defaultVideoFolder.txt") && new FileInfo(@"D:\defaultVideoFolder.txt").Length != 0)
                {
                    defaultVideoStorage = File.ReadAllText(@"D:\defaultVideoFolder.txt");
                }
                else
                {
                    throw new Exception();
                }

                if (File.Exists(@"D:\defaultPhotoFolder.txt") && new FileInfo(@"D:\defaultPhotoFolder.txt").Length != 0)
                {
                    defaultPhotoStorage = File.ReadAllText(@"D:\defaultPhotoFolder.txt");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("select default folders in settings");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (convesion_state)
            {
                outputVideoFile = Path.Combine(defaultVideoStorage, new string(Guid.NewGuid().ToString()).Replace("-", string.Empty));
                Wrapper wrapper = new Wrapper(inputVideoFile, outputVideoFile, (enabled_lossles.Checked == true) ? (parameters + lossles_parameter) : parameters, selected_extension);
                progressLabel.Text = "task is running...";
                progressLabel.Visible = true;
                wrapper.ExecutCmdInNewThread();
                targetProcessName = wrapper.processName;

                progressLabel.BeginInvoke(new InvokeDelegate(processChecker));
            }
            else
            {
                MessageBox.Show("select out extension");
            }
        }
        private void selectExtension(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.Text != String.Empty && inputVideoFile != string.Empty)
            {
                selected_extension = comboBox.Text;
                convesion_state = true;
            }
            else
            {
                convesion_state = false;
            }
        }

        private void inputfileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files|*.*";
            openFileDialog.Title = "open file";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != String.Empty)
            {
                inputVideoFile = openFileDialog.FileName;
                fileCheckBox.Checked = true;
                inputFilePathLabel.Text = openFileDialog.FileName;
            }
        }


        private void VideoToolsWin_DragEnter(object sender, DragEventArgs e)
        {
            label2.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void VideoToolsWin_DragDrop(object sender, DragEventArgs e)
        {
            label2.Visible = false;
            if (returnTrueExtension((e.Data.GetData(DataFormats.FileDrop, false) as string[])[0]) != string.Empty)
            {
                fileCheckBox.Checked = true;
                inputVideoFile = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
                inputFilePathLabel.Text = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
            }
            else
            {
                fileCheckBox.Checked = false;
                inputFilePathLabel.Text = "unsupported";
            }

        }

        private void VideoToolsWin_DragLeave(object sender, EventArgs e)
        {
            label2.Visible = false;

        }
        private string returnTrueExtension(string primary)
        {
            if (suported_extension.Contains(Path.GetExtension(primary)))
            {
                return primary;
            }
            else
            {
                return string.Empty;
            }
        }

        private void VideoToolsWin_DragOver(object sender, DragEventArgs e)
        {
            label2.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            parameters = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(defaultVideoStorage, defaultPhotoStorage);
            settings.ShowDialog();
            GetDefaultStorages();
        }
        private async void processChecker()
        {
            await Process.GetProcessesByName(targetProcessName)[0].WaitForExitAsync();
            progressLabel.Text = "task done";
        }
    }
}