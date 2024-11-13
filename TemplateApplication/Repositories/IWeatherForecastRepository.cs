using TemplateApplication.Repositories.Shared;

namespace TemplateApplication.Repositories
{
    public interface IWeatherForecastRepository : IRepository<WeatherForecast>
    {
        Task<IEnumerable<WeatherForecast>> GetLastWeatherForecasts(int count);
    }
}
