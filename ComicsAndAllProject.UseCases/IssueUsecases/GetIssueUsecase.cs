using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.IssueInterfaces;

namespace ComicsAndAllProject.UseCases.IssueUsecases
{
    public class GetIssueUsecase : IGetIssueUsecase
    {
        private readonly IIssuesRepository issuesrepo;
        public GetIssueUsecase(IIssuesRepository issuesrepo)
        {
            this.issuesrepo = issuesrepo;
        }
        public Issue Execute(int id)
        {
            return issuesrepo.Get(id);
        }
    }
}
