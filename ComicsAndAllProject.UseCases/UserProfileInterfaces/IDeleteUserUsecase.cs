using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAndAllProject.UseCases.UserProfileInterfaces
{
    public interface IDeleteUserUsecase
    {
        void Execute(string id, string currentuserid);
    }
}
