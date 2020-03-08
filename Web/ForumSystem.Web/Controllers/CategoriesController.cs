using ForumSystem.Services.Data;
using ForumSystem.Web.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;

namespace ForumSystem.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult ByName(string name)
        {
            CategoryViewModel viewModel = 
                this.categoriesService.GetByName<CategoryViewModel>(name);

            return this.View(viewModel);
        }
    }
}
