using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.ViewModels
{
    public class ProfileViewModel
    {
        public string Id { get; set; } 
        public string Name { get; set; }

        public string? Bio {  get; set; }
         
        public string? ProfileImageUrl { get; set; }
 
        public IEnumerable<Character> FavoriteCharacters { get; set; } = [];

        public DateOnly JoinedIn {  get; set; }

        public int ReviewsCount { get; set; }

        public int ReadIssuesCount { get; set; }

        public int ReadSeriesCount { get; set; }

        public int ReadRunsCount { get; set; }

        public IEnumerable<Series> FavoriteSeries { get; set; } = [];

        public IEnumerable<Issue> FavoriteIssues { get; set; } = [];

        public IEnumerable<Volume> FavoriteVolumes { get; set; } = []; 

        public bool IsOwn {  get; set; }
        

    }
}
