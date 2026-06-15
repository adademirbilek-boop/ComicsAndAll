using ComicsAndAllProject.UseCases.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComicsAndAllProject.Controllers
{
    [Route ("series")]
    public class SeriesController : Controller
    {
        private readonly IViewSeriesUsecase _viewSeriesUsecase;

        public SeriesController(IViewSeriesUsecase viewSeriesUsecase)
        {
            _viewSeriesUsecase = viewSeriesUsecase;
        }
        public IActionResult Index()
        {
            var Series = _viewSeriesUsecase.Execute();
            return View(Series);
        }
    }
}
