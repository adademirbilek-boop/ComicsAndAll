using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.FavoriteCharacterInterfaces;

namespace ComicsAndAllProject.UseCases.FavoriteCharactersUsecases
{
    public class AddFavoriteCharacterUsecase : IAddFavoriteCharacterUsecase
    {
        private readonly IFavoriteCharactersRepository favoritecharactersrepo;
        public AddFavoriteCharacterUsecase(IFavoriteCharactersRepository favoritecharactersrepo)
        {
            this.favoritecharactersrepo = favoritecharactersrepo;
        }
        public void Execute(string userId, int characterId)
        {
            var alreadyExists = favoritecharactersrepo.Exists(userId, characterId);
            if (alreadyExists)
                return;

            if (favoritecharactersrepo.Count(userId) >= 10)
                return;


            var character = new FavoriteCharacter
            {
                CharacterId = characterId,
                UserId = userId,
                FavDate = DateTime.UtcNow,
            };
            favoritecharactersrepo.Add(character);
        }
    }
}
