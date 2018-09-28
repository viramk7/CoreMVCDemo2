using CoreMVCDemo2.Repositories;
using CoreMVCDemo2.Repositories.StudentRepository;
using CoreMVCDemo2.Services;
using CoreMVCDemo2.Services.City;
using CoreMVCDemo2.Services.Student;
using Microsoft.Extensions.DependencyInjection;

namespace CoreMVCDemo2
{
    public static class DependencyRegistrar
    {
        public static void Register(IServiceCollection service)
        {
            // Repositories
            service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddScoped<IStudentRepository, StudentRepository>();

            // Unit of work
            service.AddScoped<IUnitOfWork, UnitOfWork>();

            // services
            service.AddScoped(typeof(IEntityService<>), typeof(EntityService<>));
            service.AddScoped<IStudentService, StudentService>();
            service.AddScoped<ICityService, CityService>();
        }
    }
}
