namespace VideoToolsWin
{
    internal static class Logger
    {
        public static void saveLogInFile(Exception exception)
        {
            File.AppendAllTextAsync(@"D:\Logs.txt",DateTime.Now.ToString() + "->" + exception.Source + "->" + exception.Data + exception.StackTrace + "->" + exception.Message + Environment.NewLine);
        }
    } 
}
