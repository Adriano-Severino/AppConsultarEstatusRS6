using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppConsultarEstatusRS6.ViewModels
{
    public class EstatusDaContaViewModel : BindableBase
    {

        private readonly INavigationService _navigationService;

        private DelegateCommand _voltarConsultarEstatus;

        public DelegateCommand VoltarConsultarEstatus => _voltarConsultarEstatus ?? (_voltarConsultarEstatus = new DelegateCommand(ExecuteVoltarConsultarEstatus));
        public EstatusDaContaViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        async void ExecuteVoltarConsultarEstatus()
        {
            await _navigationService.GoBackAsync();
        }
    }
}
