using System;
using System.ComponentModel.DataAnnotations;

namespace devitemapi.Entity
{
    public class IEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}