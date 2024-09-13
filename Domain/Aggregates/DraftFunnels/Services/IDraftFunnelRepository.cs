namespace Domain.Aggregates.DraftFunnels.Services
{
    public interface IDraftFunnelRepository
    {
        Task<DraftFunnel> Find(Guid ID);
        Task InsertAsync(DraftFunnel draftFunnel, CancellationToken cancellationToken);
    }
}
