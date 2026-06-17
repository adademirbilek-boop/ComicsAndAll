using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.CharacterInterfaces;
using ComicsAndAllProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ComicsAndAllProject.Controllers
{
    [Route("characters")]
    public class CharactersController : Controller
    {
        private readonly IGetAllCharactersUsecase _getAllCharactersUsecase;
        private readonly IGetCharacterByIdUsecase _getCharacterByIdUsecase;
        private readonly IPublishersRepository _publishersRepository;

        public CharactersController(IGetAllCharactersUsecase getAllCharactersUsecase, IGetCharacterByIdUsecase getCharacterByIdUsecase,IPublishersRepository publishersRepository)
        {
            _getAllCharactersUsecase = getAllCharactersUsecase;
            _getCharacterByIdUsecase = getCharacterByIdUsecase;
            _publishersRepository = publishersRepository;
        }
        public IActionResult Index()
        {
            var chars = _getAllCharactersUsecase.Execute();
            return View(chars);
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var character = _getCharacterByIdUsecase.Execute(id);
            if (character == null)
                            return NotFound();
            var publisher = _publishersRepository.Get(character.PublisherId);
            var vm = new CharactersPageViewModel
            {
                Id = character.Id,
                Name = character.Name,
                RealName = character.RealName,
                PublisherName = publisher?.Name,
                ImageUrl = character.ImageUrl

            };

            return View(vm);
        }
    }
}
