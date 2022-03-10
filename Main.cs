using System.Diagnostics;

namespace VideoToolsWin
{
    public partial class VideoToolsWin : Form
    {
        public VideoToolsWin()
        {
            InitializeComponent();
            GetDefaultFolders();            
        }
        private string? selectedExtension;
        private string? inputVideoFile;
        private string? outputVideoFile;
        private string? inputPhotoFile;
        private string? outputPhotoFile;
        private string? parameters;
        public delegate void InvokeDelegate();
        private const string LosslessVideoParameter = "-qscale 0";
        private readonly string[] supportedVideoExtension = {
        ".avi",".mkv", ".mp4",".flv",".webm"};
        private readonly string[] supportedPhotoExtension = {
        ".jpg",".png", ".ico"};
        private string? defaultVideoStorage;
        private string? defaultPhotoStorage;
        private string? targetProcessName;
        private enum ExtensionTypes {Video,Photo};
        private ExtensionTypes fileType;
        private void GetDefaultFolders()
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
                if (!String.IsNullOrEmpty(selectedExtension))
                {
                    if (fileType == ExtensionTypes.Video && !String.IsNullOrEmpty(defaultVideoStorage) && !String.IsNullOrEmpty(inputVideoFile))
                    {
                        outputVideoFile = Path.Combine(defaultVideoStorage, new string(Guid.NewGuid().ToString()).Replace("-", string.Empty));
                        Wrapper wrapper = new Wrapper(inputVideoFile, outputVideoFile, (enabled_lossles.Checked == true) ? (parameters + LosslessVideoParameter) : parameters, selectedExtension);
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

                        progressLabel.BeginInvoke(new InvokeDelegate(ProcessChecker));
                    }
                    else if (fileType == ExtensionTypes.Photo && !String.IsNullOrEmpty(defaultPhotoStorage) && !String.IsNullOrEmpty(inputPhotoFile))
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
            if (fileType==ExtensionTypes.Video||fileType==ExtensionTypes.Photo)
            {
                selectedExtension = comboBox.Text;
            }
            else
            {
                MessageBox.Show("select first input file");
            }
        }

        private void inputFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files|*.*";
            openFileDialog.Title = "open file";
            openFileDialog.ShowDialog();
            if (!String.IsNullOrEmpty(openFileDialog.FileName))
            {
                string filename = openFileDialog.FileName;
                AfterSelectFileConfigurator(filename);
            }
        }

        private void AfterSelectFileConfigurator(string filename)
            //give path to file on input and he check data, configure project state
        {
            if (ReturnTrueExtension(filename))
            {
                if (ReturnTypeExtension(filename) == ExtensionTypes.Video)
                {
                    fileCheckBox.Checked = true;
                    inputVideoFile = inputFilePathLabel.Text = filename;
                    inputPhotoFile = String.Empty;
                    fileType = ExtensionTypes.Video;
                    conversionTypeComboBox.Items.AddRange(supportedVideoExtension as object[]);
                }
                if (ReturnTypeExtension(filename) == ExtensionTypes.Photo)
                {
                    fileCheckBox.Checked = true;
                    inputPhotoFile = inputFilePathLabel.Text = filename;
                    fileType = ExtensionTypes.Photo;
                    inputVideoFile = String.Empty;
                    conversionTypeComboBox.Items.AddRange(supportedPhotoExtension as object[]);
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
                AfterSelectFileConfigurator(filename);

        }

        private void VideoToolsWin_DragLeave(object sender, EventArgs e)
        {
            label2.Visible = false;

        }
        private bool ReturnTrueExtension(string primary)
        {
            if (supportedVideoExtension.Contains(Path.GetExtension(primary))|| supportedPhotoExtension.Contains(Path.GetExtension(primary)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private ExtensionTypes ReturnTypeExtension(string primary)
        {
            if (supportedVideoExtension.Contains(Path.GetExtension(primary)))
            {
                return ExtensionTypes.Video;
            }
            else
            {
                return ExtensionTypes.Photo;
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
                GetDefaultFolders();
            }
        }
        private async void ProcessChecker()
        {
            await Process.GetProcessesByName(targetProcessName)[0].WaitForExitAsync();
            progressLabel.Text = "task done";
        }

        private void BackgroundWorkerIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}