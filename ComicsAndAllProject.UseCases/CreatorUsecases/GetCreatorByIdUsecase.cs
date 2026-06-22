using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.CreatorInterfaces;

namespace ComicsAndAllProject.UseCases.CreatorUsecases
{
    public class GetCreatorByIdUsecase : IGetCreatorByIdUsecase
    {
        private readonly ICreatorRepository creatorrepo;
        public GetCreatorByIdUsecase(ICreatorRepository creatorrepo)
        {
            this.creatorrepo = creatorrepo;
        }
        public Creator Execute(int id)
        {
            return creatorrepo.Get(id);
        }
    }
}
