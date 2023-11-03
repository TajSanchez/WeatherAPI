
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using static System.Net.WebRequestMethods;

var client = new HttpClient();
var apiKey = "0c763d0ee8c7efa01da31db46ecaafe5";

Console.WriteLine("Hello, you are about to recieve a weather update based off of your zip code for: Hayden, Alabama USA.");

var zip = 35079;
var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip={zip},us&appid={apiKey}&units=imperial";

var weather = client.GetStringAsync(weatherURL).Result;

var main = JObject.Parse(weather)["main"].ToString();

var temp = JObject.Parse(main)["temp"].ToString();

var feelsLike= JObject.Parse(main)["feels_like"].ToString();

var humidity = JObject.Parse(main)["humidity"].ToString();

Console.WriteLine();
Console.WriteLine($"The temperature in Hayden, Alabama is: {temp} °F");
Console.WriteLine($"In Hayden, Alabama it feels like: {feelsLike} °F");
Console.WriteLine($"Also the humidity is: {humidity}%");