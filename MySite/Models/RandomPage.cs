namespace MySite.Models
{
    public class RandomPage
    {
        public int RandomPageId { get; set; }
        public string Topic { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] Image { get; set; }
    }
}