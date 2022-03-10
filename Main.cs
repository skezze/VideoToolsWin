using System.Diagnostics;

namespace VideoToolsWin
{
    public partial class VideoToolsWin : Form
    {
        public VideoToolsWin()
        {
            InitializeComponent();
            GetDefaultStorages();            
        }
        private string? selected_extension;
        private string? inputVideoFile;
        private string? outputVideoFile;
        private string? inputPhotoFile;
        private string? outputPhotoFile;
        private string? parameters;
        public delegate void InvokeDelegate();
        private string losslesVideoParameter = "-qscale 0";
        private string[] suportedVideoExtension = {
        ".avi",".mkv", ".mp4",".flv",".webm"};
        private string[] suportedPhotoExtension = {
        ".jpg",".png", ".ico"};
        private string? defaultVideoStorage;
        private string? defaultPhotoStorage;
        private string? targetProcessName;
        private enum extensionTypes {Video,Photo};
        private extensionTypes fileType;
        private void GetDefaultStorages()
        {
            // check files for valid, select default folders
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
            catch
            {
                MessageBox.Show("select default folders in settings");
            }
        }

        private void conversionFileButton_Click(object sender, EventArgs e)
        {
            // running conversion
            try
            {
                if (!String.IsNullOrEmpty(selected_extension))
                {
                    if (fileType == extensionTypes.Video && !String.IsNullOrEmpty(defaultVideoStorage) && !String.IsNullOrEmpty(inputVideoFile))
                    {
                        outputVideoFile = Path.Combine(defaultVideoStorage, new string(Guid.NewGuid().ToString()).Replace("-", string.Empty));
                        Wrapper wrapper = new Wrapper(inputVideoFile, outputVideoFile, (enabled_lossles.Checked == true) ? (parameters + losslesVideoParameter) : parameters, selected_extension);
                        progressLabel.Text = "task is running...";
                        progressLabel.Visible = true;
                        wrapper.ExecutCmdInNewThread();
                        if (!String.IsNullOrEmpty(wrapper.processName))
                        {
                            targetProcessName = wrapper.processName;
                        }
                        else
                        {
                            throw new Exception();
                        }

                        progressLabel.BeginInvoke(new InvokeDelegate(processChecker));
                    }
                    if (fileType == extensionTypes.Photo)
                    {
                    }
                    else
                    {
                        MessageBox.Show("select out extension");
                    }
                }
            }
            catch(Exception ex) { 
                Logger.saveLogInFile(ex);
                MessageBox.Show("run ffmpeg process error");
            }
        }
        private void selectExtension(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (fileType==extensionTypes.Video||fileType==extensionTypes.Photo)
            {
                selected_extension = comboBox.Text;
            }
            else
            {
                MessageBox.Show("select first input file");
            }
        }

        private void inputfileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files|*.*";
            openFileDialog.Title = "open file";
            openFileDialog.ShowDialog();
            if (!String.IsNullOrEmpty(openFileDialog.FileName))
            {
                string filename = openFileDialog.FileName;
                afterSelectFileConfigurator(filename);
            }
        }

        private void afterSelectFileConfigurator(string filename)
            //give path to file on input and he check data, configure solo project state
        {
            if (returnTrueExtension(filename))
            {
                if (returnTypeExtension(filename) == extensionTypes.Video)
                {
                    fileCheckBox.Checked = true;
                    inputVideoFile = inputFilePathLabel.Text = filename;
                    inputPhotoFile = String.Empty;
                    fileType = extensionTypes.Video;
                    conversionTypeComboBox.Items.AddRange(suportedVideoExtension);
                }
                if (returnTypeExtension(filename) == extensionTypes.Photo)
                {
                    fileCheckBox.Checked = true;
                    inputPhotoFile = inputFilePathLabel.Text = filename;
                    fileType = extensionTypes.Photo;
                    inputVideoFile = String.Empty;
                    conversionTypeComboBox.Items.AddRange(suportedPhotoExtension);
                }
            }
            else
            {
                fileCheckBox.Checked = false;
                inputFilePathLabel.Text = "unsupported";
            }
        }

        private void VideoToolsWin_DragEnter(object sender, DragEventArgs e)
        {
            label2.Visible = true;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void VideoToolsWin_DragDrop(object sender, DragEventArgs e)
        {
            string filename = (e.Data.GetData(DataFormats.FileDrop, false) as string[])[0];
            label2.Visible = false;
            if(!String.IsNullOrEmpty(filename))
            afterSelectFileConfigurator(filename);

        }

        private void VideoToolsWin_DragLeave(object sender, EventArgs e)
        {
            label2.Visible = false;

        }
        private bool returnTrueExtension(string primary)
        {
            if (suportedVideoExtension.Contains(Path.GetExtension(primary))|| suportedPhotoExtension.Contains(Path.GetExtension(primary)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private extensionTypes returnTypeExtension(string primary)
        {
            if (suportedVideoExtension.Contains(Path.GetExtension(primary)))
            {
                return extensionTypes.Video;
            }
            else
            {
                return extensionTypes.Photo;
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
            if (!String.IsNullOrEmpty(defaultVideoStorage)&& !String.IsNullOrEmpty(defaultPhotoStorage))
            {
                Settings settings = new Settings(defaultVideoStorage, defaultPhotoStorage);
                settings.ShowDialog();
                GetDefaultStorages();
            }
        }
        private async void processChecker()
        {
            await Process.GetProcessesByName(targetProcessName)[0].WaitForExitAsync();
            progressLabel.Text = "task done";
        }

        private void backgroundWorkerIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}