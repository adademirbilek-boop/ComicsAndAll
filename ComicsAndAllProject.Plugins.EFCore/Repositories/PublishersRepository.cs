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
    public class PublishersRepository : IPublishersRepository
    {
        private readonly ComicsAndAllDbContext _context;
        public PublishersRepository(ComicsAndAllDbContext context)
        {
            _context = context;
        }
        public Publisher Get(int id)
        {
           
            return _context.Publishers.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Publisher> GetAll()
        {
            return _context.Publishers.ToList();
        }

        public IEnumerable<Publisher> Search(string? name)
        {
            return _context.Publishers.Where(x => x.Name.Contains(name)).ToList();
        }
    }
}
