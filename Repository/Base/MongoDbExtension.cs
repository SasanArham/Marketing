using MongoDB.Driver;

namespace Repository.Base
{
    public static class MongoDbExtension
    {
        public static IMongoCollection<TDocument> GetCollectionOfType<TDocument>(this IMongoDatabase mongoDatabase)
        {
            var typeName = typeof(TDocument).Name;
            var mongoCollection = mongoDatabase.GetCollection<TDocument>(typeName);
            return mongoCollection;
        }
    }
}
