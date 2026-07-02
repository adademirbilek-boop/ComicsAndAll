using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.FavoriteCharacterInterfaces;

namespace ComicsAndAllProject.UseCases.FavoriteCharactersUsecases
{
    public class RemoveFromFavoriteCharactersUsecase : IRemoveFromFavoriteCharactersUsecase
    {
        private readonly IFavoriteCharactersRepository favoritecharactersrepo;
        public RemoveFromFavoriteCharactersUsecase(IFavoriteCharactersRepository favoritecharactersrepo)
        {
            this.favoritecharactersrepo = favoritecharactersrepo;
        }
        public void Execute(string userId, int characterId)
        {
            var exists = favoritecharactersrepo.Exists(userId, characterId);
            if (!exists)
            {
                return;
            }
           favoritecharactersrepo.Remove(userId, characterId);
           
        }
    }
}
