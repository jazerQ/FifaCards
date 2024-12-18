using DataAccess.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public static class Extensions
	{
		public static IServiceCollection AddBusinessLogic(this IServiceCollection services) 
		{
			services.AddScoped<IFifaCardService, FifaCardService>();
			return services;
		}
	}
}
