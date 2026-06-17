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
    public class CharactersRepository : ICharactersRepository
    {
        private readonly ComicsAndAllDbContext _context;
        public CharactersRepository(ComicsAndAllDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Character> GetAll()
        {
           return _context.Characters;
        }

        public Character? GetById(int id)
        {
            return _context.Characters.FirstOrDefault(x => x.Id == id);
        }

        
    }
}
