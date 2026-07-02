using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.FavoriteCharacterInterfaces;

namespace ComicsAndAllProject.UseCases.FavoriteCharactersUsecases
{
    public class FavoriteCharacterCountUsecase : IFavoriteCharacterCountUsecase
    {
        private readonly IFavoriteCharactersRepository favoritecharactersrepo;
        public FavoriteCharacterCountUsecase(IFavoriteCharactersRepository favoritecharactersrepo)
        {
            this.favoritecharactersrepo = favoritecharactersrepo;
        }
        public int Execute(string userId)
        {
            return favoritecharactersrepo.Count(userId);
        }
    }
}
