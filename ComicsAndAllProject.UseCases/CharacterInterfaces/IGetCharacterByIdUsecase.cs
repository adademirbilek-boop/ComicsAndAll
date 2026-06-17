using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.UseCases.CharacterInterfaces
{
    public interface IGetCharacterByIdUsecase
    {
        Character Execute(int id);
    }
}
