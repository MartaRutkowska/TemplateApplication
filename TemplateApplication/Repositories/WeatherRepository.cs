using TemplateApplication.Domain.Dtos;
using TemplateApplication.Repositories.Shared;

namespace TemplateApplication.Repositories
{
    public class WeatherRepository : Repository<WeatherForecast>, IWeatherForecastRepository
    {
        private DatabaseContext? DatabaseContext { get => Context as DatabaseContext; }
        public WeatherRepository(DatabaseContext context) : base(context)
        {
        }

        public Task<IEnumerable<WeatherForecast>> GetLastWeatherForecasts(int count)
        {
            //DatabaseContext?.Weather.Take(count);
            throw new NotImplementedException();
        }
    }
}
