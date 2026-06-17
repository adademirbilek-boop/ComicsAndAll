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
    public class GetAllCharactersUsecase : IGetAllCharactersUsecase
    {
        private readonly ICharactersRepository charactersrepo;
        public GetAllCharactersUsecase(ICharactersRepository charactersrepo)
        {
            this.charactersrepo = charactersrepo;
        }
        public IEnumerable<Character> Execute()
        {
            return charactersrepo.GetAll();
        }
    }
}
