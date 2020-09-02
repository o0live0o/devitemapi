using System;

namespace devitemapi.Dto
{
    public class BaseDto
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}