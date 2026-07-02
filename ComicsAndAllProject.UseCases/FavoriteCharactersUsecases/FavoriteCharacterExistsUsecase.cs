using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.FavoriteCharacterInterfaces;

namespace ComicsAndAllProject.UseCases.FavoriteCharactersUsecases
{
    public class FavoriteCharacterExistsUsecase : IFavoriteCharacterExistsUsecase
    {
        private readonly IFavoriteCharactersRepository favoritecharactersrepo;
        public FavoriteCharacterExistsUsecase(IFavoriteCharactersRepository favoritecharactersrepo)
        {
            this.favoritecharactersrepo = favoritecharactersrepo;
        }
        public bool Execute(string userId, int characterid)
        {
            return favoritecharactersrepo.Exists(userId, characterid);
        }
    }
}
