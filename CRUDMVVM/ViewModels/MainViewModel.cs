
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CRUDMVVM.Models;
using CRUDMVVM.Services;
using CRUDMVVM.Views;

namespace CRUDMVVM.ViewModels
{
    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Empleado> empleadoCollection = new ObservableCollection<Empleado>();

        private readonly EmpleadoService _service;

        public MainViewModel()
        {
            _service = new EmpleadoService();
        }

        public void GetAll()
        {
            var getAll = _service.GetAll();

            if (getAll.Count > 0)
            {
                EmpleadoCollection.Clear();
                foreach (var empleado in getAll)
                {
                    EmpleadoCollection.Add(empleado);
                }
            }
        }

        [RelayCommand]
        private async Task GoToAddEditView()
        {
            await App.Current! .MainPage! .Navigation .PushAsync(new AddEditView());
        }
    }
}
