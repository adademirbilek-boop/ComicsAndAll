using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.UserProfileInterfaces;

namespace ComicsAndAllProject.UseCases.UserProfileUsecases
{
    public class GetAllUsersUsecase : IGetAllUsersUsecase
    {
        private readonly IUserProfileRepository userprofilerepo;
        public GetAllUsersUsecase(IUserProfileRepository userprofilerepo)
        {
            this.userprofilerepo = userprofilerepo;
        }

        public IEnumerable<UserProfile> Execute()
        {
            return userprofilerepo.List();
        }
    }
}
