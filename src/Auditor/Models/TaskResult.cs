using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auditor.Models
{
    public class TaskResult
    {
        public int Id { get; set; }
        public string ResultName { get; set; }
        public bool NeedReAction { get; set; }
    }
}
