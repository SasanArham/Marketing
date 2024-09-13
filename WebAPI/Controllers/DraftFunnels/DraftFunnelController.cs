using Application.Modules.DraftFunnels.Commands.CreateDraftFunnel;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.DraftFunnels
{
    public class DraftFunnelController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> PostAsync(CreateDraftFunnelCommand command)
        {
            var createdID = await Mediator.Send(command);
            return Ok(createdID);
        }
    }
}
