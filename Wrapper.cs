using System.Diagnostics;
using System.Drawing.Imaging;
using Aspose.Imaging.ImageOptions;

namespace VideoToolsWin
{
    public class Wrapper
    {
        private String InputFile { get;set; }
        private String OutputFile { get; set; }
        private String? Options { get; set; }
        private String? InputFileOptions { get; set; }
        private String OutExtension { get; set; }
        private String? OutputFileOptions { get; set; }
        public String ?ProcessName { get; set; }    

        public Wrapper(string options, string? inputFileOptions, string inputFile,string outputFileOptions,string outputFile, string outExtension)
        {
            this.InputFile = inputFile;
            this.OutputFile = outputFile;
            this.InputFileOptions = inputFileOptions;
            this.OutExtension = outExtension;
            this.Options = options;
            this.OutputFileOptions = outputFileOptions;
        }
        
        public void StartFFmpegWorkerAsync() {
            try
            {
                Process proc = new Process();

                proc.StartInfo.FileName = @Path.Combine(Directory.GetCurrentDirectory(), "ffmpeg.exe"); 
                proc.StartInfo.Arguments = String.Format($"{Options} {InputFileOptions} -i {InputFile} {OutputFileOptions} {OutputFile + OutExtension}");
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
        public static void StartFFmpegWorker(string options, string inputFileOptions,string inputFile,string OutputFileOptions, string outputFile, string outExtension)
        {
            try
            {
                outExtension = outExtension.ToLower();
                Process proc = new Process();
                proc.StartInfo.FileName = @Path.Combine(Directory.GetCurrentDirectory(), "ffmpeg.exe");
                proc.StartInfo.Arguments = String.Format($"{options} {inputFileOptions} -i {inputFile} {OutputFileOptions} {outputFile + outExtension}");
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

        public static void StartImageCompression(string inputFile, string outputFile, string outExtension,int quality)
        {
            
            SavePicture(inputFile, outputFile, outExtension);
            outputFile += outExtension;
            var FileName = Path.GetFileName(inputFile);
            
            using (Bitmap bmp1 = new Bitmap(inputFile))
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                System.Drawing.Imaging.Encoder QualityEncoder = System.Drawing.Imaging.Encoder.Quality;

                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(QualityEncoder, quality);

                myEncoderParameters.Param[0] = myEncoderParameter;
                bmp1.Save(outputFile, jpgEncoder, myEncoderParameters);

            }
        }
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
        public static void StartImageExtensionConversion(string inputFile, string outputFile, string outExtension)
        {
            SavePicture(inputFile, outputFile, outExtension);
        }

        public static void SavePicture(string inputFile, string outputFile, string outExtension)
        {
            outputFile += outExtension;
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
