namespace MySite.Models
{
    public class Travel
    {
        public int TravelId { get; set; }
        public string Country { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string BackgroundImage { get; set; } = null!;
        List<SuggestedPlace>? Places { get; set; }
        public byte[] Image { get; set; }
    }
}