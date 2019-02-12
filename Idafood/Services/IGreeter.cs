using Idafood;
using Idafood.Services;
using Microsoft.Extensions.Configuration;
//Greeting Interface created and injected as a singleton service in startup cs
//The greeter class implement the IGreeter interface method GetMessageOfTheDay 
//GetMessageOfTheDay method is getting the greeting from  appsettings.json file
namespace Idafood.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }
}

public class Greeter : IGreeter
{
    private IConfiguration _configuration;
    public Greeter(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GetMessageOfTheDay()
    {
        return _configuration["Greeting"];
    }
}