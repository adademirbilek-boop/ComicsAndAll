using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.UseCases.CreatorInterfaces;
using ComicsAndAllProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ComicsAndAllProject.Controllers
{
    [Route("creators")]
    public class CreatorsController : Controller
    {
        private readonly IGetAllCreatorsUsecase _getAllCreatorsUsecase;
        private readonly IGetCreatorByIdUsecase _getCreatorByIdUsecase;
        private ISearchCreatorsUsecase _searchCreatorsUsecase;

        public CreatorsController(IGetAllCreatorsUsecase getAllCreatorsUsecase, IGetCreatorByIdUsecase getCreatorByIdUsecase, ISearchCreatorsUsecase searchCreatorsUsecase)
        {
            _getAllCreatorsUsecase = getAllCreatorsUsecase;
            _getCreatorByIdUsecase = getCreatorByIdUsecase;
            _searchCreatorsUsecase = searchCreatorsUsecase;
        }
        [HttpGet("")]
        public IActionResult Index(string? name)
        {
            IEnumerable<Creator> creators;
            if (name.IsNullOrEmpty())
            {
                creators = _getAllCreatorsUsecase.Execute();
            }
            else
            {
                creators = _searchCreatorsUsecase.Execute(name);
            }
            ViewBag.SearchTerm = name;

            return View(creators);
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var creator = _getCreatorByIdUsecase.Execute(id); 
            if(creator is null)
                return NotFound();

            var vm = new CreatorDetailsViewModel
            {
                Id = id,
                Name = creator.Name
            };
            return View(vm);

        }
    }
}
