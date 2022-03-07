using System;
using System.Diagnostics;
using System.IO;

namespace VideoToolsWebAPI.Commands
{
    public class Wrapper
    {
        public string? ExecutCmd(string inputfile,string? parameters=null, string? outextension = null) {
            try
            {
                outextension = outextension == null ? Path.GetExtension(inputfile) : outextension;
                string outputfile = String.Format("Thumbnail_{0}_{1}{2}",
        DateTime.Now.ToString("yyyyMMddHHmmssfff"), Guid.NewGuid(),outextension);

                Process proc = new Process();
                proc.StartInfo.FileName = Path.Combine("./exec", "ffmpeg");
                proc.StartInfo.Arguments = String.Format($"-i {inputfile} {outputfile} {parameters}");
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();
                proc.WaitForExit();
                return outputfile;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
