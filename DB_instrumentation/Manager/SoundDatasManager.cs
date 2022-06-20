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
        SoundDatasGateway _soundDatasGateway = new SoundDatasGateway();

        public bool Add(SoundsDatas soundDatas)
        {
            return _soundDatasGateway.Add(soundDatas);
        }

        public List<SoundsDatas>GetAll()
        {
            return _soundDatasGateway.GetAll();
        }

        public bool Update(SoundsDatas soundsDatas)
        {
            return _soundDatasGateway.Update(soundsDatas);
        }
    }
}
