using parkingapp.Models;
using parkingapp.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace parkingapp.ViewModel;

public class ParkeerViewModel : INotifyPropertyChanged
{
    public IDataStore DataStore => DependencyService.Get<IDataStore>();
    List<Parking> _parkings;
    public Command ParkeerCommand { get; }
    Parking _selectedParking;
    public Command VertrekCommand { get; }
    bool _show;

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
        set { 
            _parkings = value;
            OnPropertyChanged();
        }
    }

    public Parking SelectedParking
    {
        get { return _selectedParking; }
        set
        {
            _selectedParking = value;
            OnPropertyChanged();
        }
    }

    public bool Show
    {
        get { return _show; }
        set {
            _show = value;
            OnPropertyChanged();
        }
    }

    public ParkeerViewModel()
    {
        GetParkings();
        ParkeerCommand = new Command(Parkeer);
        VertrekCommand = new Command(Vertrek);
    }

    public async void GetParkings()
    {
        _parkings = await DataStore.GetParkings();
        Console.WriteLine(_parkings[4].capacity);
    }

    public async void Parkeer()
    {
        Show = false;
        await DataStore.Parkeer(_selectedParking.id);
    }

    public async void Vertrek()
    {
        Show = true;
        await DataStore.Vertrek(_selectedParking.id);
    }
}