using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace ComicsAndAllProject.UseCases.SeriesUsecases
{
    public class ViewSeriesUsecase : IViewSeriesUsecase
    {
        private readonly ISeriesRepository seriesrepo;
        public ViewSeriesUsecase(ISeriesRepository seriesrepo)
        {
            this.seriesrepo = seriesrepo;
        }
        public IEnumerable<Series> Execute()
        {
            return seriesrepo.GetAll();


        }
    }
}
