using SQLiteTableCar.MVVM.ViewModels;

namespace SQLiteTableCar;

public partial class CarPage : ContentPage
{
	public CarPage()
	{
		InitializeComponent();
		BindingContext = new CarPageViewModel();
	}
}