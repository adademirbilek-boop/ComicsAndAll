using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.SeriesInterfaces;
using Microsoft.IdentityModel.Tokens;

namespace ComicsAndAllProject.UseCases.SeriesUsecases
{
    public class SearchSeriesUsecase : ISearchSeriesUsecase
    {
        private readonly ISeriesRepository seriesrepo;
        public SearchSeriesUsecase(ISeriesRepository seriesrepo)
        {
            this.seriesrepo = seriesrepo;
        }
        public IEnumerable<Series> Execute(string? name)
        {
           if(name.IsNullOrEmpty()) return Enumerable.Empty<Series>();

           return seriesrepo.Search(name);
        }
    }
}
