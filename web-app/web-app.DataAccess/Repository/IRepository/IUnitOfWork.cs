using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_app.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
       ICategoryRepository Category{ get; }
        void Save();
    }
}
