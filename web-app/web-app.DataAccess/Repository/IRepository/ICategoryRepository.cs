using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_app.Models;

namespace web_app.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
 
        void Update(Category obj);
    }
}
