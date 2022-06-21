using DB_instrumentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_instrumentation.Gateway
{
    public class SoundsGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public List<Sounds> GetAll()
        {
            return _dbContext.Sounds.ToList();
        }
    }
}
