using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF010.CodeFirstMigration.Entities.OwnedEntities
{
    public class TimeSlot
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public override string ToString()
        {
            return $"{StartTime.ToString("hh\\:mm")} - {EndTime.ToString("hh\\:mm")}";
        }
    }
}
