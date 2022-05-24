namespace MySite.Models
{
    public class BriefMind
    {
        public string Topic { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] Image { get; set; }

        public BriefMind(RandomPage p) =>
            (Topic, Description, Image) =
            (p.Topic,
            p.Description.Length > 200 
                ? p.Description[..200]
                : p.Description,
            p.Image);
    }
}
