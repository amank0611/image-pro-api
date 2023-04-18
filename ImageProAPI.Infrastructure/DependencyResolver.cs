using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProAPI.Infrastructure
{
   public static class DependencyResolver
    {
        public static void AddDependencyResolver(this IServiceCollection services)
        {
             
            //services.AddSingleton<ILoggerService, LogService>();
            //services.AddScoped(typeof(IAutoMapConverter<,>), typeof(AutoMapConverter<,>));
        }
    }
}
