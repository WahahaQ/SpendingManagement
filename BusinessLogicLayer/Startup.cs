using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DataAccessLayer;
using AutoMapper;

namespace BusinessLogicLayer
{
	public class Startup
	{
		#region Fields

		public IConfiguration Configuration { get; }

		#endregion Fields

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		#region Methods

		public void ConfigureServices(IServiceCollection services)
		{
			// Adding Context which using SQL server:
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(Configuration["ConnectionString"]));

			// Creating mapper as singleton onject:
			MapperConfiguration config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new MapperConfigurator());
			});

			IMapper mapper = config.CreateMapper();
			services.AddSingleton(mapper);

			services.AddControllers();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();
			app.UseRouting();
			app.UseAuthorization();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}

		#endregion Methods
	}
}