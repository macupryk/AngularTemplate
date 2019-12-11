using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AngularProject.MultiTenancy.Dto;

namespace AngularProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

