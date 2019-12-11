using System.Threading.Tasks;
using Abp.Application.Services;
using AngularProject.Authorization.Accounts.Dto;

namespace AngularProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
