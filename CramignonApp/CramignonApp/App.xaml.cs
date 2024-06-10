using CramignonApp.Pages;
using CramignonApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace CramignonApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current => (App)Application.Current;

        public IServiceProvider ServiceProvider { get; private set; } = null!;

        protected override void OnStartup(StartupEventArgs e)
        {
            ServiceCollection services = new();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            var window = ServiceProvider.GetRequiredService<MainWindow>();

            window.Show();

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            
            // PAGES
            services.AddSingleton<StartPage>();
            services.AddSingleton<PeoplePage>();

            // SERVICES
            services.AddSingleton<IPeopleService,PeopleService>();
        }

    }

}
