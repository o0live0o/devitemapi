using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entity
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}
