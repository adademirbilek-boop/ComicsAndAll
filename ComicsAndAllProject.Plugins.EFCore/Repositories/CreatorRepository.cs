using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.Plugins.EFCore.Data;
using Microsoft.IdentityModel.Tokens;

namespace ComicsAndAllProject.Plugins.EFCore.Repositories
{
    public class CreatorRepository : ICreatorRepository
    {
        private readonly ComicsAndAllDbContext _context;
        public CreatorRepository(ComicsAndAllDbContext context)
        {
            _context = context;
        }

        public Creator Get(int id)
        {
            return _context.Creators.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Creator> GetAll()
        {
            return _context.Creators.ToList();
        }

        public IEnumerable<Creator> Search(string? name)
        {
            return _context.Creators.Where(x => x.Name.Contains(name));
        }
    }
}
