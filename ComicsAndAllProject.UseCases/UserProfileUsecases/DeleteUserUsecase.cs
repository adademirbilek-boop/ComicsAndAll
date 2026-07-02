using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.UserProfileInterfaces;

namespace ComicsAndAllProject.UseCases.UserProfileUsecases
{
    public class DeleteUserUsecase : IDeleteUserUsecase
    {
        private readonly IUserProfileRepository userprofilerepo;
        public DeleteUserUsecase(IUserProfileRepository userprofilerepo)
        {
            this.userprofilerepo = userprofilerepo;
        }
        public void Execute(string id, string currentuserid)
        {
            if (id != currentuserid)
                throw new UnauthorizedAccessException();

            userprofilerepo.Delete(id);
        }
    }
}
