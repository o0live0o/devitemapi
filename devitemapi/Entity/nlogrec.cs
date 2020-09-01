using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entity
{
    public class nlogrec
    {
        public int Id { get; set; }
        public string Application { get; set; }
        public string Levels { get; set; }
        public string Operatingtime { get; set; }
        public string Operatingaddress { get; set; }
        public string Userid { get; set; }
        public string Logger { get; set; }
        public string Callsite { get; set; }
        public string Requesturl { get; set; }
        public string Referrerurl { get; set; }
        public string Action { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string LogContent { get; set; }
    }
}
