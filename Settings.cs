using System.Management;
using FxResources.System.Management;

namespace VideoToolsWin
{
    public partial class Settings : Form
    {
        public Settings(string defV, string defP)
        {
            InitializeComponent();
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
                        GPUName = GPUs.Radeon;
                        GPUFinded = true;
                        break;
                    }

                    if (gpu.Contains("Nvidia"))
                    {
                        GPUName = GPUs.Nvidia;
                        GPUFinded = true;
                        break;
                    }
                }

                if (GPUFinded)
                {
                    label3.Visible = true;
                    usingGpuCheckBox.Visible = true;
                }
            }
        }

        private enum GPUs { Nvidia,Radeon }

        private GPUs GPUName;
        private bool GPUFinded = false;
        private bool GPUUsing = false;
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
            GPUUsing = usingGpuCheckBox.Checked;
            try
            {
                File.WriteAllTextAsync(@"D:\GPU.txt", GPUUsing.ToString() + Environment.NewLine + GPUName);
            }
            catch (Exception ex)
            {
                Logger.saveLogInFile(ex);
                MessageBox.Show("check logs");
            }
        }
    }
}
