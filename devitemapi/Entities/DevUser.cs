using devitemapi.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entities
{
    public class DevUser
    {
        public int Id { get; set; }

        [RegularExpression(@"^*$", ErrorMessage = "")]
        public string UserName { get; set; }

        public string Account { get; set; }

        public string Pwd { get; set; }

        public string Address { get; set; }

        public string EMail { get; set; }

        public string Phone { get; set; }

        public int Status { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }

    }
}
