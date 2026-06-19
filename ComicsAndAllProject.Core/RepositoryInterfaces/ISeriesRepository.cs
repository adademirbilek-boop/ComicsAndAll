using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.Core.RepositoryInterfaces
{
    public interface ISeriesRepository
    {
        IEnumerable<Series> GetAll();

        Series Get(int id);

        IEnumerable<Series> Search(string name);

        IEnumerable<Series> GetByPublisherId(int publisherid);
    }
}
