using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace lec4_authorization_with_custom_requirment.Authorization
{
    /*
     A requirement must have at least one authorization handler. 
    A handler is of type Authorization Handler<T>, where T is the requirement type
     */
   
        public class MinimumAgeHandler : AuthorizationHandler<MinimumAgeRequirement>
        {
            protected override Task HandleRequirementAsync(
                AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
            {

            //var calculatedAge = 20;//some how we calcualted the age of logged in user

            var user = context.User;
            if (!user.HasClaim(c => c.Type == ClaimTypes.DateOfBirth))
                return Task.CompletedTask;

            var dob = Convert.ToDateTime( user.FindFirst(ClaimTypes.DateOfBirth).Value);
            int calculatedAge = DateTime.Today.Year - dob.Year;

            if (calculatedAge >= requirement.MinimumAge)
                {
                    context.Succeed(requirement);
                }

                return Task.CompletedTask;
            }
        }
    }

