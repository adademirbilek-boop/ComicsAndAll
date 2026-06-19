using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.ViewModels
{
    public class PublisherDetailsViewModel
    {
       public int Id { get; set; }

        public string Name { get; set; }

        public List<Series> Series { get; set; }
    }
}
