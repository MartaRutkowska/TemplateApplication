namespace TemplateApplication.Domain.Dtos
{
    public class WeatherDto
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }
    }
}
