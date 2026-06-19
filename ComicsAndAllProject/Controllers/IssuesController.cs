using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.IssueInterfaces;
using ComicsAndAllProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ComicsAndAllProject.Controllers
{
    [Route("issues")]
    public class IssuesController : Controller
    {
        private readonly IGetAllIssuesUsecase _getAllIssues;
        private readonly IGetIssueUsecase _getIssue;
        private readonly IPublishersRepository _publishersRepository;
        public IssuesController(IGetAllIssuesUsecase getAllIssuesUsecase, IGetIssueUsecase getIssueUsecase, IPublishersRepository publishersRepository)
        {
            _getAllIssues = getAllIssuesUsecase;
            _getIssue = getIssueUsecase;
            _publishersRepository = publishersRepository;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            var issues = _getAllIssues.Execute();


            return View(issues);
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var issue = _getIssue.Execute(id);

            if (issue is null)
                return NotFound();

            if (issue.Series is null)
                return NotFound();

            var publisher = _publishersRepository.Get(issue.Series.PublisherId);

            if(publisher is null)
                return NotFound();

            var vm = new IssueDetailsViewModel
            {
                Id = id,
                Title = issue.Title,
                PublisherName = publisher.Name,
                Series = issue.Series,
                CoverImageUrl = issue.CoverImageUrl,
                ReleaseDate = issue.ReleaseDate,
                CoverDate = issue.CoverDate,
                IssueNumber = issue.IssueNumber,
                IssueOrder = issue.IssueOrder,



            };
            return View(vm);
        }
    }
}
