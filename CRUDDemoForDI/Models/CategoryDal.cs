using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUDDemoForDI.Models
{
    // Data access layer

    // High level module=> categoryBAL
    //low level module => CategoryDAL
    public class CategoryDal
    {
        ICategoryDal _db;
        public CategoryDal(ICategoryDal db)
        {
            _db = db;
        }
        public List<Category> GetCategories()
        {
           // B24Entities db = new B24Entities();
            var categories= _db.Categories.ToList(); 
            return categories;
        }

        public Category GetCategory(int id)
        {
           // B24Entities db = new B24Entities();
            var category = _db.Categories.Find(id);
            return category;

        }

        public void Create(Category category)
        {
            //B24Entities db = new B24Entities();
            _db.Categories.Add(category);
            _db.SaveChanges();
        }


        public void Update(Category category) 
        {
            // B24Entities db = new B24Entities();
            _db.Entry<Category>(category).State= EntityState.Modified;
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
           // B24Entities db = new B24Entities();
            var category = _db.Categories.Find(id);
            _db.Categories.Remove(category);
            _db.SaveChanges();
        }
    }
}