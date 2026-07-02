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
    public class GetFavoriteCharactersListUsecase : IGetFavoriteCharactersListUsecase
    {
        private readonly IFavoriteCharactersRepository favoritecharactersrepo;
        public GetFavoriteCharactersListUsecase(IFavoriteCharactersRepository favoritecharactersrepo)
        {
            this.favoritecharactersrepo = favoritecharactersrepo;
        }
        public IEnumerable<FavoriteCharacter> Execute(string userId)
        {
            return favoritecharactersrepo.GetByUser(userId);
        }
    }
}
