using System.Threading.Tasks;
using System.Xml.Serialization;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.Interfaces;
using ComicsAndAllProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ComicsAndAllProject.Controllers
{
    [Route ("series")]
    public class SeriesController : Controller
    {
        private readonly IViewSeriesUsecase _viewSeriesUsecase;
        private readonly IGetSeriesByIdUsecase _getSeriesByIdUsecase;
        private readonly IPublishersRepository _publishersRepository;
        public SeriesController(IViewSeriesUsecase viewSeriesUsecase, IGetSeriesByIdUsecase getSeriesByIdUsecase, IPublishersRepository publishersRepository)
        {
            _viewSeriesUsecase = viewSeriesUsecase;
            _getSeriesByIdUsecase = getSeriesByIdUsecase;
            _publishersRepository = publishersRepository;
        }
        public IActionResult Index()
        {
            var Series = _viewSeriesUsecase.Execute();
            return View(Series);
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            
            var Series = _getSeriesByIdUsecase.Execute(id);

            if(Series is null)
                return NotFound();

            var publisher = _publishersRepository.Get(Series.PublisherId);

            if(publisher is null)
                return NotFound();

            

            var vm = new SeriesDetailsViewModel
            {
                Id = Series.Id,
                Title = Series.Title,
                PublisherName = publisher.Name,

                Issues = Series.Issues.OrderBy(x => x.IssueOrder).Select(x => new IssueListViewModel
                {
                    id = x.Id,
                    IssueNumber = x.IssueNumber,
                    IssueOrder = x.IssueOrder,
                    Title = x.Title
                })
                .ToList()
            };



            return View(vm);
        }
    }
}
