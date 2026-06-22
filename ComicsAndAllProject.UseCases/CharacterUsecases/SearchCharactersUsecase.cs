using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.CharacterInterfaces;
using Microsoft.IdentityModel.Tokens;

namespace ComicsAndAllProject.UseCases.CharacterUsecases
{
    public class SearchCharactersUsecase : ISearchCharactersUsecase
    {
        private readonly ICharactersRepository charactersrepo;
        public SearchCharactersUsecase(ICharactersRepository charactersrepo)
        {
            this.charactersrepo = charactersrepo;
        }
        public IEnumerable<Character> Execute(string? name)
        {
            if (name.IsNullOrEmpty()) return Enumerable.Empty<Character>();
            return charactersrepo.Search(name);
        }
    }
}
