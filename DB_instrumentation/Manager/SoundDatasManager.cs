using DB_instrumentation.Gateway;
using DB_instrumentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_instrumentation.Manager
{
    public class SoundDatasManager
    {
        SoundDatasGateway soundDatasGateway = new SoundDatasGateway();

        public bool Add(SoundsDatas soundDatas)
        {
            return soundDatasGateway.Add(soundDatas);
        }

        public List<SoundsDatas>GetAll()
        {
            return soundDatasGateway.GetAll();
        }

        public bool Update(SoundsDatas soundsDatas)
        {
            return soundDatasGateway.Update(soundsDatas);
        }
    }
}
