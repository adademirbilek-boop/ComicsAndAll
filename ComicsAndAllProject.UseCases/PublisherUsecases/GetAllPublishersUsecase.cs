using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.PublisherInterfaces;

namespace ComicsAndAllProject.UseCases.PublisherUsecases
{
    public class GetAllPublishersUsecase : IGetAllPublishersUsecase
    {
        private readonly IPublishersRepository publishersrepo;
        public GetAllPublishersUsecase(IPublishersRepository publishersrepo)
        {
            this.publishersrepo = publishersrepo;
        }
        public IEnumerable<Publisher> Execute()
        {
           return publishersrepo.GetAll();
        }
    }
}
