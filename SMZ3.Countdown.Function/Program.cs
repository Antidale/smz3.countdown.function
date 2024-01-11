using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        services.AddHttpClient("SMZ3MainSite", client =>
        {
            client.BaseAddress = new Uri("https://samus.link/api/spoiler/");
        });

        services.AddHttpClient("SMZ3BetaSite", client =>
        {
            client.BaseAddress = new Uri("https://beta.samus.link/api/spoiler/");
        });

        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
    })
    .Build();

host.Run();
