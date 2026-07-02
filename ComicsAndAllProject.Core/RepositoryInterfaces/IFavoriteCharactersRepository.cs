using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.Core.RepositoryInterfaces
{
    public interface IFavoriteCharactersRepository
    {
        IEnumerable<FavoriteCharacter> GetByUser(string userId);

        void Add(FavoriteCharacter character);

        bool Exists(string userId, int characterId);

        void Remove(string userId, int characterId);

        int Count(string userId);
    }
}
