using Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Globomantics.Services
{
    public interface IProposalService
    {
        Task Add(ProposalModel model);
        Task<ProposalModel> Approve(int proposalId);
        Task<IEnumerable<ProposalModel>> GetAll(int conferenceId);
    }
}
