using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.Core.RepositoryInterfaces
{
    public interface IIssuesRepository
    {
        IEnumerable<Issue> GetAll();

        Issue Get(int id);
    }
}
