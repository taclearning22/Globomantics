using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System.Threading.Tasks;

namespace Globomantics.Controllers
{
    public class ProposalController: Controller
    {
        private readonly IConferenceService conferenceService;
        private readonly IProposalService proposalService;

        public ProposalController(IConferenceService conferenceService, IProposalService proposalService)
        {
            this.conferenceService = conferenceService;
            this.proposalService = proposalService;
        }

        public async Task<IActionResult> Index(int conferenceId)
        {
            var conference = await conferenceService.GetById(conferenceId);
            ViewBag.Title = $"Proposals for Conference {conference.Name} " + $"{conference.Location}";
            ViewBag.ConferenceId = conferenceId;

            return View(await proposalService.GetAll(conferenceId));
        }

        public IActionResult Add(int conferenceId)
        {
            ViewBag.Title = "Add Proposal";
            return View(new ProposalModel { ConferenceId = conferenceId });
        }

        public async Task<IActionResult> Add(ProposalModel proposal)
        {
            if (ModelState.IsValid)
            {
                await proposalService.Add(proposal);
            }
            return RedirectToAction("Index", new {conferenceId = proposal.ConferenceId});
        }
    }
}
