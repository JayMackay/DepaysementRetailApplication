using System.Net;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DepaysementRetailApplication.Infrastructure.Interfaces;

namespace DepaysementRetailApplication.Infrastructure.CosmosUpdaters
{
    public class BaseCosmosUpdater<T> : IBaseCosmosUpdater<T>
    {
        public async Task<T> GetCurrentItemOrNull(DbContext context, string id, string partitionKey)
        {
            throw new NotImplementedException();
        }

        public T GetMergedItem(T previousData, T existingData, T newData)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpStatusCode> TryUpsertItemAsync()
        {
            throw new NotImplementedException();
        }
    }
}