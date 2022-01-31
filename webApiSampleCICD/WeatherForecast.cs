using System;

namespace webApiSampleCICD
{
    public class WeatherForecast
    {
        public WeatherForecast()
        {

        }

        public WeatherForecast(DateTime date, int temperature)
        {
            Date = date;
            TemperatureC = temperature;
        }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public override string ToString()
        {
            return string.Format("Day: {0} - Temp: {1}F", Date.ToString("ddMMyyyy"), TemperatureF);
        }
    }
}
