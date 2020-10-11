using EstatusRs6.Core.Models;
using EstatusRs6.Core.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Extensions;
using Prism.Navigation.Xaml;
using AppConsultarEstatusRS6.Utility.Load;
using System.Threading.Tasks;

namespace AppConsultarEstatusRS6.ViewModels
{
    public class EstatusDaContaViewModel : BindableBase, INavigatedAware
    {

        public IPageDialogService _dialogService;

        private readonly IUserServices _apiService;
        private readonly INavigationService _navigationService;

        private string _nome;
        private string _estatuNome;
        public string Estatuome
        {
            get { return _estatuNome; }
            set { SetProperty(ref _estatuNome, value); }
        }

        //string _selectedName;
        //public string SelectedName
        //{
        //    get { return _selectedName; }
        //    set 
        //    { 
        //        SetProperty(ref _selectedName, value);
        //        if (_selectedName != null)
        //        {
        //            _dialogService.DisplayAlertAsync("list item selecionado","SelectedName é " + _selectedName,"OK");
        //        }
        //    }
        //}



        private DelegateCommand _voltarConsultarEstatus;

        public DelegateCommand VoltarConsultarEstatus => _voltarConsultarEstatus ?? (_voltarConsultarEstatus = new DelegateCommand(ExecuteVoltarConsultarEstatus));
        public EstatusDaContaViewModel(INavigationService navigationService, IPageDialogService dialogService)
          
        {
            _dialogService = dialogService;
            _navigationService = navigationService;
        }


        async void ExecuteVoltarConsultarEstatus()
        {
            await _navigationService.GoBackAsync();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
          
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

            if (parameters.ContainsKey("User"))
            {
                _nome = (string)parameters["User"];
            }
        }
    }
}
