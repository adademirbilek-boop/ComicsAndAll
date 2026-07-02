using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.Core.RepositoryInterfaces
{
    public interface IUserProfileRepository
    {
        UserProfile? GetById(string id);

        IEnumerable<UserProfile> List();

        void Delete(string id);
    }
}
