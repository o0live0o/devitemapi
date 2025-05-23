﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace devitemapi.Entity
{
    public class DevUser : BaseEntity<Guid>
    {
        //[RegularExpression(@"^[u4e00-u9fa5]{0,10}|^[A-Z]{1}[a-zA-Z.\s]{0,30}$")]
        [Required]
        public string UserName { get; set; }

        [RegularExpression(@"^[a-zA-Z]{1}[a-zA-Z0-9]{5,19}$", ErrorMessage = "用户账号长度至少5，最大20")]
        public string Account { get; set; }

        //[RegularExpression(@"^([a-zA-Z0-9]{8,16}|[@_!#]{1})$")]
        [Required]
        public string Pwd { get; set; }

        [RegularExpression(@"^[^\s].*[^\s].*$")]
        public string Address { get; set; }

        public string EMail { get; set; }

        public string Phone { get; set; }

        public int Status { get; set; }

        public List<DevUserRole> DevUserRoles {get;} = new List<DevUserRole>();
    }
}