using DB_instrumentation.Gateway;
using DB_instrumentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_instrumentation.Manager
{
    public class CategoriesManager
    {
        CategoriesGateway _categoriesGateway = new CategoriesGateway();

        public List<Categories> GetAll()
        {
            return _categoriesGateway.GetAll();
        }
    }
}
