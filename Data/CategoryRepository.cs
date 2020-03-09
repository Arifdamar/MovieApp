using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository(){
            _categories = new List<Category>()
            {
                new Category() { Id=1, Name="Comedy"},
                new Category() { Id=2, Name="Drama"},
                new Category() { Id=3, Name="Thriller"},
                new Category() { Id=4, Name="Fantasy"},
                new Category() { Id=5, Name="Horror"},
                new Category() { Id=6, Name="Mystery"},
                new Category() { Id=7, Name="Sci-Fi"},
                new Category() { Id=8, Name="Adventure"}
            };
        }

        public static List<Category> Categories{ get { return _categories; } }

        public static void AddCategory(Category entity){
            _categories.Add(entity);
        }

        public static Category GetById(int id){
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}