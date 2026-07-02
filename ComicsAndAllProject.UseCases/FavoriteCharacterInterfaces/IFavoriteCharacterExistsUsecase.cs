using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAndAllProject.UseCases.FavoriteCharacterInterfaces
{
    public interface IFavoriteCharacterExistsUsecase
    {
        bool Execute(string userId, int id);
    }
}
