using System;

namespace Events.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}
