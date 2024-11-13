
using Microsoft.EntityFrameworkCore;

namespace TemplateApplication.Repositories
{
    public class WeatherRepository : Repository<WeatherForecast>, IWeatherForecastRepository
    {
        public WeatherRepository(DbContext context) : base(context)
        {
        }

        public Task<IEnumerable<WeatherForecast>> GetLastWeatherForecasts(int count)
        {
            //custom get from db
            throw new NotImplementedException();
        }
    }
}
