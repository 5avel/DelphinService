using DelphinService.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DelphinService.DAL.Entities
{
    public class SampleEntity : Entity<int>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [Range(2, 1000)]
        public int Count { get; set; }


        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public SampleEnum SampleField { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public SampleEntity() { }


    }
}
