﻿using DB_instrumentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_instrumentation.Manager
{
    public class SubsoundsManager
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public List<Subsounds> GetAll()
        {
            return _dbContext.Subsounds.ToList();
        }
    }
}
