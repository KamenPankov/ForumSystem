using ForumSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem.Data.Seeding
{
    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            List<string> categories = new List<string>()
            {
                "Sport",
                "Coronavirus",
                "News",
                "Music",
                "Programming",
                "Cats",
                "Dogs",
            };

            foreach (string category in categories)
            {
                await dbContext.Categories.AddAsync(new Category()
                {
                    Name = category,
                    Description = category,
                    Title = category,
                });
            }
        }
    }
}
