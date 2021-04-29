using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Core.Infra.Config;

namespace TicTackToe.Api
{
    public static class StartupExtensions
    {
        public static IApplicationBuilder UseCors(this IApplicationBuilder app, IConfiguration configuration)
        {
            var settings = configuration.GetSection(nameof(CORSSettings)).Get<CORSSettings>();

            return app.UseCors(options =>
            {
                options
                    .WithHeaders(settings.AllowHeaders)
                    .WithMethods(settings.AllowMethods)
                    .WithOrigins(settings.AllowOrigins)
                    .WithExposedHeaders(settings.ExposedHeaders);

                // Unable to allow credentials if the "*" wildcard is used for origins
                if (!settings.AllowOrigins.Contains("*") && settings.AllowCredentials)
                {
                    options.AllowCredentials();
                }
            });
        }
    }
}
