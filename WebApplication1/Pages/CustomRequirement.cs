using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Pages
{
    public class CustomRequirement : IAuthorizationRequirement
    {
        public CustomRequirement(string name)
        {

        }

        private readonly string _name;
    }

    public class CustomRequirementHandler : AuthorizationHandler<CustomRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomRequirement requirement)
        {
            if(context.User.HasClaim(x => x.Type == "Department"))
            {
                 context.Succeed(requirement);
            }
            
              return  Task.CompletedTask;
            
        }
    }

}
