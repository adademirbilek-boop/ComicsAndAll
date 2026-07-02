using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAndAllProject.Core.Entities
{
    public class FavoriteCharacter
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }

        public string UserId { get; set; } = null!;

        public DateTime FavDate { get; set; } = DateTime.UtcNow;


    }
}
