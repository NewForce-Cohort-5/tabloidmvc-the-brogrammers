using System.Collections.Generic;
using TabloidMVC.Models;

namespace TabloidMVC.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        public void AddCategory(Category category);
        Category GetCategorygById(int id);
        public void DeleteCategory(int Id);
        public void UpdateCategory(Category category);
    }
}