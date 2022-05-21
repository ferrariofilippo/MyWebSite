namespace MySite.Models
{
    public class BriefProject
    {
        public string Name { get; set; } = null!;
        public string Resume { get; set; } = null!;
        public Language Language { get; set; }
        public BriefProject(Project p) =>
            (Name, Resume, Language) =
            (p.Name, p.Resume, p.Language);
    }
}
