namespace MySite.Models
{
    public class BriefTravel
    {
        public string Country { get; set; } = null!;
        public string Description { get; set; } = null!;
        public BriefTravel(Travel t) =>
            (Country, Description) =
            (t.Country,
            t.Description.Length > 200
                ? t.Description[..200]
                : t.Description);
    }
}
