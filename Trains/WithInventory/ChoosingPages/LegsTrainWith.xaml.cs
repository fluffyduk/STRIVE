using STRIVE.Cards.LegsWith;
using STRIVE.Trains.WithInventory.Legs;

namespace STRIVE.Trains.WithInventory;

public partial class LegsTrainWith : ContentPage
{
	public LegsTrainWith()
	{
		InitializeComponent();
	}

    async void barbellsquatd(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Prised());
    }

    async void BolgarVipadi(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BolgarVipadi());
    }

    async void legExtension(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new legExtension());
    }

    async void razgibNog(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new razgibNog());
    }
}