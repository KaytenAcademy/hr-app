using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HR.Controllers
{
    public abstract class HRControllerBase: AbpController
    {
        protected HRControllerBase()
        {
            LocalizationSourceName = HRConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
