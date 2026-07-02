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
    public class FavoriteCharactersRepository : IFavoriteCharactersRepository
    {
        private readonly ComicsAndAllDbContext _context;
        public FavoriteCharactersRepository(ComicsAndAllDbContext context)
        {
            _context = context;
        }

        public void Add(FavoriteCharacter character)
        {
             _context.Add(character);
            _context.SaveChanges();
        }

        public bool Exists(string userId, int characterId)
        {
            return _context.FavoriteCharacters.Any(x => 
            x.UserId == userId &&
            x.CharacterId == characterId);
        }

        public int Count(string userId)
        {
            return _context.FavoriteCharacters.Count(x => x.UserId == userId);
        }

        public IEnumerable<FavoriteCharacter> GetByUser(string userId)
        {
            return _context.FavoriteCharacters.Where(x => x.UserId == userId).ToList();
        }

        public void Remove(string userId, int characterId)
        {
            var fav = _context.FavoriteCharacters.FirstOrDefault(x => 
            x.UserId == userId &&
            x.CharacterId == characterId);

            if (fav != null)
            {
                _context.FavoriteCharacters.Remove(fav);
                _context.SaveChanges();
            }
        }
    }
}
