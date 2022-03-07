using System.Diagnostics;

namespace VideoToolsWin
{
    public partial class VideoToolsWin : Form
    {
        public VideoToolsWin()
        {
            InitializeComponent();
            GetDefaultStorage();
            MessageBox.Show(Directory.GetCurrentDirectory());
        }
        private bool convesion_state;
        private string selected_extension;
        private string input_file;
        private string output_file;
        private string parameters;
        private string lossles_parameter = "-qscale 0";
        private string[] suported_extension = {
        ".avi",".mkv", ".mp4",".flv",".webm"
        };
        private string defaultStorage;
        private void GetDefaultStorage()
        {
            try
            {
                if (File.Exists(@"D:\defaultFolder.txt"))
                    defaultStorage = File.ReadAllText(@"D:\defaultFolder.txt");
                else
                {
                    File.Create(@"D:\defaultFolder.txt");
                    defaultStorage = File.ReadAllText(@"D:\defaultFolder.txt");
                }
            }
            catch (Exception ex)
            {
            MessageBox.Show("select default folder in settings");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (convesion_state)
            {
                output_file = Path.Combine(defaultStorage, new string (Guid.NewGuid().ToString()).Replace("-",string.Empty));
                if (Wrapper.ExecutCmd(input_file, output_file, (enabled_lossles.Checked == true) ? (parameters + lossles_parameter) : parameters, selected_extension))
                    MessageBox.Show("done");
               }
            else
            {
                MessageBox.Show("select out extension");

            }
        }
        private void selectExtension(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.Text != String.Empty && input_file != string.Empty)
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
                input_file = openFileDialog.FileName;
                fileCheckBox.Checked = true;
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
            if (returnTrueExtension((e.Data.GetData(DataFormats.FileDrop, false) as string[]) [0]) != string.Empty)
            {
                fileCheckBox.Checked = true;
                input_file = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
            }
            else { 
            fileCheckBox.Checked = false;
            }
        }

        private void VideoToolsWin_DragLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
      
        }
        private string returnTrueExtension(string primary) {
            if (suported_extension.Contains(Path.GetExtension(primary)))
            {
                return primary;
            }
            else {
                return string.Empty;
            }
        }

        private void VideoToolsWin_DragOver(object sender, DragEventArgs e)
        {
            label2.Visible=true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           parameters = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(defaultStorage);
            settings.defaultStorage = defaultStorage;
            settings.ShowDialog();
           GetDefaultStorage();
        }
    }
}