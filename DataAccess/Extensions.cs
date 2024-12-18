using DataAccess.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataAccess
{
	public static class Extensions
	{

		public static IServiceCollection AddDataAccess(this IServiceCollection services) 
		{
			services.AddScoped<IFifaCardsRepository, FifaCardsRepository>();
			services.AddDbContext<FifaContext>(async options =>
			{
				var connectionString = "Data Source=C:\\Users\\user\\source\\repos\\FifaCards\\FifaCards\\FifaDatabase.db";
				options.UseSqlite(connectionString);
			});
			return services;
		}
	}
	public class ConnectionStringModel
	{
		public string DefaultConnection { get; set; }
	}
}
