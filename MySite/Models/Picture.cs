namespace MySite.Models
{
    public class Picture
    {
        public int PictureId { get; set; }
        public byte[] Image { get; set; } = null!;
        public int TravelId { get; set; }
        public Travel Travel { get; set; } = null!;
    }
}