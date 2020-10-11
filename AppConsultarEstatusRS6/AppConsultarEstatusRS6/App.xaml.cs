
using Prism;
using Prism.Ioc;
using AppConsultarEstatusRS6.ViewModels;
using AppConsultarEstatusRS6.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using EstatusRs6.Core.Services;
using Prism.Plugin.Popups;
using AppConsultarEstatusRS6.Utility.Load;

namespace AppConsultarEstatusRS6
{
    public partial class App
    {
        public static string ApiRainbowSixEstatus = "https://r6.apitab.com/search";
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
            containerRegistry.RegisterPopupNavigationService();
            containerRegistry.RegisterForNavigation<Loading>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ConsultarEstatus, ConsultarEstatusViewModel>();
            containerRegistry.RegisterForNavigation<EstatusDaConta, EstatusDaContaViewModel>();
            // containerRegistry.RegisterSingleton<IRsApiService, RsApiService>();
            //containerRegistry.Register(typeof(IRsApiService), typeof(RsApiService));
            containerRegistry.Register(typeof(IUserServices), typeof(UserService));
        }
    }
}
