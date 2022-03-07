using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoToolsWin
{
    public partial class Settings : Form
    {
        public Settings(string def)
        {
            InitializeComponent();
            defaultStorage = def;
            viewDeafaultFolder.Text = defaultStorage;
        }
       
        public string defaultStorage;
        private void defaultPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (dialog.SelectedPath != String.Empty)
            {
                defaultStorage = dialog.SelectedPath;
                viewDeafaultFolder.Text = dialog.SelectedPath;
                serializeFolder();
            }

        }

        private void serializeFolder()
        {
            File.WriteAllTextAsync(@"D:\defaultFolder.txt", defaultStorage);
        }

    }
}
