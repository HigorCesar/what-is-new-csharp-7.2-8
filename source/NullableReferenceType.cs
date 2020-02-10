using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace WhatIsNewInCSharp
{
    public class GetWeatherInput
    {
        [Required]
        public int Latitude { get; set; }

        [Required]
        public int Longitude { get; set; }

        [Timestamp] //Nullable and not required
        public DateTime? Timestamp { get; set; }
    }

    public class WeatherOutputItem
    {
        public double Precision { get; set; }
        public double Pressure { get; set; }
        public double Value { get; set; }
    }

    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class GetWeatherOutput
    {
        public DateTime? When { get; set; }
        public Location Location { get; set; }
        public WeatherOutputItem? WeatherCondition { get; set; }
    }

    class WeatherService
    {
        public static GetWeatherOutput GetWeather(GetWeatherInput input)
        {
            var url = $"latitude=${input.Latitude}&longitude={input.Longitude}&timestamp={input.Timestamp}";
            return new GetWeatherOutput
            {
                Location = new Location
                {
                    Latitude = 52.36, Longitude = 4.89
                },
                When = DateTime.UtcNow
            };
        }
    }

    class WeatherServiceClient
    {
        public void GetWeatherConditionsForAmsterdam()
        {
            var weatherOutput = WeatherService.GetWeather(new GetWeatherInput());


            //if(DateTime.Compare(weatherOutput.When,DateTime.UtcNow.AddHours(-2))>=0)//Doesn't compile as the functions expects non null, we should build code this way with intent.
            Console.WriteLine($"Amsterdam time:{weatherOutput.When.Value.AddHours(1)}");

            #nullable enable
            Console.WriteLine($"Amsterdam pressure: {weatherOutput.WeatherCondition.Pressure}");
        }
    }
}