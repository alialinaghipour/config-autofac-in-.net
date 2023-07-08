using Api.Contracts;

namespace Api.Services;

public interface IDateTimeService : ISingleton
{
    DateTime Now { get; }
}

public class DateTimeAppService : IDateTimeService
{
    public DateTime Now => DateTime.UtcNow;
}