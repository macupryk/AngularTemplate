using System.Threading.Tasks;
using Abp.Application.Services;
using AngularProject.Sessions.Dto;

namespace AngularProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
