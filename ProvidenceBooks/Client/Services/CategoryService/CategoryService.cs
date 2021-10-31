

using System.Collections.Generic;
using ProvidenceBooks.Shared;

namespace ProvidenceBooks.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category
                 {
                     Id = 1,
                     Name = "Apologetics",
                     Url = "apologetics",
                     Icon = "camera-slr"
                },
                new Category
                {
                     Id = 2,
                     Name = "Christian Living",
                     Url = "christianliving",
                     Icon = "camera-slr"
                },
                 new Category
                {
                     Id = 3,
                     Name = "Marriage & Family",
                     Url = "marriage",
                     Icon = "camera-slr"
                },
                 new Category
                {
                     Id = 4,
                     Name = "Commentaries",
                     Url = "commentaries",
                     Icon = "camera-slr"
                },
                 new Category
                {
                     Id = 5,
                     Name = "Bibles",
                     Url = "bibles",
                     Icon = "book"
                }
        };


        }
    }
}