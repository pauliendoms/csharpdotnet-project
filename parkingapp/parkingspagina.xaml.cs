namespace parkingapp;

using System.Text.Json;
using System.Threading.Tasks;
using parkingapp.Models;
using parkingapp.ViewModel;

public partial class ParkingPage : ContentPage
{
    ParkingViewModel vm;
    public IList<Parking> parkings = new List<Parking>();
    public ParkingPage()
    {
        InitializeComponent();
       
        Console.WriteLine(parkings);
        this.BindingContext = vm = new ParkingViewModel();
    }
}