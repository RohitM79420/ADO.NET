using Microsoft.Extensions.Configuration;
using ADO.NET;
internal class Program
{
    private static IConfiguration _iconfiguration;
    private static void Main(string[] args)
    {
        GetAppSettingsFile();
        PrintProduct();
    }
    static void GetAppSettingsFile()
    {
        var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
        _iconfiguration = builder.Build();
    }


    static void PrintProduct()
    {
        Productlayer obj = new Productlayer( _iconfiguration);
        obj.Products();
    }
}