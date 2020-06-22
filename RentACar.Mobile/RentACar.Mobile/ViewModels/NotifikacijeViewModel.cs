using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class NotifikacijeViewModel : BaseViewModel
    {
        public readonly APIService _notifikacijeServices = new APIService("Notifikacije");
        public readonly APIService _kupciServices = new APIService("Kupci");

        private Model.Notifikacije _selectedNotifikacija = null;
        public Model.Notifikacije SelectedNotifikacija
        {
            get { return _selectedNotifikacija; }
            set
            {
                SetProperty(ref _selectedNotifikacija, value);
                if (value != null)
                {
                    UkloniNotifikacijuCommand.Execute(null);
                }
            }
        }

        private string _brojNotifikacija = "( 0 )";
        public string BrojNotifikacija
        {
            get { return _brojNotifikacija; }
            set { SetProperty(ref _brojNotifikacija, value); }
        }

        public ObservableCollection<Model.Notifikacije> notifikacijeList { get; set; } = new ObservableCollection<Model.Notifikacije>();
        public ObservableCollection<Model.Notifikacije> procitaneNotifikacijeList { get; set; } = new ObservableCollection<Model.Notifikacije>();
        public ICommand InitCommand { get; set; }
        public ICommand UkloniNotifikacijuCommand { get; set; }
        public NotifikacijeViewModel()
        {
            Title = "Notifikacije";
            InitCommand = new Command(async () => await Init());
            UkloniNotifikacijuCommand = new Command(async () => await UkloniNotifikaciju());
        }
        public async Task Init()
        {
            var kupac = await _kupciServices.Get<List<Model.Kupci>>(new KupciSearchRequest() { KorisnickoIme = APIService.Username });
            if (kupac.Count != 0)
            {
                IsBusy = true;
                try
                {
                    var list = await _notifikacijeServices.Get<List<Model.Notifikacije>>(new NotifikacijeSearchRequest() { KupacId = kupac[0].KupacId});
                    BrojNotifikacija = $"({list.Where(x => x.Status).Count()})";
                    notifikacijeList.Clear();
                    procitaneNotifikacijeList.Clear();
                    foreach (var item in list)
                    {
                        if (item.Status)
                        {
                            notifikacijeList.Add(item);
                        }
                        else
                        {
                            procitaneNotifikacijeList.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
                finally
                {
                    IsBusy = false;
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Prijavite se kao kupac!", "Uredu");
                Application.Current.MainPage = new RentACar.Mobile.Views.LogoutPage();
                return;
            }

        }

        public async Task UkloniNotifikaciju()
        {
            try
            {
                NotifikacijeUpsertRequest request = new NotifikacijeUpsertRequest()
                {
                    Status = false,
                    DatumSlanja = SelectedNotifikacija.DatumSlanja,
                    Naziv = SelectedNotifikacija.Naziv,
                    NovostId = SelectedNotifikacija.NovostId,
                    KupacId = SelectedNotifikacija.KupacId,
                };
                var entity = await _notifikacijeServices.Update<Model.Notifikacije>(SelectedNotifikacija.NotifikacijaId, request);
                if (entity != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Obavjest", "Notifikacija ulonjena!", "Uredu");
                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "Uredu");
            }

            await Init();
        }

    }
}
