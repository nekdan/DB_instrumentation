using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_instrumentation.Models
{
    public class SoundsDatas
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string SoundBase64 { get; set; }
        public int SoundId { get; set; }
        public int SubsoundId { get; set; }
    }
}
