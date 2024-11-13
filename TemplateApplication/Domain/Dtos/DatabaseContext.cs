using Microsoft.EntityFrameworkCore;

namespace TemplateApplication.Domain.Dtos
{
    public class DatabaseContext : DbContext
    {
        public DbSet<WeatherDto> Weather { get; set; }

    }
}
