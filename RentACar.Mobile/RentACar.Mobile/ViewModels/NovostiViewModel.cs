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
    public class NovostiViewModel:BaseViewModel
    {
        public readonly APIService _novostiServices = new APIService("Novosti");
        public ObservableCollection<Model.Novosti> novostiList { get; set; } = new ObservableCollection<Model.Novosti>();

        public ICommand InitCommand { get; set; }
        public NovostiViewModel()
        {
            Title = "Novosti";
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {
            IsBusy = true;
            try
            {
                novostiList.Clear();
                var list = await _novostiServices.Get<List<Model.Novosti>>(null);
                foreach (var item in list)
                {
                    novostiList.Add(item);
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
    }
}
