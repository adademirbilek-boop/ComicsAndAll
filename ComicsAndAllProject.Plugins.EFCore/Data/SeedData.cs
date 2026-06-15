using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.Plugins.EFCore.Data
{
    public static class SeedData
    {
        public static void Seed(ComicsAndAllDbContext context)
        {
            if (!context.Publishers.Any())
            {
                context.Publishers.AddRange(
                    new Publisher { Name = "DC Comics" },
                    new Publisher { Name = "Marvel Comics" },
                    new Publisher { Name = "Image Comics" }
                );

                context.SaveChanges();
            }
        }
    }
}
