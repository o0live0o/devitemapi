using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entities
{
    public class DevAction
    {
        public int Id { get; set; }

        public string ActionName { get; set; }

        public string ActionCode { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }

    }
}
