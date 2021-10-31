using ProvidenceBooks.Shared;
using System.Collections.Generic;


namespace ProvidenceBooks.Client.Services.CategoryService
{
    interface ICategoryService
    {
        public List<Category> Categories { get; set; }
        void LoadCategories();
    }
}