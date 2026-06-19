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
    public class GetAllIssuesUsecase : IGetAllIssuesUsecase
    {
        private readonly IIssuesRepository issuesrepo;
        public GetAllIssuesUsecase(IIssuesRepository issuesrepo)
        {
            this.issuesrepo = issuesrepo;
        }
        public IEnumerable<Issue> Execute()
        {
            return issuesrepo.GetAll();
        }
    }
}
