using DelphinService.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace DelphinService.DAL.Entities
{
    public abstract class Entity<T> : IEntity<T>
    {
        [Key]
        public abstract T Id { get; set; }
    }
}
