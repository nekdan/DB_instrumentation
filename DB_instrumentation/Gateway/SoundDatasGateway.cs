using DB_instrumentation.Models;
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
            data.Description = soundsDatas.Description;
            data.SoundBase64 = soundsDatas.SoundBase64;
            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var sound = _dbContext.SoundsDatas.FirstOrDefault(s => s.Id == id);
            if (sound == null)
            {
                return false;
            }
            _dbContext.SoundsDatas.Remove(sound);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
