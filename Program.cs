using System.Diagnostics;

namespace VideoToolsWin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
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