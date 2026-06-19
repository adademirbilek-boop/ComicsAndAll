using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.SeriesInterfaces;

namespace ComicsAndAllProject.UseCases.SeriesUsecases
{
    public class GetSeriesByPublisherIdUsecase : IGetSeriesByPublisherIdUsecase
    {
        private readonly ISeriesRepository seriesrepo;
        public GetSeriesByPublisherIdUsecase(ISeriesRepository seriesrepo)
        {
            this.seriesrepo = seriesrepo;
        }
        public IEnumerable<Series> Execute(int publisherid)
        {
           return seriesrepo.GetByPublisherId(publisherid);
        }
    }
}
