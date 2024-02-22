using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Reflection.Metadata;

namespace JWT_Authentication;

public class CustomRoleRequirement : AuthorizationHandler<CustomRoleRequirement>, IAuthorizationRequirement
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CustomRoleRequirement(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomRoleRequirement requirement)
    {
        var roles = new[] { "Admin", "Admin2", "Admin3" }; //Get all roles from DB

        var requestPath = _httpContextAccessor?.HttpContext?.Request.Path;

        var userIsInRole = roles.Any(role => context.User.IsInRole(role));
        if (!userIsInRole)
        {
            context.Fail();
        }
        else
        {
            context.Succeed(requirement);
        }

        return Task.CompletedTask;
    }
}

