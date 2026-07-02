namespace ComicsAndAllProject.ViewModels
{
    public class CharactersPageViewModel
    {
        public int Id {  get; set; }

        public string Name { get; set; }

        public string? RealName { get; set; }

        public string? PublisherName { get; set; }

        public string? ImageUrl { get; set; }

        public bool IsFavorited { get; set; }
    }
}
