using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.ViewModels
{
    public class IssueDetailsViewModel
    {
        public int Id { get; set; }

        public string? Title { get; set; } 

        public int? SeriesId { get; set; }

        public string? PublisherName { get; set; }

        public string? CoverImageUrl { get; set; }

        public string? IssueNumber { get; set; }

        public decimal? IssueOrder {  get; set; }

        public DateOnly? ReleaseDate { get; set; }

        public DateOnly? CoverDate { get; set; }

        public Series? Series { get; set; }

    }
}
