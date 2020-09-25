using System;

namespace devitemapi.Entity
{
    public class BaseEntity<T> : IEntity<T>
    {
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string CreateUserId { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModifyDate { get; set; } = DateTime.Now;
        public string ModifyUserId { get; set; }
        public string ModifyUser { get; set; }
    }
}