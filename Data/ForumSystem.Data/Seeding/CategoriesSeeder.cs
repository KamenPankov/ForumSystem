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

            List<Tuple<string, string>> categories = new List<Tuple<string, string>>()
            {
               new Tuple<string, string>("Sport", "https://cdn.radiofrance.fr/s3/cruiser-production/2018/08/a34ee637-a1a0-464b-960e-ad9c93e3ab02/870x489_gettyimages-930207070_sorapong_chaipanya-eyeem.jpg"),
               new Tuple<string, string>("Coronavirus", "https://www.hopkinsmedicine.org/-/media/images/health/1_-conditions/infectious-diseases/coronavirus-hero.ashx?h=500&la=en&mh=500&mw=1300&w=1297&hash=6464CC9E4F6364821A5973E670CFB3342C2D9AF4"),
               new Tuple<string, string>("News", "https://newstravel.bg/wp-content/uploads/2019/08/Marketplace-Lending-News.jpg"),
               new Tuple<string, string>("Music", "https://www.jananews.com/wp-content/uploads/2019/11/p07gq3kw.jpg"),
               new Tuple<string, string>("Programming", "https://miro.medium.com/max/10000/1*HLGtY6O2vUHqIyEbWdmBgA.jpeg"),
               new Tuple<string, string>("Cats", "https://a57.foxnews.com/media2.foxnews.com/BrightCove/694940094001/2019/04/05/931/524/694940094001_6022906316001_6022911719001-vs.jpg?ve=1&tl=1"),
               new Tuple<string, string>("Dogs", "https://www.therapydogs.com/wp-content/uploads/2019/12/german.jpg"),
            };

            foreach (Tuple<string, string> category in categories)
            {
                await dbContext.Categories.AddAsync(new Category()
                {
                    Name = category.Item1,
                    Description = category.Item1,
                    Title = category.Item1,
                    ImageUrl = category.Item2,
                });
            }
        }
    }
}
