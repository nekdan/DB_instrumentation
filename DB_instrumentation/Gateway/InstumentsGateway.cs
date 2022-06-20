using DB_instrumentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_instrumentation.Gateway
{
    public class InstumentsGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public List<Instuments> GetAll()
        {
            return _dbContext.Instuments.ToList();
        }
    }
}
