namespace TemplateApplication.Repositories.Shared
{
    public interface IUnitOfWork : IDisposable
    {
        IWeatherForecastRepository WeatherForecastRepository { get; }
        Task<int> Complete();
    }
}
