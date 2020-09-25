using System;

namespace devitemapi.Entity
{
    public class IEntity<T>
    {
        public T Id { get; set; }
    }
}