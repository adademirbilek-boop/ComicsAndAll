using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAndAllProject.Core.Entities
{
    public class Issue
    {
        public int Id { get; set; }

        public int SeriesId { get; set; }

        public string? IssueNumber { get; set; } = null;

        public string Title { get; set; }

        public DateOnly? CoverDate { get; set; }

        public DateOnly? ReleaseDate { get; set; }

        public string? ImageUrl { get; set; }

        public string? SourceName { get; set; }

        public string? ExternalSourceId { get; set; }


    }
}
