using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAndAllProject.UseCases.FavoriteCharacterInterfaces
{
    public interface IFavoriteCharacterCountUsecase
    {
        int Execute(string userId);
    }
}
