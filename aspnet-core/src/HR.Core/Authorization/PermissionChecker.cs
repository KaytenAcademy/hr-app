using Abp.Authorization;
using HR.Authorization.Roles;
using HR.Authorization.Users;

namespace HR.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
