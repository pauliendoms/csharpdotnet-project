using parkingapp.Models;
using parkingapp.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace parkingapp.ViewModel;

public class ParkingViewModel : INotifyPropertyChanged
{
    public IDataStore DataStore => DependencyService.Get<IDataStore>();
    List<Parking> _parkings;
    List<List<Parking>> _parkingsByCity;

    new public event PropertyChangedEventHandler PropertyChanged;
    new protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        var changed = PropertyChanged;
        if (changed == null)
            return;
        changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public List<Parking> Parkings
    {
        get { return _parkings; }
        set
        {
            _parkings = value;
            OnPropertyChanged();
        }
    }

    public List<List<Parking>> ParkingsByCity
    {
        get { return _parkingsByCity; }
        set
        {
            _parkingsByCity = value;
            OnPropertyChanged();
        }
    }

    public ParkingViewModel()
    {
        GetParkings();
    }

    public async void GetParkings()
    {
        _parkings = await DataStore.GetParkings();
        Console.WriteLine(_parkings[4].capacity);
    }

    public async void GetParkingsByStad()
    {
        _parkingsByCity = await DataStore.GetParkingsByStad();
        Console.WriteLine(_parkingsByCity.Count());
    }
}