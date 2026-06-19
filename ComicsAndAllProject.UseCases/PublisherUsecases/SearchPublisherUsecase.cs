using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.PublisherInterfaces;
using Microsoft.IdentityModel.Tokens;

namespace ComicsAndAllProject.UseCases.PublisherUsecases
{
    public class SearchPublisherUsecase : ISearchPublishersUsecase
    {
        private readonly IPublishersRepository publishersrepo;
        public SearchPublisherUsecase(IPublishersRepository publishersrepo)
        {
            this.publishersrepo = publishersrepo;
        }
        public IEnumerable<Publisher> Execute(string? name)
        {
            if (name.IsNullOrEmpty()) return Enumerable.Empty<Publisher>();

            return publishersrepo.Search(name);
        }
    }
}
