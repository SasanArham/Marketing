using Domain.Aggregates.DraftFunnels;
using Domain.Aggregates.DraftFunnels.Services;
using MongoDB.Driver;
using Repository.Base;

namespace Repository
{
    public class DraftFunnelRepository : IDraftFunnelRepository
    {
        private readonly IMongoCollection<DraftFunnel> _draftFunnelCollection;

        public DraftFunnelRepository(MongoClient mongoClient)
        {
            var mongoDatabase = mongoClient.GetDatabase("MarketingDB");
            _draftFunnelCollection = mongoDatabase.GetCollectionOfType<DraftFunnel>();
        }

        public async Task InsertAsync(DraftFunnel draftFunnel, CancellationToken cancellationToken)
        {
            await _draftFunnelCollection.InsertOneAsync(draftFunnel, cancellationToken);
        }

        public async Task<DraftFunnel> Find(Guid ID)
        {
            var draftFunnel = await _draftFunnelCollection.Find(c => c.ID == ID).FirstOrDefaultAsync();
            return draftFunnel;
        }
    }
}
