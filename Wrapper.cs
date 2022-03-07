using System.Diagnostics;

namespace VideoToolsWin
{
    public abstract class Wrapper
    {
        public static bool ExecutCmd(string inputfile,string outputfile,string? parameters=null, string? outextension = null) {
            try
            {
                Process proc = new Process();

                proc.StartInfo.FileName = Path.Combine(@"C:\Users\skezze\source\repos\VideoToolsWin\exec\ffmpeg.exe"); 
                proc.StartInfo.Arguments = String.Format($"-i {inputfile} {parameters} {outputfile + outextension}");
                proc.StartInfo.UseShellExecute = false; 
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.RedirectStandardOutput = true; ;
                proc.Start();
                proc.WaitForExit();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        
        }
    }
}
