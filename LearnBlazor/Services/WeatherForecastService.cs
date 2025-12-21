namespace LearnBlazor.Services;

public class WeatherForecastService
{
    private readonly string[] _summaries =
        ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

    public Task<WeatherForecast[]> GetForecastAsync (int Days)
    {
        var startDate = DateOnly.FromDateTime (DateTime.Now);

        return Task.FromResult(Enumerable.Range (1, Days).Select (index => new WeatherForecast
        {
            Date = startDate.AddDays (index),
            TemperatureC = Random.Shared.Next (-20, 55),
            Summary = _summaries[Random.Shared.Next (_summaries.Length)]
        }).ToArray ());
    }
}