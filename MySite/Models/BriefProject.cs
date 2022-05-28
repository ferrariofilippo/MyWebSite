namespace MySite.Models
{
    public class BriefProject
    {
        public int ProjectId { get; set; }
        public string Name { get; set; } = null!;
        public string Resume { get; set; } = null!;
        public Language Language { get; set; }
        public byte[] Image { get; set; }
        public BriefProject(Project p) =>
            (ProjectId, Name, Resume, Language, Image) =
            (p.ProjectId, p.Name, p.Resume, p.Language, p.Image);
    }
}
