using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppConsultarEstatusRS6.ViewModels
{
    public class ConsultarEstatusViewModel : BindableBase
    {

        private readonly INavigationService _navigationService;

        private DelegateCommand _consultarEstatus;

        public DelegateCommand ConsultarEstatus => _consultarEstatus ?? (_consultarEstatus = new DelegateCommand(ExecuteConsultarEstatus));
        public ConsultarEstatusViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        async void ExecuteConsultarEstatus()
        {
           await _navigationService.NavigateAsync("EstatusDaConta");
        }
    }
}
