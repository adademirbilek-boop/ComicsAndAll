using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAndAllProject.Core.Entities
{
    public class Series
    {
        public int Id { get; set; }

        public int PublisherId { get; set; }

        public string Title { get; set; }

        public int? StartYear { get; set; }

        public int? EndYear { get; set; } 

        public bool? IsLimitedSeries { get; set; }

        public bool? IsOngoing {  get; set; }

        public int? TotalIssues { get; set; }

        public string? CoverImageUrl { get; set; }

        public string? SourceName { get; set; }

        public string? SourceUrl { get; set; }

        public string? ExternalSourceId { get; set; }

        public ICollection<Issue>? Issues { get; set; } = new List<Issue>();
       
    }
}
