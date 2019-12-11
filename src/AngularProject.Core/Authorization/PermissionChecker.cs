using Abp.Authorization;
using AngularProject.Authorization.Roles;
using AngularProject.Authorization.Users;

namespace AngularProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
