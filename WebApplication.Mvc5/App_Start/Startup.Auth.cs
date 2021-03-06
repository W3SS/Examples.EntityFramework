﻿using System.Configuration;
using Owin;
using WebApplication.DataAccess;

namespace WebApplication.Mvc5
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context, user manager and signin manager to use a single instance per request
            app.CreatePerOwinContext(() => ApplicationDbContext.Create(ConfigurationManager.ConnectionStrings[0].ConnectionString));
        }
    }
}