using System;
using System.Collections.Generic;
using System.Text;

namespace DelphinService.Common.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
