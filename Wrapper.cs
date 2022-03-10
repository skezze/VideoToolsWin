using System.Diagnostics;

namespace VideoToolsWin
{
    public class Wrapper
    {
        private String inputfile { get;set; }
        private String outputfile { get; set; }
        private String? parameters { get; set; }
        private String outextension { get; set; }
        public String ?processName { get; set; }    

        public Wrapper(string inputfile, string outputfile, string? parameters, string outextension)
        {
            this.inputfile = inputfile;
            this.outputfile = outputfile;
            this.parameters = parameters;
            this.outextension = outextension;

        }
        
        public void ExecutCmdInNewThread() {
            try
            {
                Process proc = new Process();

                proc.StartInfo.FileName = Path.Combine(@"C:\Users\skezze\source\repos\VideoToolsWin\exec\ffmpeg.exe"); 
                proc.StartInfo.Arguments = String.Format($"-i {inputfile} {parameters} {outputfile + outextension}");
                proc.StartInfo.UseShellExecute = false; 
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();
                processName = proc.ProcessName;
            }
            catch (Exception ex)
            {
                Logger.saveLogInFile(ex);
                MessageBox.Show("error, check logs");
            }
        
        }
        public static void ExecutCmd(string inputfile,string parameters, string outputfile, string outextension)
        {
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
                MessageBox.Show("Complete");
            }
            catch (Exception ex)
            {
                Logger.saveLogInFile(ex);
                MessageBox.Show("error, check logs");
            }

        }
    }
}
