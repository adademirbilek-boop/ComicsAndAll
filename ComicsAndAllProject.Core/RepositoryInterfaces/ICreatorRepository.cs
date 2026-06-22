using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.Core.RepositoryInterfaces
{
    public interface ICreatorRepository
    {
        IEnumerable<Creator> GetAll();

        Creator Get(int id);

        IEnumerable<Creator> Search(string? name);
    }
}
