using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAndAllProject.Core.Entities
{
    public class UserProfile
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string? Bio {  get; set; }

        public string? ProfileImageUrl { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public IEnumerable<Character> FavoriteCharacters { get; set; } = [];

        public DateOnly JoinedIn { get; set; }

        
    }
}
