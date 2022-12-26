using IknowDemo.Business.Abstract;
using IknowDemo.Business.Concrete;
using IknowDemo.DataAccess.Abstract;
using IknowDemo.DataAccess.Concrete;

namespace IknowDemo.API
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IAgendaItemService, AgendaItemManager>();
            services.AddSingleton<IAgendaItemRepository, AgendaItemRepository>();
            services.AddRazorPages();
        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseAuthorization();
            app.MapRazorPages();
            app.Run();
        }
    }
}
