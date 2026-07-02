using System.Security.Claims;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Plugins.EFCore.Data;
using ComicsAndAllProject.UseCases.FavoriteCharacterInterfaces;
using ComicsAndAllProject.UseCases.UserProfileInterfaces;
using ComicsAndAllProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ComicsAndAllProject.Controllers
{
    [Route("profile")]
    public class ProfileController : Controller
    {
        private readonly IGetAllUsersUsecase _getAllUsersUsecase;
        private readonly IViewUserUsecase _viewUserUsecase;
        private readonly IDeleteUserUsecase _deleteUserUsecase;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ComicsAndAllDbContext _context;
        private readonly IRemoveFromFavoriteCharactersUsecase _removeFromFavoriteCharactersUsecase;

        public ProfileController(
            IGetAllUsersUsecase getAllUsersUsecase,
            IViewUserUsecase viewUserUsecase,
            IDeleteUserUsecase deleteUserUsecase,
            UserManager<IdentityUser> userManager,
            ComicsAndAllDbContext context,
           IRemoveFromFavoriteCharactersUsecase removeFromFavoriteCharactersUsecase)
        {
            _getAllUsersUsecase = getAllUsersUsecase;
            _viewUserUsecase = viewUserUsecase;
            _deleteUserUsecase = deleteUserUsecase;
            _userManager = userManager;
            _context = context;
            _removeFromFavoriteCharactersUsecase = removeFromFavoriteCharactersUsecase;
        }

        [HttpGet("")]
        [HttpGet("{id}")]
        [HttpGet("/issues/profile")]
        public async Task<IActionResult> Index(string? id = null)
        {
            id ??= User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrWhiteSpace(id))
                return Challenge();

            var profile = _viewUserUsecase.Execute(id);

            if (profile == null && User.FindFirstValue(ClaimTypes.NameIdentifier) == id)
            {
                profile = await CreateMissingProfileAsync(id);
            }

            if (profile == null)
                return NotFound();

            var vm = new ProfileViewModel
            {
                Id = id,
                Name = profile.Name,
                Bio = profile.Bio,
                ProfileImageUrl = profile.ProfileImageUrl,
                JoinedIn = profile.JoinedIn,
                FavoriteCharacters = profile.FavoriteCharacters,
                FavoriteIssues = [],
                FavoriteSeries = [],
                FavoriteVolumes = [],
                IsOwn = User.FindFirstValue(ClaimTypes.NameIdentifier) == id
            };

            return View(vm);
        }

        private async Task<UserProfile?> CreateMissingProfileAsync(string id)
        {
            var identityUser = await _userManager.FindByIdAsync(id);
            if (identityUser == null)
                return null;

            var profile = new UserProfile
            {
                Id = id,
                Name = identityUser.UserName ?? identityUser.Email ?? "User",
                Email = identityUser.Email ?? string.Empty,
                Password = string.Empty,
                JoinedIn = DateOnly.FromDateTime(DateTime.UtcNow)
            };

            _context.UserProfiles.Add(profile);
            await _context.SaveChangesAsync();

            return profile;
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFavoriteCharacter(int characterId)
        {
            

            var currentUser = await _userManager.GetUserAsync(User);
            
            if (currentUser == null)
                return Unauthorized();

            
            _removeFromFavoriteCharactersUsecase.Execute(currentUser.Id, characterId );
            

            return RedirectToAction(nameof(Index));



        }
    }
}