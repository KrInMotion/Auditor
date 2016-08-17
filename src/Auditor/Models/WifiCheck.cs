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
        public User Responsible { get; set; }
    }
}
