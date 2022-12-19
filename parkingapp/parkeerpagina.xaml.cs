using parkingapp.ViewModel;
using System.Collections.ObjectModel;

namespace parkingapp;

public partial class ParkeerPage : ContentPage
{
	ParkeerViewModel vm;
		
	public ParkeerPage()
	{
		InitializeComponent();
		Console.WriteLine("HERE WE ARE NOW!");
		
		BindingContext = vm = new ParkeerViewModel();
		Console.WriteLine(vm.Parkings);
	}
}