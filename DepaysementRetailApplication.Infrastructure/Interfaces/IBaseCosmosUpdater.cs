using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DepaysementRetailApplication.Infrastructure.Interfaces
{
    public interface IBaseCosmosUpdater<T>
    {
        abstract Task<T> GetCurrentItemOrNull(DbContext context, string id, string partitionKey);
        abstract T GetMergedItem(T previousData, T existingData, T newData);
        Task<HttpStatusCode> TryUpsertItemAsync();
    }
}