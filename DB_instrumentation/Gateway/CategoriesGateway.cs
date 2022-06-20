using DB_instrumentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_instrumentation.Gateway
{
    public class CategoriesGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public List<Categories> GetAll()
        {
            return _dbContext.Categories.ToList();
        }

    }
}
