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
    public class GetPublisherUsecase : IGetPublisherUsecase
    {
        private readonly IPublishersRepository publishersrepo;
        public GetPublisherUsecase(IPublishersRepository publishersrepo)
        {
            this.publishersrepo = publishersrepo;
        }

        public Publisher Execute(int id)
        {
            return publishersrepo.Get(id);
        }
    }
}
