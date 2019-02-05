using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DelphinService.DAL.Entities.Location
{
    public class Addres : Entity<int>
    {
        public override int Id { get; set; }
        [Required, MaxLength(6), MinLength(5)]
        public string PostalCode { set; get; }
        [Required]
        public Region Region { get; set; }
        [Required]
        public Sity Sity { get; set; }

        public string URAddress { get; set; }
    }
}
