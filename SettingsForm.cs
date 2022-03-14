using System.Management;
using FxResources.System.Management;

namespace VideoToolsWin
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(string defV, string defP, bool gpuUsing)
        {
            InitializeComponent();
            this.gpuUsing = gpuUsing;
            if(gpuUsing)
                usingGpuCheckBox.Checked = true;
            defaultVideoStorage = defV;
            defaultPhotoStorage = defP;
            viewDeafaultVideoFolder.Text = defaultVideoStorage;
            viewDeafaultPhotoFolder.Text = defaultPhotoStorage;
            using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                List<string> gpuList = new List<string>();
                foreach (ManagementObject obj in searcher.Get())
                {
                    gpuList.Add(obj["Name"] as string);
                }

                foreach (var gpu in gpuList)
                {
                    if (gpu.Contains("Radeon"))
                    {
                        gpuName = GPUs.Radeon;
                        gpuFinded = true;
                        break;
                    }

                    if (gpu.Contains("Nvidia"))
                    {
                        gpuName = GPUs.Nvidia;
                        gpuFinded = true;
                        break;
                    }
                }

                if (gpuFinded)
                {
                    label3.Visible = true;
                    usingGpuCheckBox.Visible = true;
                }
            }
        }

        private enum GPUs { Nvidia,Radeon }

        private GPUs gpuName;
        private bool gpuFinded = false;
        private bool gpuUsing = false;
        private string defaultVideoStorage;
        private string defaultPhotoStorage;
        private void defaultVideoPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (dialog.SelectedPath != String.Empty)
            {
                defaultVideoStorage = dialog.SelectedPath;
                viewDeafaultVideoFolder.Text = dialog.SelectedPath;
                try
                {
                    File.WriteAllTextAsync(@"D:\defaultVideoFolder.txt", defaultVideoStorage);
                }
                catch (Exception ex)
                {
                    Logger.saveLogInFile(ex);
                    MessageBox.Show("check logs");
                }
               
            }

        }

        private void defaultPhotoPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (dialog.SelectedPath != String.Empty)
            {
                defaultPhotoStorage = dialog.SelectedPath;
                viewDeafaultPhotoFolder.Text = dialog.SelectedPath;
                try
                {
                    File.WriteAllTextAsync(@"D:\defaultPhotoFolder.txt", defaultPhotoStorage);
                }
                catch(Exception ex) {
                    Logger.saveLogInFile(ex);
                    MessageBox.Show("check logs");
                }
                
            }
        }

        private void usingGpuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            gpuUsing = usingGpuCheckBox.Checked;
            try
            {
                File.WriteAllTextAsync(@"D:\GPU.txt", gpuUsing.ToString() + Environment.NewLine + gpuName);
            }
            catch (Exception ex)
            {
                Logger.saveLogInFile(ex);
                MessageBox.Show("check logs");
            }
        }
    }
}
