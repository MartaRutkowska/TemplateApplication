using TemplateApplication.Domain.Dtos;
using TemplateApplication.Repositories.Shared;

namespace TemplateApplication.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext DatabaseContext;
        public IWeatherForecastRepository WeatherForecastRepository { get; private set; }

        public UnitOfWork(DatabaseContext context)
        {
            DatabaseContext = context;
            WeatherForecastRepository = new WeatherRepository(DatabaseContext);
        }


        public async Task<int> Complete() => await DatabaseContext.SaveChangesAsync();

        public async void Dispose() => await DatabaseContext.DisposeAsync();
    }
}
