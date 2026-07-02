using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;
using ComicsAndAllProject.Core.RepositoryInterfaces;
using ComicsAndAllProject.Plugins.EFCore.Data;

namespace ComicsAndAllProject.Plugins.EFCore.Repositories
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly ComicsAndAllDbContext _context;
        public UserProfileRepository(ComicsAndAllDbContext context)
        {
            _context = context;
        }
        public IEnumerable<UserProfile> List()
        {
            var users = _context.UserProfiles.ToList();

            foreach (var user in users)
            {
                LoadFavoriteCharacters(user);
            }

            return users;
        }

        public UserProfile? GetById(string id)
        {
            var user = _context.UserProfiles.FirstOrDefault(x => x.Id == id);

            if (user is null)
                return null;

            LoadFavoriteCharacters(user);
            return user;
        }

        public void Delete(string id)
        {
            var userToDelete = _context.UserProfiles.FirstOrDefault(x => x.Id == id);
            if (userToDelete is null) 
                return;

             _context.UserProfiles.Remove(userToDelete);
            _context.SaveChanges();
        }

        private void LoadFavoriteCharacters(UserProfile user)
        {
            var favoriteCharacterIds = _context.FavoriteCharacters
                .Where(favoriteCharacter => favoriteCharacter.UserId == user.Id)
                .Select(favoriteCharacter => favoriteCharacter.CharacterId)
                .ToList();

            user.FavoriteCharacters = _context.Characters
                .Where(character => favoriteCharacterIds.Contains(character.Id))
                .ToList();
        }
    }
}