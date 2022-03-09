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
        }

        public string defaultVideoStorage;
        public string defaultPhotoStorage;
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
    }
}
