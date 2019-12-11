using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AngularProject.Controllers
{
    public abstract class AngularProjectControllerBase: AbpController
    {
        protected AngularProjectControllerBase()
        {
            LocalizationSourceName = AngularProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
