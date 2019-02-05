using DelphinService.DAL.Entities.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelphinService.DAL.Entities
{
    class Organization : Entity<int> 
    {
        public override int Id { get; set; }
        public string ShotrName { get; set; }
        public string FullName { get; set; }
        public string CodeEDRPOU { get; set; }
        public Addres Addres { get; set; }
        public Addres PostalAddres { get; set; }
    }
}
