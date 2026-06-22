using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.UseCases.CreatorInterfaces
{
    public interface IGetAllCreatorsUsecase
    {
        IEnumerable<Creator> Execute();
    }
}
