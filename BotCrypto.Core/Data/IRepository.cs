using BotCrypto.Core.DomainObjects;
using System;

namespace BotCrypto.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
