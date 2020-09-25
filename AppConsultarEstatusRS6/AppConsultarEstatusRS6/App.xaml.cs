using Prism;
using Prism.Ioc;
using AppConsultarEstatusRS6.ViewModels;
using AppConsultarEstatusRS6.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;

namespace AppConsultarEstatusRS6
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/ConsultarEstatus");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ConsultarEstatus, ConsultarEstatusViewModel>();
            containerRegistry.RegisterForNavigation<EstatusDaConta, EstatusDaContaViewModel>();
        }
    }
}
