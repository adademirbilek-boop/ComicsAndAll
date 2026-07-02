using System.Security.Claims;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.UseCases.CharacterInterfaces;
using ComicsAndAllProject.UseCases.FavoriteCharacterInterfaces;
using ComicsAndAllProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ComicsAndAllProject.Controllers
{
    [Route("characters")]
    public class CharactersController : Controller
    {
        private readonly IGetAllCharactersUsecase _getAllCharactersUsecase;
        private readonly IGetCharacterByIdUsecase _getCharacterByIdUsecase;
        private readonly IPublishersRepository _publishersRepository;
        private readonly ISearchCharactersUsecase _searchCharactersUsecase;
        private readonly IAddFavoriteCharacterUsecase _addFavoriteCharacterUsecase;
        private readonly IFavoriteCharacterExistsUsecase _favoriteCharacterExistsUsecase;

        public CharactersController(IGetAllCharactersUsecase getAllCharactersUsecase, IGetCharacterByIdUsecase getCharacterByIdUsecase,IPublishersRepository publishersRepository, ISearchCharactersUsecase searchCharactersUsecase, IAddFavoriteCharacterUsecase addFavoriteCharacterUsecase, IFavoriteCharacterExistsUsecase favoriteCharacterExistsUsecase)
        {
            _getAllCharactersUsecase = getAllCharactersUsecase;
            _getCharacterByIdUsecase = getCharacterByIdUsecase;
            _publishersRepository = publishersRepository;
            _searchCharactersUsecase = searchCharactersUsecase;
            _addFavoriteCharacterUsecase = addFavoriteCharacterUsecase;
            _favoriteCharacterExistsUsecase = favoriteCharacterExistsUsecase;
        }
        public IActionResult Index(string? name)
        {
            IEnumerable<Character> chars;
            if (name.IsNullOrEmpty())
            {
                 chars = _getAllCharactersUsecase.Execute();
            }
            else
            {
                 chars = _searchCharactersUsecase.Execute(name);
            }
            ViewBag.SearchTerm = name;
                return View(chars);
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var character = _getCharacterByIdUsecase.Execute(id);
            if (character == null)
                return NotFound();
            var publisher = _publishersRepository.Get(character.PublisherId);
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var vm = new CharactersPageViewModel
            {
                Id = character.Id,
                Name = character.Name,
                RealName = character.RealName,
                PublisherName = publisher?.Name,
                ImageUrl = character.ImageUrl,
                IsFavorited = User.Identity?.IsAuthenticated == true
            && userId != null
            && _favoriteCharacterExistsUsecase.Execute(userId, character.Id)
            };

            return View(vm);
        }





        

            
        
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Favorite(int characterId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
                return Unauthorized();

            _addFavoriteCharacterUsecase.Execute(userId, characterId);
            return RedirectToAction("Details", new {id = characterId });
        } 
    }
}
