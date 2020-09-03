using System;

namespace devitemapi.Dto.User
{
    public class UserUpdateDto
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }

        public string Account { get; set; }

        public string Pwd { get; set; }

        public string Address { get; set; }

        public string EMail { get; set; }

        public string Phone { get; set; }

        public int Status { get; set; }
    }
}