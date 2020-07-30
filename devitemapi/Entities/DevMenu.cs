using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entities
{
    public class DevMenu
    {
        public int Id { get; set; }

        public string MenuName { get; set; }

        public string Url { get; set; }

        public string Icon { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }

    }
}
