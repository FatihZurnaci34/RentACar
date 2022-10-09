using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentACarMVC.Areas.Identity.Data;
using RentACarMVC.Data;

[assembly: HostingStartup(typeof(RentACarMVC.Areas.Identity.IdentityHostingStartup))]
namespace RentACarMVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RentACarIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RentACarIdentityDbContextConnection")));

                services.AddDefaultIdentity<RentACarUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<RentACarIdentityDbContext>();
            });
        }
    }
}
