using STRIVE.Trains.WithInventory.Legs;

namespace STRIVE.Trains.WithInventory;

public partial class LegsTrainWith : ContentPage
{
	public LegsTrainWith()
	{
		InitializeComponent();
	}

	async void Prised(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Prised());
	}

	async void RazgibSecond(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new razgibNog());
	}

	async void Vipadi(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new BolgarVipadi());
	}

	async void RazgibFirst(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new legExtension());
	}
}