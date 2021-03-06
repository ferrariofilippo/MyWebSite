namespace MySite.Models
{
    public class SuggestedPlace
    {
        public int SuggestedPlaceId { get; set; }
        public string Name { get; set; } = null!;
        public string Url { get; set; } = null!;
        public int TravelId { get; set; }
        public Travel Travel { get; set; } = null!;
    }
}