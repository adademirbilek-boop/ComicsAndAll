using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.Plugins.EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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

        public Series Get(int id)
        {
            
            return _context.Series.Include(x => x.Issues).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Series> Search(string? name = null)
        {
            return _context.Series.Where(x => x.Title.Contains(name)).ToList();
        }

        public IEnumerable<Series> GetByPublisherId(int publisherid)
        {
            return _context.Series.Where(x => x.PublisherId == publisherid).ToList();
        }
    }
}
