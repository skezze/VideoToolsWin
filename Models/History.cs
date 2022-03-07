using System;

namespace VideoToolsWebAPI.Models
{
    public class History
    {
        public History(int id, string inputFilePath, string outputFilePath, DateTime? createdDate, int quality, float weight)
        {
            Id = id;
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;
            CreatedDate = createdDate;
            Quality = quality;
            Weight = weight;
        }

        public int Id { get; set; }
        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int Quality { get; set; }
        public float Weight { get; set; }
    }
}
