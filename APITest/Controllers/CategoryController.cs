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

        [HttpGet]
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

        [HttpPut]
        public IHttpActionResult UpdateCategory([FromUri]int? id,[FromBody] Category category)
        {
            if (id > 0)
            {
                if (id == category.id)
                {
                    var DBCategory = dbContext.Categories.Find(id);
                    if (DBCategory!= null)
                    {
                        DBCategory.Name = category.Name;
                        DBCategory.Rating = category.Rating;
                        dbContext.SaveChanges();
                        return Ok();
                    }
                    return BadRequest();
                }
                return BadRequest();
            }
            return BadRequest();
        }

        [HttpDelete]
        public IHttpActionResult Delete([FromUri]int? id)
        {
          if (id > 0)
          {
           var cat=dbContext.Categories.Find(id);
            if (cat !=null)
            {
                dbContext.Categories.Remove(cat);
                dbContext.SaveChanges() ;
                return Ok();
            }
                return NotFound();
          }
            return BadRequest();
        }
    }
}
