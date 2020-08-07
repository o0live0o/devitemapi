using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}
