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
using EstatusRs6.Core.Exceptions;
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

        private string _name;
        private string _estatuName;
        public string EstatuName
        {
            get { return _estatuName; }
            set { SetProperty(ref _estatuName, value); }
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
        public EstatusDaContaViewModel(INavigationService navigationService, IPageDialogService dialogService, IUserServices apiService)
          
        {
            _dialogService = dialogService;
            _apiService = apiService;
            _navigationService = navigationService;
        }


        async void ExecuteVoltarConsultarEstatus()
        {
           
            await _navigationService.NavigateAsync("Loading");

            //await Navigation.PushPopupAsync(new Loading());
            Root Estatus = await _apiService.GetUser(_name);

            if (Estatus == null)
            {
                await _dialogService.DisplayAlertAsync("Erro!", "Nenhuma Usuario encontrado", "OK");

            }
            //TODO - implementar metodo para chegar conecao com a internet caso esteje sem conexao cehgar se existe arquivo salvo anterior
            else
            { //salvar arquivos no disco
                App.Current.Properties.Add("User", JsonConvert.SerializeObject(Estatus));
                await App.Current.SavePropertiesAsync();
                await _navigationService.GoBackAsync();
            }
            //}
            await _navigationService.NavigateAsync("EstatusDaConta");
            //await Navigation.PopAllPopupAsync();
            // await _navigationService.GoBackAsync();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
          
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("User"))
            {
                _name = (string)parameters["User"];
            }
        }
    }
}
