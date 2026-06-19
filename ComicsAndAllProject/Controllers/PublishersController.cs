using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.UseCases.Interfaces;
using ComicsAndAllProject.UseCases.PublisherInterfaces;
using ComicsAndAllProject.UseCases.SeriesInterfaces;
using ComicsAndAllProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ComicsAndAllProject.Controllers
{
    [Route("publishers")]
    public class PublishersController : Controller
    {

        private readonly IGetPublisherUsecase _getPublisherUsecase;
        private readonly IGetAllPublishersUsecase _getAllPublishersUsecase;
        private readonly ISearchPublishersUsecase _searchPublishersUsecase;
        private readonly IGetSeriesByIdUsecase _getSeriesByIdUsecase;
        private readonly IGetSeriesByPublisherIdUsecase _getSeriesByPublisherIdUsecase;

        public PublishersController(IGetPublisherUsecase getPublisherUsecase, IGetAllPublishersUsecase getAllPublishersUsecase, ISearchPublishersUsecase searchPublishersUsecase, IGetSeriesByIdUsecase getSeriesByIdUsecase, IGetSeriesByPublisherIdUsecase getSeriesByPublisherIdUsecase)
        {
            _getPublisherUsecase = getPublisherUsecase;
            _getAllPublishersUsecase = getAllPublishersUsecase;
            _searchPublishersUsecase = searchPublishersUsecase;
            _getSeriesByIdUsecase = getSeriesByIdUsecase;
            _getSeriesByPublisherIdUsecase = getSeriesByPublisherIdUsecase;
        }
        [HttpGet("")]
        public IActionResult Index(string? name)
        {
            IEnumerable<Publisher> publishers;
            if (name.IsNullOrEmpty())
            {
                publishers = _getAllPublishersUsecase.Execute();
            }
            else
            {
                publishers = _searchPublishersUsecase.Execute(name);
            }
            ViewBag.SearchTerm = name;

                return View(publishers);
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var Publisher = _getPublisherUsecase.Execute(id);
            if(Publisher == null) 
                return NotFound();

            var Series = _getSeriesByPublisherIdUsecase.Execute(id);
            ;

            var vm = new PublisherDetailsViewModel
            {
                Id = id,
                Name = Publisher.Name,
                Series = Series.ToList()
            };

            return View(vm);
        }
    }
}
