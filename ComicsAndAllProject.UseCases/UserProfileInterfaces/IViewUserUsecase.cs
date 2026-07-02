using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.UseCases.UserProfileInterfaces
{
    public interface IViewUserUsecase
    {
        UserProfile? Execute(string id);
    }
}
