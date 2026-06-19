using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.UseCases.SeriesInterfaces
{
    public interface IGetSeriesByPublisherIdUsecase
    {
        IEnumerable<Series> Execute(int publisherid);
    }
}
