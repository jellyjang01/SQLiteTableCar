using SQLiteTableCar.MVVM.Models;
using SQLiteTableCar.Repositories;

namespace SQLiteTableCar;

public partial class App : Application
{
	public static CarRepository _carRepo {get ; set;}
	public App(CarRepository carRepo)
	{
		InitializeComponent();

		_carRepo = carRepo;

		//MainPage = new AppShell();
		MainPage = new CarPage();
	}
}
