using System.ComponentModel.DataAnnotations;

namespace DelphinService.DAL.Entities.Location
{
    public class Sity : Entity<int>
    {
        public override int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
