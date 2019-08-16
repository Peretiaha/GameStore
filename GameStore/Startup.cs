
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GameStore.BLL.Interfaces;
using GameStore.BLL.Services;
using GameStore.DAL.Interfaces;
using GameStore.DAL.Repository;
using GameStoreModel;
using Infrastructure.Infrastracture;
using Autofac;
using Autofac.Extensions.DependencyInjection;

namespace GameStore
{
    using System;

    using Autofac.Core;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var connection = @"Server=EPUAKHAW0861;Database=GameStoreDb;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<GameStoreDb>
                (options => options.UseSqlServer(connection));


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var builder = new ContainerBuilder();

            builder.RegisterType<GameStoreDb>().AsSelf().SingleInstance();
            builder.RegisterType<RepositoryFactory>().As<IRepositoryFactory>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().SingleInstance();
            builder.RegisterType<CommentService>().As<ICommentService>().SingleInstance();
            builder.RegisterType<GameService>().As<IGameService>().SingleInstance();


            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));

            builder.RegisterAssemblyTypes(typeof(GameService).Assembly).Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerDependency();

            builder.Populate(services);

            var container = builder.Build();
            //return new AutofacServiceProvider(container);
            return container.Resolve<IServiceProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
