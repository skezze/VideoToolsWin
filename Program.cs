using System.Diagnostics;

namespace VideoToolsWin
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            if (Process.GetProcessesByName("VideoToolsWin").Length > 1)
            {
                MessageBox.Show("1 more process started");
                Application.Exit();
            }
            else
            {
                Application.Run(new VideoToolsWin());
            }
        }
    }
}