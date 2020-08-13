using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Dtos
{
    public class UserDto: BaseDto
    {
        public string UserName { get; set; }

        public string Account { get; set; }

        public string Pwd { get; set; }

        public string Address { get; set; }

        public string EMail { get; set; }

        public string Phone{ get; set; }

        public int Status { get; set; }

        public String IDCard { get; set; }
    }
}
