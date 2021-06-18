using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace Microservice.Auth.API.Helpers
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("api","API")
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                // Student client
                new Client
                {
                    ClientId = "stud",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AccessTokenType = AccessTokenType.Jwt,

                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    // scopes that client has access to
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api"
                    }
                }
            };
        }
}
