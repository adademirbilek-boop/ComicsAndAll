using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.CreatorInterfaces;
using Microsoft.IdentityModel.Tokens;

namespace ComicsAndAllProject.UseCases.CreatorUsecases
{
    public class SearchCreatorsUsecase : ISearchCreatorsUsecase
    {
        private readonly ICreatorRepository creatorrepo;
        public SearchCreatorsUsecase(ICreatorRepository creatorrepo)
        {
            this.creatorrepo = creatorrepo;
        }
        public IEnumerable<Creator> Execute(string? name)
        {
            if(name.IsNullOrEmpty())
                return Enumerable.Empty<Creator>();

            return creatorrepo.Search(name);
        }
    }
}
