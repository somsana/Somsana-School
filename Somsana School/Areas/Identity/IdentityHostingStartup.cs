using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Somsana_School.Data;

[assembly: HostingStartup(typeof(Somsana_School.Areas.Identity.IdentityHostingStartup))]
namespace Somsana_School.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Somsana_SchoolContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Somsana_SchoolContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Somsana_SchoolContext>();
            });
        }
    }
}