using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StepToDo.Presentation.Models;

//[assembly: HostingStartup(typeof(StepToDo.Presentation.Areas.Identity.IdentityHostingStartup))]
//namespace StepToDo.Presentation.Areas.Identity
//{
//    public class IdentityHostingStartup : IHostingStartup
//    {
//        public void Configure(IWebHostBuilder builder)
//        {
//            builder.ConfigureServices((context, services) => {
//                services.AddDbContext<StepToDoPresentationContext>(options =>
//                    options.UseSqlServer(
//                        context.Configuration.GetConnectionString("StepToDoPresentationContextConnection")));

//                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//                    .AddEntityFrameworkStores<StepToDoPresentationContext>();
//            });
//        }
//    }
//}