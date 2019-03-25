using DelphinService.DAL.Interfaces.Repositoryes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelphinService.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ISamplesRepository SamplesRepository { get; }
    }
}
