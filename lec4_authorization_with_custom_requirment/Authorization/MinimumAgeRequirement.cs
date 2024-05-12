using Microsoft.AspNetCore.Authorization;

/*
 A policy requirement is made of two elements: a requirement class that holds just data, 
and an authorization handler that validates the data against the user. 
 */
public class MinimumAgeRequirement : IAuthorizationRequirement
{
    public MinimumAgeRequirement(int minimumAge) =>
        MinimumAge = minimumAge;

    public int MinimumAge { get; }
}