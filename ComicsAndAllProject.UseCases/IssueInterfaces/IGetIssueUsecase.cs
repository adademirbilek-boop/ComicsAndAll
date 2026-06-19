using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.UseCases.IssueInterfaces
{
    public interface IGetIssueUsecase
    {
        Issue Execute(int id);
    }
}
