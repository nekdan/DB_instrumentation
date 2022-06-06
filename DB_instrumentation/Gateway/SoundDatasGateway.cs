﻿using DB_instrumentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_instrumentation.Gateway
{
    public class SoundDatasGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(SoundsDatas soundsDatas)
        {
            _dbContext.SoundsDatas.Add(soundsDatas);
            return _dbContext.SaveChanges() > 0;
        }

        public List<SoundsDatas>GetAll()
        {
            return _dbContext.SoundsDatas.ToList();
        }

        public bool Update(SoundsDatas soundsDatas)
        {
            var data = _dbContext.SoundsDatas.FirstOrDefault(c => c.Id == soundsDatas.Id);
            if (data == null)
            {
                return false;
            }
            data.Id = soundsDatas.Id;
            return _dbContext.SaveChanges() > 0;
        }
    }
}
