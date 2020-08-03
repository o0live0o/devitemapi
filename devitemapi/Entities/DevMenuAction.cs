using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entities
{
    public class DevMenuAction
    {
        public int Id { get; set; }

        public int MenuId { get; set; }

        public int ActionId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }

    }
}
