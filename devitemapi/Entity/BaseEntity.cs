using System;

namespace devitemapi.Entity
{
    public class BaseEntity<T> : IEntity<T>
    {
        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}