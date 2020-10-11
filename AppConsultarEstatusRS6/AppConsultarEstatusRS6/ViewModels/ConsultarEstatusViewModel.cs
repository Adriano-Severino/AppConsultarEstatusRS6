using EstatusRs6.Core.Models;
using EstatusRs6.Core.Services;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Essentials;

namespace AppConsultarEstatusRS6.ViewModels
{
    public class ConsultarEstatusViewModel : ViewModelBase
    {

       
        
        public IPageDialogService _dialogService;
        private readonly IUserServices _apiService;
        private readonly INavigationService _navigationService;

        private DelegateCommand _consultarEstatus;

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetProperty(ref _nome, value); }
        }
        
        public DelegateCommand ConsultarEstatus => _consultarEstatus ?? (_consultarEstatus = new DelegateCommand(ExecuteConsultarEstatus));
        public ConsultarEstatusViewModel(INavigationService navigationService, IPageDialogService dialogService, IUserServices apiService)
            : base(navigationService)
        {
            _dialogService = dialogService;
            _apiService = apiService;
            _navigationService = navigationService;
        }

        bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;
        async void ExecuteConsultarEstatus()
        {
            await _navigationService.NavigateAsync("Loading");

            #region Buscar os dados
            if (IsConnected)
            {
                // Conectado a internet
                Root Estatus = await _apiService.GetUser(Nome);
                if (Estatus == null)
                {
                    await _dialogService.DisplayAlertAsync("Erro!", "Nenhuma Usuario encontrado", "OK");

                }
                #region Gerenciamento dos dados em arquivos
                else
                { //salvar arquivos no disco
                   if (App.Current.Properties.ContainsKey("User"))
                    {
                        App.Current.Properties.Remove("User");
                        App.Current.Properties.Add("User", JsonConvert.SerializeObject(Estatus));
                        await App.Current.SavePropertiesAsync();
                    }
                    
                   //TODO - implementação para passar os dados em json para proxima tela
                    var navParameters = new NavigationParameters();
                    navParameters.Add("User", "dados em formato de json");
                    await _navigationService.NavigateAsync("EstatusDaConta", navParameters);
                }
                #endregion
            }
            #endregion
            #region Buscar os dados do disco 
            else
            {//buscar arquivo do disco
                if (App.Current.Properties.ContainsKey("User"))
                {

                    //TODO - criar implementação para buscar o json salvo no discor e passar par proxima tela
                    var navParameters = new NavigationParameters();
                    navParameters.Add("User", Nome);
                    await _navigationService.NavigateAsync("EstatusDaConta", navParameters);
                }
            }
            #endregion
        }
    }
}
