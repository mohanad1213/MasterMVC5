using Castle.Core.Logging;
using MasterNet;
using TestStack.Seleno;
using TestStack.Seleno.Configuration;

public static class Host
{
    public static readonly SelenoHost Instance = new SelenoHost();

    static Host()
    {
        Instance.Run("Name.Of.Your.Web.Project", 12346, c => c
            .UsingLoggerFactory(new ConsoleFactory())
            // If you are using MVC then do this where RouteConfig is the class that registers your routes in the "Name.Of.Your.Web.Project" project
            // If you aren't using MVC then don't include this line
            .WithRouteConfig(RouteConfig.RegisterRoutes)
        );
    }
}