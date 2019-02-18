using GuessingGame.BusinessRules;

namespace GuessingGame.Gui.Blazor {

    using Microsoft.AspNetCore.Components.Builder;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup {
        public void Configure(IComponentsApplicationBuilder app) {
            app.AddComponent<App>("app");
        }

        public void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<INumberChecker, NumberChecker>();
        }
    }
}