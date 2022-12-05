using System.Collections.ObjectModel;

namespace parkingapp;

public class Parking
{
	public string name {  get; set; }
	public Parking(string naam)
	{
		name = naam;
	}
}

public partial class ParkeerPage : ContentPage
{
	public ObservableCollection<Parking> park { get; set; } = new ObservableCollection<Parking>();
	public IList<Parking> parkings { get; set; } = new List<Parking>();	
		
	public ParkeerPage()
	{
		InitializeComponent();
		parkings.Add(new Parking("Parking 1"));
		parkings.Add(new Parking("Parking 2"));
		parkings.Add(new Parking("Parking 3"));

		BindingContext = this;
	}
}