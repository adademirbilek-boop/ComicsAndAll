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
    public class ViewUserUsecase : IViewUserUsecase
    {
        private readonly IUserProfileRepository userprofilerepo;
        public ViewUserUsecase(IUserProfileRepository userprofilerepo)
        {
            this.userprofilerepo = userprofilerepo;
        }
        public UserProfile? Execute(string id)
        {
            return userprofilerepo.GetById(id);
        }
    }
}
