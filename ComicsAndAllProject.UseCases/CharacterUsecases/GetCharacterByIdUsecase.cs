using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.CharacterInterfaces;

namespace ComicsAndAllProject.UseCases.CharacterUsecases
{
    public class GetCharacterByIdUsecase : IGetCharacterByIdUsecase
    {
        private readonly ICharactersRepository charactersrepo;
        public GetCharacterByIdUsecase(ICharactersRepository charactersrepo)
        {
            this.charactersrepo = charactersrepo;
        }
        public Character Execute(int id)
        {
            return charactersrepo.GetById(id);
        }
    }
}
