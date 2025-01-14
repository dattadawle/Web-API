using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDDemoForDI.Models
{
    // business access layer
    public class CategoryBAL
    {
        public List<Category> GetCategories()
        {
            CategoryDal dal = new CategoryDal();
            return dal.GetCategories();
        }

        public Category GetCategory(int id)
        {
            CategoryDal dal = new CategoryDal();
            return dal.GetCategory(id);
        }

        public void Create(Category category)
        {
            CategoryDal dal = new CategoryDal();
            dal.Create(category);
        }
        public void Update(Category category)
        {
            CategoryDal dal = new CategoryDal();
             dal.Update(category);
        }
        public void Delete(int id)
        {
            CategoryDal dal = new CategoryDal();
            dal.Delete(id);
        }
    }
}