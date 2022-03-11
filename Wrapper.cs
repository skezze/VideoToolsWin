using System.Diagnostics;
using System.Drawing.Imaging;

namespace VideoToolsWin
{
    public class Wrapper
    {
        private String InputFile { get;set; }
        private String OutputFile { get; set; }
        private String AccelerationParameters { get; set; }
        private String? Parameters { get; set; }
        private String OutExtension { get; set; }
        public String ?ProcessName { get; set; }    

        public Wrapper(string accelerationParameters, string inputFile, string outputFile, string? parameters, string outExtension)
        {
            this.InputFile = inputFile;
            this.OutputFile = outputFile;
            this.Parameters = parameters;
            this.OutExtension = outExtension;
            this.AccelerationParameters = accelerationParameters;

        }
        
        public void StartFFmpegWorkerAsync() {
            try
            {
                Process proc = new Process();

                proc.StartInfo.FileName = Path.Combine(@"C:\Users\skezze\source\repos\VideoToolsWin\exec\ffmpeg.exe"); 
                proc.StartInfo.Arguments = String.Format($"{AccelerationParameters} -i {InputFile} {Parameters} {OutputFile + OutExtension}");
                proc.StartInfo.UseShellExecute = false; 
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();
                ProcessName = proc.ProcessName;
            }
            catch (Exception ex)
            {
                Logger.saveLogInFile(ex);
                MessageBox.Show("error, check logs");
            }
        
        }
        public static void StartFFmpegWorker(string accelerationParameters, string inputFile,string parameters, string outputFile, string outExtension)
        {
            try
            {
                outExtension = outExtension.ToLower();
                Process proc = new Process();
                proc.StartInfo.FileName = Path.Combine(@"C:\Users\skezze\source\repos\VideoToolsWin\exec\ffmpeg.exe");
                proc.StartInfo.Arguments = String.Format($"{accelerationParameters} -i {inputFile} {parameters} {outputFile + outExtension}");
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

        public static void StartImageExtensionConversion(string inputFile, string outputFile, string outExtension)
        {
            try
            {
                outExtension = outExtension.ToLower();
                Bitmap bitmap = new Bitmap(inputFile);
                switch (outExtension)
                {
                    case ".jpeg":
                    {
                        bitmap.Save(outputFile, ImageFormat.Jpeg);
                        break;
                    }
                    case ".jpg":
                    {
                        bitmap.Save(outputFile, ImageFormat.Jpeg);
                        break;
                    }
                    case ".png":
                    {
                        bitmap.Save(outputFile, ImageFormat.Png);
                        break;
                    }
                    case ".gif":
                    {
                        bitmap.Save(outputFile, ImageFormat.Gif);
                        break;
                    }
                    case ".bmp":
                    {
                        bitmap.Save(outputFile, ImageFormat.Bmp);
                        break;
                    }
                    case ".ico":
                    {
                        bitmap.Save(outputFile, ImageFormat.Icon);
                        break;
                    }
                    case ".tiff":
                    {
                        bitmap.Save(outputFile, ImageFormat.Tiff);
                        break;
                    }
                    default:
                        MessageBox.Show("error extension");
                        throw new Exception();
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.saveLogInFile(ex);
            }
            
        }
    }
}
