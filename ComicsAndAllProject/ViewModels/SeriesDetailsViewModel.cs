using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.ViewModels
{
    public class SeriesDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string PublisherName { get; set; } = null!;
        public List<IssueListViewModel> Issues { get; set; } = new();

        public string? CoverImageUrl { get; set; }
    }
}
