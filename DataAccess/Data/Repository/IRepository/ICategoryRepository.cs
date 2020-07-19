using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data.Repository
{
    public interface ICategoryRepository: IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDwon();
        void Update(Category category);
    }
}
