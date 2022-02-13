﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Movies.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Aggregates.Extensions
{
	public static class MongoDbExtension
	{
		public static IServiceCollection AddMongoDbSettings(this IServiceCollection services,
		   IConfiguration configuration)
		{
			return services.Configure<MongoDbSettings>(options =>
			{
				options.ConnectionString = configuration
					.GetSection(nameof(MongoDbSettings) + ":" + MongoDbSettings.ConnectionStringValue).Value;
				options.Database = configuration
					.GetSection(nameof(MongoDbSettings) + ":" + MongoDbSettings.DatabaseValue).Value;
			});
		}
	}
}
