using System.ComponentModel.DataAnnotations.Schema;
namespace MySite.Models
{
    public class SuggestedPlace
    {
        public int SuggestedPlaceId { get; set; }
        public string Name { get; set; } = null!;
        public string Url { get; set; } = null!;
        [ForeignKey("Country")]
        public string Country { get; set; } = null!;
        public Travel Travel { get; set; } = null!;
    }
}