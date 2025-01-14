using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDUsingEF.Models
{
    public class ProductDBContext :DbContext
    {
        DbSet<Category> Categories { get; set; }
    }
}