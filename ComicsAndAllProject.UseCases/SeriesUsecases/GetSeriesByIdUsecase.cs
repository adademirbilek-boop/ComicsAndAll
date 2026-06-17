using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.Interfaces;

namespace ComicsAndAllProject.UseCases.SeriesUsecases
{
    public class GetSeriesByIdUsecase : IGetSeriesByIdUsecase
    {
        private readonly ISeriesRepository seriesrepo;
        public GetSeriesByIdUsecase(ISeriesRepository seriesrepo)
        {
            this.seriesrepo = seriesrepo;
        }

        public Series Execute(int id)
        {
            return seriesrepo.Get(id);
        }
    }
}
