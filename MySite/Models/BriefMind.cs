namespace MySite.Models
{
    public class BriefMind
    {
        public int MindId { get; set; }
        public string Topic { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] Image { get; set; }

        public BriefMind(RandomPage p) =>
            (MindId, Topic, Description, Image) =
            (p.RandomPageId,
            p.Topic,
            p.Resume,
            p.Image);
    }
}