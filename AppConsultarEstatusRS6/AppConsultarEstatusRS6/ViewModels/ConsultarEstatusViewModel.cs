using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppConsultarEstatusRS6.ViewModels
{
    public class ConsultarEstatusViewModel : ViewModelBase
    {
     

        private readonly INavigationService _navigationService;

        private DelegateCommand _consultarEstatus;

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        
        public DelegateCommand ConsultarEstatus => _consultarEstatus ?? (_consultarEstatus = new DelegateCommand(ExecuteConsultarEstatus));
        public ConsultarEstatusViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
        }


        async void ExecuteConsultarEstatus()
        {
            var navParameters = new NavigationParameters();
            navParameters.Add("User", Name);
            await _navigationService.NavigateAsync("EstatusDaConta",navParameters);
           
        }
    }
}
