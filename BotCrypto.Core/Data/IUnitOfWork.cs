using System.Threading.Tasks;

namespace BotCrypto.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
