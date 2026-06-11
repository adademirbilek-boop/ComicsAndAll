using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAndAllProject.Core.Entities
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? RealName { get; set; }

        public int PublisherId { get; set; }

        public string? ImageUrl { get; set; }

    }
}
