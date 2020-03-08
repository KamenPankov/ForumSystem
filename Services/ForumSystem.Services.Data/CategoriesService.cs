using System.Collections.Generic;
using System.Linq;

using ForumSystem.Data.Common.Repositories;
using ForumSystem.Data.Models;
using ForumSystem.Services.Mapping;

namespace ForumSystem.Services.Data
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Category> query = this.categoriesRepository.All()
                .OrderBy(c => c.Name);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToArray();
        }

        public T GetByName<T>(string name)
        {
            return this.categoriesRepository.All()
                .Where(c => c.Name == name)
                .To<T>()
                .FirstOrDefault();
        }
    }
}
