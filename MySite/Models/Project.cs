namespace MySite.Models
{
    public enum Language
    {
        CSharp,
        Cpp,
        C,
        Python,
        JS
    }
    public enum ProjectType
    {
        Console,
        Mobile,
        WebApp,
        WebAPI,
        IoT,
        Desktop,
        Game,
        Library
    }

    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ProjectType ProjectType { get; set; }
        public Language Language { get; set; }
        public DateOnly BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Resume { get; set; } = null!;
        public string? GitRef { get; set; }
        public byte[] Image { get; set; }
    }
}