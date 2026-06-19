using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.Plugins.EFCore.Data;
using Microsoft.EntityFrameworkCore;

namespace ComicsAndAllProject.Plugins.EFCore.Repositories
{
    public class IssuesRepository : IIssuesRepository
    {
        private readonly ComicsAndAllDbContext _context;
        public IssuesRepository(ComicsAndAllDbContext context)
        {
            _context = context;
        }
        public Issue? Get(int id)
        {
          return _context.Issues.Include(x => x.Series).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Issue> GetAll()
        {
            return _context.Issues.ToList();
        }
    }
}
