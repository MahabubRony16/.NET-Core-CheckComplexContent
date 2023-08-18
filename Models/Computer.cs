using System.Text.Json.Serialization;

namespace HelloWorld.Models
{
    public class Computer
    {
        // private string _motherboard;
        public int ComputerId { get; set; }
        public string Motherboard { get; set; } = String.Empty;
        public int? CPUCores { get; set; } = 0;
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; } = String.Empty;
    }
}