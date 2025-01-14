using CRUD_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD_EF.Controllers
{
    public class CategoryController : ApiController
    {
        CategoryDbContext dbContext = new CategoryDbContext();
        public IHttpActionResult GetAll()
        {
            
             var categories=dbContext.Categories.ToList();
            return Ok(categories);
        }


        public IHttpActionResult GetCategoryById(int id)
        {
            var category = dbContext.Categories.Find(id);

            return Ok(category);
        }

        [HttpPost]
        public IHttpActionResult PostCategory(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
            return Created("DefaultApi",category);
        }

        public IHttpActionResult UpdateCategory(int? id, Category category)
        {
            var DBCategory = dbContext.Categories.Find(id);
            if (DBCategory.id != id)
            {
                DBCategory.Name = category.Name;
                DBCategory.Rating = category.Rating;
                dbContext.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

        public IHttpActionResult Delete(int? id)
        {
          if (id > 0)
          {
           var cat=dbContext.Categories.Find(id);
            if (cat !=null)
            {
                dbContext.Categories.Remove(cat);
                return Ok();
            }
                return NotFound();
          }
            return BadRequest();
        }
    }
}
