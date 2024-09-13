using Domain.Shared;
using MediatR;

namespace Application.Modules.DraftFunnels.Commands.CreateDraftFunnel
{
    public record CreateDraftFunnelCommand : IRequest<Guid>
    {
        public string Name { get; init; } = string.Empty;
        public Color Color { get; init; }
    }
}
