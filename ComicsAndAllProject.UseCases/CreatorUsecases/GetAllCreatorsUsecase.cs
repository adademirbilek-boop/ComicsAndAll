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
    public class GetAllCreatorsUsecase : IGetAllCreatorsUsecase
    {
        private readonly ICreatorRepository creatorrepo;
        public GetAllCreatorsUsecase(ICreatorRepository creatorrepo)
        {
            this.creatorrepo = creatorrepo;
        }
        public IEnumerable<Creator> Execute()
        {
            return creatorrepo.GetAll();
        }
    }
}
