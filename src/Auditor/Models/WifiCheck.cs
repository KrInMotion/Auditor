using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auditor.Models
{
    public class WifiCheck
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Provider { get; set; }
        public int UserId { get; set; }
        public AuditorUser Responsible { get; set; }
        public int TerritoryId { get; set; }
        public Territory Territory { get; set; }
        public DateTime CheckDate { get; set; }
        public int ViolationsCount { get; set; }
        public int TaskTime { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
