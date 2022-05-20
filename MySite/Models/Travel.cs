using System.ComponentModel.DataAnnotations;
namespace MySite.Models
{
    public class Travel
    {
        [Key]
        public string Country { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string BackgroundImage { get; set; } = null!;
        List<SuggestedPlace>? Places { get; set; }
    }
}