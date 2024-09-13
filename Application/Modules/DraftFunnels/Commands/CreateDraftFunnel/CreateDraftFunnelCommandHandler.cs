using Domain.Aggregates.DraftFunnels;
using Domain.Aggregates.DraftFunnels.Services;
using MediatR;

namespace Application.Modules.DraftFunnels.Commands.CreateDraftFunnel
{

    public class CreateDraftFunnelCommandHandler : IRequestHandler<CreateDraftFunnelCommand, Guid>
    {
        private readonly IDraftFunnelRepository _draftFunnelRepository;

        public CreateDraftFunnelCommandHandler(IDraftFunnelRepository draftFunnelRepository)
        {
            _draftFunnelRepository = draftFunnelRepository;
        }
        public async Task<Guid> Handle(CreateDraftFunnelCommand command, CancellationToken cancellationToken)
        {
            var draftFunnel = new DraftFunnel(command.Name, command.Color);
            await _draftFunnelRepository.InsertAsync(draftFunnel, cancellationToken);
            return draftFunnel.ID;
        }
    }
}
