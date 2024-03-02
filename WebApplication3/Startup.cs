using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			string con = "Server=(localdb)\\mssqllocaldb;Database=usersdbstore;Trusted_Connection=True;";
			// устанавливаем контекст данных
			services.AddDbContext<UserContext>(options => options.UseSqlServer(con));

			services.AddControllers(); // используем контроллеры без представлений
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseDeveloperExceptionPage();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers(); // подключаем маршрутизацию на контроллеры на основе атрибутов
			});
		}
	}
}
