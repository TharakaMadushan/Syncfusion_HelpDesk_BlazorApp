﻿using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SyncfusionHelpDeskBlazorApp.Server.Models;

namespace SyncfusionHelpDeskBlazorApp.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        //public ApplicationDbContext(
        //    DbContextOptions options,
        //    IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        //{
        //}

        public ApplicationDbContext(
 DbContextOptions<ApplicationDbContext> options,
 IOptions<OperationalStoreOptions> operationalStoreOptions) :
 base(options, operationalStoreOptions)
        {
        }
    }
}