using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDemoForDI.Models
{
    internal interface ICategoryDal
    {
        List<Category> GetCategories();

        Category GetCategory(int id);
        void Create(Category category);
        void Update(Category category);
        void Delete(int id);

    }
}
