using Microsoft.Extensions.DependencyInjection;
using NewArch.Application.Interfaces;
using NewArch.Application.Services;
using NewArch.Domain.Interfaces;
using NewArch.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewArch.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();


        }
    }
}
