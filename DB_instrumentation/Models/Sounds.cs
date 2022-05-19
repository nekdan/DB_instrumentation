using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_instrumentation.Models
{
    public class Sounds
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubinstumentId { get; set; }
        public int InstumentId { get; set; }
        public int SubinstrumentId { get; set; }
    }
}
