using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.Plugins.EFCore.Data;

namespace ComicsAndAllProject.Plugins.EFCore.Repositories
{
    public class SeriesRepository : ISeriesRepository
    {
        private readonly ComicsAndAllDbContext _context;
        public SeriesRepository(ComicsAndAllDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Series> GetAll()
        {
            return _context.Series.ToList();
        }
    }
}
