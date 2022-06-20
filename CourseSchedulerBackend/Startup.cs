using Autofac;
using Autofac.Extensions.DependencyInjection;

namespace CourseSchedulerBackend
{
    public class Startup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            var builder = new ContainerBuilder();
            builder.Populate(services);

            var container = builder.Build();
            return new AutofacServiceProvider(container);
        }

    }
}
