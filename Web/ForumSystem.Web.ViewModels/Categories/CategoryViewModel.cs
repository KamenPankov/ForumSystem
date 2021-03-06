﻿using System;
using System.Collections.Generic;
using System.Text;

using ForumSystem.Data.Models;
using ForumSystem.Services.Mapping;

namespace ForumSystem.Web.ViewModels.Categories
{
    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IEnumerable<PostInCategoryViewModel> Posts { get; set; }
    }
}
